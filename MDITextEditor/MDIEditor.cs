//Program By : Dylan Cavanaugh


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITextEditor
{
    public partial class MDIEditor : Form
    {
        //This variable will be used to number the files
        int counter = 0;

        public MDIEditor()
        {
            InitializeComponent();
        }

        //This is the "new" click event handler
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates new child form
            var child = new ChildForm();
            child.MdiParent = this;

            //Utilizes the counter to number all text files
            if (counter == 0)
            {
                child.Text = "Text File ";
            }
            else
            {
                child.Text = "Text File " + counter;
            }
            counter++;
            child.Show();

        }

        //Closes the current active child
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                ActiveMdiChild.Close();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //Changes the font size to 8
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 8);
            size12.Checked = false;
            size15.Checked = false;
            size18.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font size to 12
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 12);
            size8.Checked = false;
            size15.Checked = false;
            size18.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font size to 15
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 15);
            size8.Checked = false;
            size12.Checked = false;
            size18.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font size to 18
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try {
            ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 18);
            size8.Checked = false;
            size12.Checked = false;
            size15.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font to Times New Roman
        //Changing the font also changed the size of the text
        //so an if statement was used to ensure the size was unchanged
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Font = new Font("Times New Roman", 8, ActiveMdiChild.Font.Style);

            if (size8.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 8);
            }
            else if (size12.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 12);
            }
            else if (size15.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 15);
            }
            else if (size18.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 18);
            }
            timesNewRomanToolStripMenuItem.Checked = true;
            arialToolStripMenuItem.Checked = false;
            couriorNewToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font to Arial
        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Font = new Font("Arial", 8, ActiveMdiChild.Font.Style);

            if (size8.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 8);
            }
            else if (size12.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 12);
            }
            else if (size15.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 15);
            }
            else if (size18.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 18);
            }
            timesNewRomanToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = true;
            couriorNewToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes the font to Courior New
        private void couriorNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Font = new Font("Courior New", 8, ActiveMdiChild.Font.Style);

            if (size8.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 8);
            }
            else if (size12.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 12);
            }
            else if (size15.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 15);
            }
            else if (size18.Checked)
            {
                ActiveMdiChild.Controls[0].Font = new Font(ActiveMdiChild.Font.Name, 18);
            }
            timesNewRomanToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            couriorNewToolStripMenuItem.Checked = true;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }

        }

        //Changes font color to black
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].ForeColor = Color.Black;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes font color to blue
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].ForeColor = Color.Blue;
            blackToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes font color to green
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].ForeColor = Color.Green;
            blueToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Changes font color to red
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            ActiveMdiChild.Controls[0].ForeColor = Color.Red;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("There are no files open!");
            }
        }

        //Cascades all the windows
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //Arranges the windows vertically
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //Arranges the windows horizontally
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

    }
}
