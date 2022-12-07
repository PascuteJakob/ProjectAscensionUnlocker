namespace ProjectAscensionUnlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void logBox_LogText(string newText)
        {
            logBox.Text = newText;
        }
        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}