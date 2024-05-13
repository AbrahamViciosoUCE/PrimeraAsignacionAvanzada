namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = $"Count: {count}";
        }
    }
}
