using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWinApp
{
    public partial class CoffeeShop : Form
    {
        const int size = 10;
        int index = 0;

        List <string> customerName = new List<string>() ;
        List<string> customerAddress = new List<string>();
        List<string> orderBox = new List<string>();
        List<int> contactName = new List<int>();
        List<int> totalPrice = new List<int>();
        List<int> numberOfQuantity = new List<int>();

        int blackUnitPrice = 120;
        int coldUnitPrice = 100;
        int hotUnitPrice = 90;
        int regularUnitPrice = 80;


        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName.Add(nameTextBox.Text);
            customerAddress.Add(addressTextBox.Text);
            orderBox.Add(orderComboBox.Text);
            contactName.Add(Convert.ToInt32(ContactTextBox.Text));
            numberOfQuantity.Add(Convert.ToInt32(quantityTextBox.Text));
            totalPrice.Add(index);

            string message = "";

            if (orderComboBox.Text == "Black")
            {
                totalPrice[index] = blackUnitPrice * Convert.ToInt32(quantityTextBox.Text);

            }
            else if (orderComboBox.Text == "Cold")
            {
                totalPrice[index] = coldUnitPrice * Convert.ToInt32(quantityTextBox.Text);

            }
            else if (orderComboBox.Text == "Hot")
            {
                totalPrice[index] = hotUnitPrice * Convert.ToInt32(quantityTextBox.Text);

            }
            else
            {

                totalPrice[index] = regularUnitPrice * Convert.ToInt32(quantityTextBox.Text);

            }

            index++;

            for (int index = 0; index < customerName.Count; index++)
            {
                if (numberOfQuantity[index] != 0)
                {
                    message = message + "\n Customer Information \n" + "*********************" + "\n\n" + "Customer Name: " + customerName[index] + "\n\n"
                 + "Contact No:" + contactName[index] + "\n\n" + "Customer Address: " + customerAddress[index] + "\n\n"
                 + "Order: " + orderBox[index] + "\n\n" + "Quantity: " + numberOfQuantity[index] + "\n\n"+ "Total Price: " + totalPrice[index] +"\n\n" + "****************************************" + "\n\n";
                 ;
                }

            }
            resultRichTextBox.Text = message;

            nameTextBox.Clear();
            addressTextBox.Clear();
            ContactTextBox.Clear();
            orderComboBox.SelectedItem = null;
            quantityTextBox.Clear();

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
