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
            int a, b, c, d;
            try
            {
                a = int.Parse(this.SideA.Text);
                b = int.Parse(this.SideB.Text);
                c = int.Parse(this.SideC.Text);
                d = int.Parse(this.SideD.Text);
            }
            catch (FormatException)
            {
                return;
            }

            bool result = Logic.CanFit(a, b, c, d);
            MessageBox.Show(result.ToString());
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
