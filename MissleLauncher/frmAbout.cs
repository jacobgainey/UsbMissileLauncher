using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MissleLauncher
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            string major = Assembly.GetEntryAssembly().GetName().Version.Major.ToString();
            string minor = Assembly.GetEntryAssembly().GetName().Version.Minor.ToString();
            string build = Assembly.GetEntryAssembly().GetName().Version.Build.ToString();
            string patch = Assembly.GetEntryAssembly().GetName().Version.Revision.ToString();

            lblVersion.Text = $@"Version {major}.{minor}.{build}.{patch}";


        }
    }
}
