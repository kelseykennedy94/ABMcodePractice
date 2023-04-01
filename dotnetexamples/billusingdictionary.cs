using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace billform_with_dictionary
{
    public partial class Form1 : Form
    {
        private string orderSummaryText = "";
        private bool updateCost = false;
        private Dictionary<string, double> items = new Dictionary<string, double>()
        {
            {"Burger", 5.99},
            {"Fries", 2.5},
            {"Milkshake", 4.75},
            {"Pop", 1.5}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Items";
            label6.Text = "Order Summary";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            button1.Text = "Order";
            button2.Text = "Clear";

            foreach (string item in items.Keys)
            {
                var itemPanel = new Panel();
                itemPanel.Size = new System.Drawing.Size(300, 80);
                itemPanel.AutoSize = true;

                var checkBox = new CheckBox();
                checkBox.Text = item;
                checkBox.Location = new System.Drawing.Point(0, 10);
                checkBox.Size = new System.Drawing.Size(100, 30);
                itemPanel.Controls.Add(checkBox);

                var priceLabel = new Label();
                priceLabel.Text = items[item].ToString("C");
                priceLabel.Location = new System.Drawing.Point(60, 10);
                priceLabel.AutoSize = true;
                itemPanel.Controls.Add(priceLabel);

                EventHandler updateOrderSummary = UpdateOrderSummary;
                checkBox.CheckedChanged += new EventHandler(updateOrderSummary);

                flowLayoutPanel1.Controls.Add(itemPanel);
            }
        }

        private void UpdateOrderSummary(object sender, EventArgs e)
        {
            orderSummaryText = "";
            double totalCost = 0;

            foreach (Panel itemPanel in flowLayoutPanel1.Controls)
            {
                CheckBox checkBox = (CheckBox)itemPanel.Controls[0];
                Label priceLabel = (Label)itemPanel.Controls[1];

                if (checkBox.Checked)
                {
                    string itemName = checkBox.Text;
                    orderSummaryText += itemName + " - " + priceLabel.Text + "\n";
                    totalCost += items[itemName];
                }
            }

            label6.Text = "Order Summary\n" + orderSummaryText;

            if (updateCost)
            {
                label7.Text = "GST: " + (totalCost * 0.05).ToString("C");
                label8.Text = "Tip: " + (totalCost * 0.1).ToString("C");
                label9.Text = "Total: " + (totalCost * 1.15).ToString("C");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItems = "";

            foreach (Panel itemPanel in flowLayoutPanel1.Controls)
            {
                CheckBox checkBox = (CheckBox)itemPanel.Controls[0];

                if (checkBox.Checked)
                {
                    string itemName = checkBox.Text;
                    selectedItems += itemName + ", ";
                }
            }

            if (selectedItems.Length > 2)
            {
                selectedItems = selectedItems.Substring(0, selectedItems.Length - 2);
            }

            orderSummaryText += "Selected items: " + selectedItems + "\n";

            updateCost = true;
            UpdateOrderSummary(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Panel itemPanel in flowLayoutPanel1.Controls)
            {
                CheckBox checkBox = (CheckBox)itemPanel.Controls[0];
                checkBox.Checked = false;
            }
        }
    }
}