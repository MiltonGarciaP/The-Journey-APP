namespace The_Journey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculoC frm = new CalculoC();
            frm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}