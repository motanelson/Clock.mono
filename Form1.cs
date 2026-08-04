using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClockGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = (menuToolStripMenuItem.Text);
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }

        }
    
        private void pbrushexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = (pbrushexeToolStripMenuItem.Text);
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }

        }

        private void calcexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = (calcexeToolStripMenuItem.Text);
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }
        }

        private void explorerexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = (explorerexeToolStripMenuItem.Text+" .");
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }

        }

        private void edgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            String args = ("msedge.exe");
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = ("outlook.exe");
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }

        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String args = ("cmd.exe");
            try
            {

                Process.Start(args);

            }
            catch (Exception)
            {
                args = "";
            }

        }
    }
    
}
