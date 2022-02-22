namespace PassingData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string text = textBox2.Text;

            Form2 form = new Form2(title, text);
            form.ShowDialog();
        }
    }
}