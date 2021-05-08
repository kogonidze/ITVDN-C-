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

namespace AdminApp
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
            key = key.OpenSubKey("Software", true);
            key = key.CreateSubKey("MyTestProgram");
        }

        private void setWelcomeMsg_button_Click(object sender, EventArgs e)
        {
            var message = this.welcomeMsg_textBox.Text;

            if (message == String.Empty)
            {
                key.SetValue("WelcomeMessage", "Hello!");
            }
            else
            {
                key.SetValue("WelcomeMessage", message);
            }

            MessageBox.Show("Value was changed!");
        }

        private void setBackgroundColor_button_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = this.colorDialog1.Color;

                var red = color.R;
                var green = color.G;
                var blue = color.B;

                key.SetValue("Red", red);
                key.SetValue("Green", green);
                key.SetValue("Blue", blue);

                this.label3.BackColor = color;

                MessageBox.Show("Value was changed!");
            }

        }
    }
}
