namespace DemoMulti
{
    public partial class Form1 : Form
    {
        string formTitle;

        public Form1(string formTitle)
        {
            InitializeComponent();
            this.formTitle = formTitle;
            label1.Text = formTitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
