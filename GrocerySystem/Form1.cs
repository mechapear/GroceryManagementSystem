using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // need for all file operator -  stream reader, stream writer
using System.Reflection.Emit;
using System.Web;

namespace GrocerySystem
{
    public partial class Form1 : Form
    {
        List<Grocery> GroceryList = new List<Grocery>();
        public Form1()
        {
            InitializeComponent();
        }

        // method for reading input from file
        private void InputReader(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream)
                {
                    string headerLine = reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    string eachLine = reader.ReadLine();
                    string[] Fields = eachLine.Split(','); // split data with ',' and put it in Fields array
                    // every elements are string - parsed (as needed)
                    string itemCode = Fields[1];
                    string itemName = Fields[0];
                    double.TryParse(Fields[2], out double unitPrice);
                    int.TryParse(Fields[6], out int qtyMinForRestock);
                    int.TryParse(Fields[3], out int initialQty);
                    int.TryParse(Fields[4], out int qtySold);
                    int.TryParse(Fields[5], out int qtyRestocked);
                    // add grocery record into grocery list
                    Grocery groceryItem = new Grocery(itemCode, itemName, unitPrice, qtyMinForRestock, initialQty, qtySold, qtyRestocked);
                    GroceryList.Add(groceryItem);
                }
            }
        }

        // method for loading grocery list to list box
        private void LoadItemsToListBox()
        {
            GroceryListBox.Items.Clear();
            // add header
            GroceryListBox.Items.Add(string.Format("{0,-15}{1,-22}{2,-12}{3,-18}{4,-14}{5,-14}{6,-14}{7,-14}{8,-10}",
                                    "ItemCode", "ItemName", "UnitPrice", "QtyMinForRestock", "InitialQty", "QtySold", "QtyRestocked", "AvailableQty", "Sales"));
            // add each item
            foreach (Grocery item in GroceryList)
            {
                GroceryListBox.Items.Add(item);
            }
        }

        // method for event handler
        private void LoadGroceryButton_Click(object sender, EventArgs e)
        {
            GroceryList.Clear(); // clear all previous grocery data
            try
            {
                InputReader("productlist.csv");
                LoadItemsToListBox();
                // update status label
                StatusLabel.Text = "Load " + GroceryList.Count + " items from input file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateQtySoldButton_Click(object sender, EventArgs e)
        {
            int itemIndex = GroceryListBox.SelectedIndex;
            if (itemIndex <= 0) // -1 = no item is selected or 0 = headerline is selected
            {
                StatusLabel.Text = "Please selected a grocery item to increment sold qty";
            } else if (GroceryList.Count > 0)  
            {
                if (QtySoldTextBox.Text == "") // checking the input from QtySoldTextBox
                {
                    StatusLabel.Text = "Please enter Quantity Sold";
                }
                else if (!int.TryParse(QtySoldTextBox.Text, out int QtySold) || QtySold <= 0 || QtySold > GroceryList[itemIndex-1].AvailableQty)
                {
                    StatusLabel.Text = "Please enter valid data";
                }
                else
                {
                    // increment the QtySold field by the amount given by user
                    GroceryList[itemIndex - 1].QtySold += QtySold;
                    // update Grocery list box to show new update information for selected updated item
                    GroceryListBox.Items[itemIndex] = GroceryList[itemIndex - 1];
                    // update status label
                    StatusLabel.Text = "Sold Qty has been increased for item with item code " + GroceryList[itemIndex - 1].ItemCode;
                    // clear textbox after the item is added to the list
                    QtySoldTextBox.Text = "";
                }
            }
        }

        private void UpdateQtyRestockedButton_Click(object sender, EventArgs e)
        {
            int itemIndex = GroceryListBox.SelectedIndex;
            if (itemIndex <= 0) // -1 = no item is selected or 0 = headerline is selected
            {
                StatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else if (GroceryList.Count > 0)
            {
                if (QtyRestockedTextBox.Text == "") // checking the input from QtySoldTextBox
                {
                    StatusLabel.Text = "Please enter Quantity Restocked";
                }
                else if (!int.TryParse(QtyRestockedTextBox.Text, out int QtyRestocked) || QtyRestocked <= 0)
                {
                    StatusLabel.Text = "Please enter valid data";
                }
                else
                {
                    // increment the QtyRestocked field by the amount given by user 
                    GroceryList[itemIndex - 1].QtyRestocked += QtyRestocked;
                    // update Grocery list box to show new update information for selected updated item
                    GroceryListBox.Items[itemIndex] = GroceryList[itemIndex - 1];
                    // update status label
                    StatusLabel.Text = "Incremented Restocked Qty for item with item code " + GroceryList[itemIndex - 1].ItemCode;
                    // clear textbox after the item is added to the list
                    QtyRestockedTextBox.Text = "";
                }
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            int itemIndex = GroceryListBox.SelectedIndex;
            if (itemIndex <= 0) // -1 = no item is selected or 0 = headerline is selected
            {
                StatusLabel.Text = "Please selected a grocery item to delete";
            }
            else if (GroceryList.Count > 0)
            {
                // update status label - need to do before deleting the data because the index will change
                StatusLabel.Text = "Deleted Item with item code " + GroceryList[itemIndex - 1].ItemCode;
                // delete selected item from list box
                GroceryListBox.Items.RemoveAt(itemIndex);
                // delete selected item from GroceryList
                GroceryList.RemoveAt(itemIndex - 1);
            }
        }

        private void SortItemButton_Click(object sender, EventArgs e)
        {
            // Sort Items Based On Sales from highest to lowest value
            List<Grocery> SortedGroceryList = GroceryList.OrderByDescending(item => item.TotalSales).ToList(); // return enumerable - need to convert to list
            // assign sorted list to the original list
            GroceryList = SortedGroceryList; 
            // sorted grocery list will be displayed in GroceryListBox
            LoadItemsToListBox();
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            // write output into file
            try
            {
                using (StreamWriter writer = new StreamWriter("updatedgrocery.csv"))
                {
                    // add headerline
                    writer.WriteLine("ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked");
                    // add each item
                    foreach (Grocery item in GroceryList)
                    {
                        // formatting data separate with ','
                        string eachItem = item.ItemCode + "," + item.ItemName + "," + item.UnitPrice.ToString("C2") + "," + item.QtyMinForRestock + "," + item.InitialQty + "," + item.QtySold + "," + item.QtyRestocked;
                        writer.WriteLine(eachItem);
                    }
                }
                // update status label
                StatusLabel.Text = "Saved " + GroceryList.Count + " records into the output inventory file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSalesReportButton_Click(object sender, EventArgs e)
        {
            // LINQ query, QtySold > 0
            List<Grocery> SortedGroceryList = (from item in GroceryList orderby item.QtySold where item.QtySold > 0 select item).ToList();
            // write output into file
            try
            {
                using (StreamWriter writer = new StreamWriter("grocerysales.csv"))
                {
                    // add headerline
                    writer.WriteLine("ItemCode,ItemName,UnitPrice,QtySold,Sales");
                    // add each item
                    foreach (Grocery item in SortedGroceryList)
                    {
                        // formatting data separate with ','
                        string eachItem = item.ItemCode + "," + item.ItemName + "," + item.UnitPrice.ToString("C2") + "," + item.QtySold + "," + item.TotalSales.ToString("C2");
                        writer.WriteLine(eachItem);
                    }
                }
                // update status label
                StatusLabel.Text = "Saved " + SortedGroceryList.Count + " records into the output sales file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRestockReportButton_Click(object sender, EventArgs e)
        {
            // LINQ query, QtySold > 0
            List<Grocery> SortedGroceryList = (from item in GroceryList orderby item.QtySold where item.AvailableQty < item.QtyMinForRestock select item).ToList();
            // write output into file
            try
            {
                using (StreamWriter writer = new StreamWriter("groceryrestocks.csv"))
                {
                    // add headerline
                    writer.WriteLine("ItemCode,ItemName,AvailableQty,QtyMinForRestock");
                    // add each item
                    foreach (Grocery item in SortedGroceryList)
                    {
                        // formatting data separate with ','
                        string eachItem = item.ItemCode + "," + item.ItemName + "," + item.AvailableQty + "," + item.QtyMinForRestock;
                        writer.WriteLine(eachItem);
                    }
                }
                // update status label
                StatusLabel.Text = "Saved " + SortedGroceryList.Count + " records into the restockes needed output file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
