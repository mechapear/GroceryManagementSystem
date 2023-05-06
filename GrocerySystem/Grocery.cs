using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GrocerySystem
{
    internal class Grocery
    {
        // auto-properties
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public int InitialQty { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }

        //computed read-only properties
        public int AvailableQty
        {
            get
            {
                return InitialQty - QtySold + QtyRestocked;
            }
        }
        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }
        // Constructor
        public Grocery(string itemCode, string itemName, double unitPrice, int qtyMinForRestock, int initialQty, int qtySold, int qtyRestocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
        }
        // Formatiing method
        public override string ToString()
        {
            string outputStr = string.Format("{0,-15}{1,-22}{2,-12:C2}{3,-18}{4,-14}{5,-14}{6,-14}{7,-14}{8,-10:C2}",
                                    ItemCode, ItemName, UnitPrice, QtyMinForRestock, InitialQty, QtySold, QtyRestocked, AvailableQty, TotalSales);
            return outputStr;
        }
    }
}
