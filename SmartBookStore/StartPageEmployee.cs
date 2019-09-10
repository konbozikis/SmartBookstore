﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBookStore
{
    public partial class StartPageEmployee : Form
    {
        /*
        Bitmap lightsOff = new Bitmap("emplbookstore2.jpg");
        Bitmap lightsOn = new Bitmap("emplbookstore.jpg");
        Bitmap lightsCafe = new Bitmap("emplbookstore3.jpg");
        Bitmap lightsBooks = new Bitmap("emplbookstore4.jpg");
        Bitmap lightsPrint = new Bitmap("emplbookstore5.jpg"); */
        public Form form;
        public StartPageEmployee(Form form)
        {
            InitializeComponent();
            this.form = form;
            checkBox4.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashdesk cash = new Cashdesk(form);
            cash.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  /*
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsBooks;
            }
            else if (!checkBox1.Checked)
            {
                this.BackgroundImage = lightsOff;
            }   */
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {    /*
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsPrint;
            }
            else if (!checkBox2.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    */
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {    /*
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsCafe;
            }
            else if (!checkBox3.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    */
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {   /*
            if (checkBox4.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                this.BackgroundImage = lightsOn;
            }
            else if (!checkBox4.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    */
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Printingarea print = new Printingarea();
                print.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Den einai etoimi h scanning area");
            }
        }
    }
}
