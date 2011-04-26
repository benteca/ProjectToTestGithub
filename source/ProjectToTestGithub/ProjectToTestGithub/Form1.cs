using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectToTestGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listControl = sender as ListBox;
            if (listControl.SelectedItem.Equals("Red")) colorPanel.BackColor = Color.Red;
            else if (listControl.SelectedItem.Equals("Blue")) colorPanel.BackColor = Color.Blue;
            else if (listControl.SelectedItem.Equals("Green")) colorPanel.BackColor = Color.Green;
            else if (listControl.SelectedItem.Equals("Yellow")) colorPanel.BackColor = Color.Yellow;
            else if (listControl.SelectedItem.Equals("Black")) colorPanel.BackColor = Color.Black;
            else if (listControl.SelectedItem.Equals("White")) colorPanel.BackColor = Color.White;
        }
    }
}
