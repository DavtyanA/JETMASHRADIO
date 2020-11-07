using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace JETMASHRADIO
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.JetMashBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.jetmashicon;//@"D:\Картиночки\jetmashradio.ico"
        }

        private void characterModderButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void preferencesButton_Click(object sender, EventArgs e)
        {
            //(new PreferencesForm()).Show();
        }

        private void MashupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GetSystemDefaultBrowser(), "https://vk.com/mashup");
        }

        private void ShonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GetSystemDefaultBrowser(), "https://vk.com/shonyourbro");
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        internal string GetSystemDefaultBrowser()
        {
            string name = string.Empty;
            RegistryKey regKey = null;

            try
            {
                var regDefault = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.htm\\UserChoice", false);
                var stringDefault = regDefault.GetValue("ProgId");

                regKey = Registry.ClassesRoot.OpenSubKey(stringDefault + "\\shell\\open\\command", false);
                name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

                if (!name.EndsWith("exe"))
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            }
            catch (Exception ex)
            {
                name = string.Format("ERROR: An exception of type: {0} occurred in method: {1} in the following module: {2}", ex.GetType(), ex.TargetSite, this.GetType());
            }
            finally
            {
                if (regKey != null)
                    regKey.Close();
            }

            return name;
        }
    }
}
