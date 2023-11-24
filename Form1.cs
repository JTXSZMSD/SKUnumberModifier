namespace SKUnumberModifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tempText = "";

            foreach (char c in textBox1.Text)
            {
                if (c == ' ')
                {
                    tempText += " | ";
                }
                else if (c == ',')
                {
                    tempText += " | ";
                }
                else
                {
                    tempText += c;
                }
            }

            textBox2.Text = tempText;
        }
    }
}