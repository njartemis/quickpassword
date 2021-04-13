using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            CreateContextMenu();

        }



        private void CreateContextMenu()

        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "net user %username% " + textBox1;
            process.StartInfo = startInfo;
            process.Start();
            MessageBox.Show("Password has been changed!");
           
            richTextBox2.Text = richTextBox2.Text = "New Logs\n--------------------\nPassword has been changed to " + textBox1.Text;
        }

        private void hidePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void showPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '\0';
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Changer\nMade by Robertas46\nDiscord :\nRobertas#4190\nartemis#7157");
        }
    }
}
