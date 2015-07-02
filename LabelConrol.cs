using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUMCreader
{
    public partial class labelControl : UserControl
    {
        public labelControl()
        {
            InitializeComponent();
             int a = 90;
        }
        public string Text
        {
            get
            {
                return label1.Text;  
            }
            set
            {
                label1.Text = value;
            }        
       


                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
