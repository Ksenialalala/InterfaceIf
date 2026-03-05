namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static bool CanFit(double a, double b, double c, double d)
        {
            return (a <= c && b <= d) || (a <= d && b <= c);
        }
    }
}
