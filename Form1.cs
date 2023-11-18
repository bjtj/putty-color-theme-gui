using Microsoft.Win32;
using System.Web;

namespace putty_color_theme_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var names = ListPuttySessions();
            foreach (var name in names)
            {
                sessionList.Items.Add(HttpUtility.UrlDecode(name));
            }
        }

        static List<String> ListPuttySessions()
        {
            // https://stackoverflow.com/a/44952225/5676460

            var names = new List<String>();

            var key = Registry.CurrentUser.OpenSubKey("Software\\SimonTatham\\PuTTY\\Sessions");
            if (key is not null)
            {
                foreach (var name in key.GetSubKeyNames())
                {
                    System.Console.WriteLine(name);
                    names.Add(name);
                }
            }
            return names;
        }

        private void btnSelectTheme_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                // this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else
            {
                // this.txtResult.Text = "Cancelled";
            }
            testDialog.Dispose();
        }
    }
}