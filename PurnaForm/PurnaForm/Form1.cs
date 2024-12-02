namespace PurnaForm
{
    public partial class Form1 : Form
    {
        private object labelMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            //string text = textBox1.Text;
            //MessageBox.Show("Welcome" + text);

            if (username == "Purna" && password == "123")
            {
                this.Hide();
                MessageBox.Show($"Welcome, {username}!");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
