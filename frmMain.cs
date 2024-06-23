using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Wizard
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Change Desktop Wallpaper
        //-------------------------------------------------------
        private const int SPI_SETDESKWALLPAPER = 0x0014;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDCHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        //-------------------------------------------------------

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbOptions.Text)
            {
                case "Change Desktop Wallpaper":
                    string Wallpaper = GetImagePath();
                    if (Wallpaper != "")
                    {
                    SetWallpaper(Wallpaper);
                    MessageBox.Show("Desktop Wallpaper has been Changed");
                    } else
                        MessageBox.Show("Desktop Wallpaper has not been Changed");

                    break;
                default:
                    break;
            }
        }
        private string GetImagePath()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                return path;
            }
            return "";
        }
        public static void SetWallpaper(string imagePath)
        {
            if (imagePath == "")
            {
                return;
            }
            // Set the wallpaper using SystemParametersInfo
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbOptions.SelectedIndex = 0;
        }
    }
}
