using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        RegistryKey key;

        public Form1()
        {
            InitializeComponent();
            InitializeRegistry();
        }

        private void InitializeRegistry()
        {
            key = Registry.CurrentUser;
            key = key.OpenSubKey(@"Software\MyTestProgram");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.welcomeMessage_label.Text = GetWelcomeMessageFromRegistry();
            this.BackColor = GetBackGroundColorFromRegistry();
        }

        private string GetWelcomeMessageFromRegistry()
        {
            return key.GetValue("welcomeMessage") as string;
        }

        private Color GetBackGroundColorFromRegistry()
        {
            var red = Convert.ToByte(key.GetValue("Red"));
            var green = Convert.ToByte(key.GetValue("Green"));
            var blue = Convert.ToByte(key.GetValue("Blue"));

            return Color.FromArgb(red, green, blue);
        }
    }
}
