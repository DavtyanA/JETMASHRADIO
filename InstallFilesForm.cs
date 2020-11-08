using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JETMASHRADIO
{
    public partial class InstallFilesForm : Form
    {
        public InstallFilesForm()
        {
            InitializeComponent();
            Text = "JET MASH RADIOOOOOOOOOOOOOOOOOOOOOOO";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources.JetMashBackground;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.label1.BackColor = Color.Transparent;
            this.Icon = Properties.Resources.jetmashicon;//@"D:\Картиночки\jetmashradio.ico"
        }

        String gamePath = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                gamePath = fbd.SelectedPath;
                textBox1.Text = gamePath;
            }
        }

        private void InstallFilesForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(
                    "Ты кого наебать пытаешься? Выбери папку!",
                    "ОЗАЛУП!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    File.WriteAllBytes(gamePath + @"\CUSTOM\MUSIC.ARC", Properties.Resources.MUSIC_ARC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "ОЗАЛУП!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
                }

                DialogResult dialog = MessageBox.Show(
                   "Файлы установлены! Let's Get Funky!",
                   "ЗАЕБЦА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.None);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }
                //File.Move(Properties.Resources.MUSIC_ARC, gamePath);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
