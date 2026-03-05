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
            var a = int.Parse(this.SideA.Text);
            var b = int.Parse(this.SideB.Text);
            var c = int.Parse(this.SideC.Text);
            var d = int.Parse(this.SideD.Text);

            MessageBox.Show(Logic.CanFit(a, b, c, d).ToString());
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
