namespace bill
{
    public partial class Form1 : Form
    {
        private string orderSummaryText = "";
        private bool updateCost = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Items";
            label2.Text = "Burger:";
            label3.Text = "Fries:";
            label4.Text = "Milkshake:";
            label5.Text = "Pop:";
            label6.Text = "Order Summary";
            label7.Text = "GST:";
            label8.Text = "Tip:";
            label9.Text = "Total:";
            label10.Text = "Sub Total:";
            checkBox1.Text = "$5.99";
            checkBox2.Text = "$2.50";
            checkBox3.Text = "$4.75";
            checkBox4.Text = "$1.50";
            button1.Text = "Order";
            button2.Text = "Clear";
        }

        private void UpdateOrderSummary()
        {
            orderSummaryText = "";
            double totalCost = 0;

            if (checkBox1.Checked)
            {
                orderSummaryText += "Burger: " + checkBox1.Text + "\n";
                totalCost += 5.99;
            }

            if (checkBox2.Checked)
            {
                orderSummaryText += "Fries: " + checkBox2.Text + "\n";
                totalCost += 2.5;
            }

            if (checkBox3.Checked)
            {
                orderSummaryText += "Milkshake: " + checkBox3.Text + "\n";
                totalCost += 4.75;
            }

            if (checkBox4.Checked)
            {
                orderSummaryText += "Pop: " + checkBox4.Text + "\n";
                totalCost += 1.5;
            }

            label6.Text = "Order Summary\n" + orderSummaryText;

            if (updateCost)
            {
                double subtotal = totalCost;
                double gst = totalCost * 0.05;
                double tip = totalCost * 0.1;
                double grandTotal = totalCost * 1.15;

                label7.Text = "GST: " + gst.ToString("C");
                label8.Text = "Tip: " + tip.ToString("C");
                label9.Text = "Total: " + grandTotal.ToString("C");
                label10.Text = "Subtotal: " + subtotal.ToString("C");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItems = "";

            if (checkBox1.Checked)
            {
                selectedItems += "Burger, ";
            }

            if (checkBox2.Checked)
            {
                selectedItems += "Fries, ";
            }

            if (checkBox3.Checked)
            {
                selectedItems += "Milkshake, ";
            }

            if (checkBox4.Checked)
            {
                selectedItems += "Pop, ";
            }

            if (selectedItems.Length > 2)
            {
                selectedItems = selectedItems.Substring(0, selectedItems.Length - 2);
            }

            orderSummaryText += "Selected items: " + selectedItems + "\n";

            updateCost = true;
            UpdateOrderSummary();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            label6.Text = "Order Summary";
            label7.Text = "GST:";
            label8.Text = "Tip:";
            label9.Text = "Total:";
            label10.Text = "Subtotal:";

            orderSummaryText = "";
            updateCost = false;
        }
    }
}