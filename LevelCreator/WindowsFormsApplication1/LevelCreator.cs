using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LevelCreator : Form
    {
        public LevelCreator()
        {
            InitializeComponent();
        }

        private void LevelCreator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            
            Application.Exit();
        }

        private void LevelCreator_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you really wanna exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        } 

        private void exiting_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
