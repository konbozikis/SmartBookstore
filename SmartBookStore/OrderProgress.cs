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
    public partial class OrderProgress : Form
    {
        public Form form;
        int i = 0;
        int j = 0;
        List<PictureBox> pictures = new List<PictureBox>();
        List<Label> labels = new List<Label>();
        public OrderProgress(Form form)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "Data/OrderProgress/processing.jpg";
            pictureBox3.ImageLocation = "Data/OrderProgress/packing.jpg";
            pictureBox5.ImageLocation = "Data/OrderProgress/complete.png";
            var pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5};
            var labels = new List<Label> {label2, label3, label4};
            this.pictures = pictures;
            this.labels = labels;
            this.form = form;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictures[i].Visible = true;
            labels[j].Visible = true;
            if (i > 0)
            {
                pictures[i - 1].Visible = true;              
            }
            i += 2;
            j++;
            if (i > 4)
            {
                timer1.Stop();
                MessageBox.Show("Η παραγγελία σας είναι έτοιμη για παραλαβή από το ταμείο!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
