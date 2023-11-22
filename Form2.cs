using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace putty_color_theme_gui
{
    public partial class PuttySessionListForm : Form
    {

        private List<Session> sessions = new List<Session>();
        private Theme theme;

        public PuttySessionListForm(Theme theme)
        {
            InitializeComponent();
            this.theme = theme;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.sessions = ListPuttySessions();

            foreach (var session in this.sessions)
            {
                sessionList.Items.Add(session.Name);
            }
        }

        static List<Session> ListPuttySessions()
        {
            // https://stackoverflow.com/a/44952225/5676460

            var names = new List<Session>();

            var key = Registry.CurrentUser.OpenSubKey("Software\\SimonTatham\\PuTTY\\Sessions");
            if (key is not null)
            {
                foreach (var name in key.GetSubKeyNames())
                {
                    System.Console.WriteLine(name);
                    names.Add(new Session(WebUtility.UrlDecode(name), name));
                }
            }
            return names;
        }

        private void sessionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indices = sessionList.SelectedIndices;
            btnApply.Enabled = indices.Count > 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var indices = sessionList.SelectedIndices.Cast<int>();

            foreach (var index in indices)
            {
                var session = sessions[index];
                foreach (var prop in this.theme.Properties)
                {
                    String prefix = $"HKEY_CURRENT_USER\\Software\\SimonTatham\\PuTTY\\Sessions\\{session.Key}";
                    Registry.SetValue(prefix, prop.Key, prop.Value);
                }
            }

            Close();
            DialogResult = DialogResult.OK;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sessionList.Items.Count; i++)
            {
                sessionList.SelectedIndices.Add(i);
            }
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            sessionList.SelectedIndices.Clear();
        }
    }
}
