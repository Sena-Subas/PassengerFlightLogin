namespace PassengerFlightLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Route: " + comboBox1.Text + " " + comboBox2.Text + " Date: " + dateTimePicker1.Text + " Flight Time: " + maskedTextBox1.Text + " Passanger Informations - Full Name: " + textBox1.Text + " Identification Number: " + maskedTextBox2.Text + " Phone Number: " + maskedTextBox3.Text);
            MessageBox.Show(" Passanger registration has been made ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }
    }
}


