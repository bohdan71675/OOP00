﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student student0 = new Student();
            Student student = new Student("Petr");

            student.OznamkujMAT(3);
            student.OznamkujCJL(2);
            student.OznamkujPRG(6);

            double p = student.Prumer();
            if (p != -1)
            {
                MessageBox.Show(student.GetJmeno() + " ma prumer znamek: " + p);
            }
            else { MessageBox.Show(student.GetJmeno() + " neni klasifikovan"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student2 = new Student("Jan", 3, 1, 2);

            double p = student2.Prumer();
            if (p != -1)
            {
                MessageBox.Show(student2.GetJmeno() + " ma prumer znamek: " + p);
            }
            else { MessageBox.Show(student2.GetJmeno() + " neni klasifikovan"); }

        }
    }
}
