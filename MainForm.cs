using Microsoft.Win32;
using System.Web;

namespace putty_color_theme_gui
{
    public partial class MainForm : Form
    {
        private List<Theme> themeList;

        public MainForm()
        {
            InitializeComponent();

            themeList = Core.getInstance().ThemeList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var theme in themeList)
            {
                themeListElement.Items.Add(theme.Name);
            }

        }

        private void OnApplyButtonClick(object sender, EventArgs e)
        {
            Theme theme = themeList[themeListElement.SelectedIndex];
            PuttySessionListForm puttySessionsDialog = new PuttySessionListForm(theme);

            if (puttySessionsDialog.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Done", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // this.txtResult.Text = "Cancelled";
            }
            puttySessionsDialog.Dispose();
        }

        private void themeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = themeListElement.SelectedIndex;
            var url = themeList[index].Url;
            webView.Source = new Uri(url);
            btnApply.Enabled = true;
        }
    }
}