using System;
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
            //Student student = new Student();
            Student student = new Student("Petr");

            student.OznamkujMAT(3);
            student.OznamkujCJL(2);
            student.OznamkujPRG(5);

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

        private void button3_Click(object sender, EventArgs e)
        {
            Student student1 = new Student("Pavel", 4, 4, 3, "Trebic");

            MessageBox.Show(student1.GetJmeno() + " " + student1.GetBydliste());

            student1.SetBydliste("Brno");

            MessageBox.Show("Student se prestehoval");

            MessageBox.Show(student1.GetJmeno() + " " + student1.GetBydliste());

            Student student2 = new Student("Petr", "Jihlava");

            MessageBox.Show(student2.GetJmeno() + " " + student2.GetBydliste());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student student1 = new Student("Vladislav", 1, 1, 1, "Praha");
            MessageBox.Show(student1.ToString());
            //MessageBox.Show(textBox1.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Osoba osoba1 = new Osoba("Martin ");
            osoba1.SetPrijmeni("Dostal");
            MessageBox.Show(osoba1.ToString());

            Osoba osoba2 = new Osoba("Martinek ", "Dostalek");
            MessageBox.Show(osoba2.GetJmeno() + osoba2.GetPrijmeni());
            MessageBox.Show(osoba2.CeleJmenoVelkymi());
            MessageBox.Show(osoba2.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Osoba osoba3 = new Osoba("Martin ", "Dostal", 178, 65);
            MessageBox.Show(osoba3.ToString());
            osoba3.SetHmotost(4000);
            osoba3.SetVyska(1);
            MessageBox.Show(osoba3.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OsobaVlastnosti osobavl = new OsobaVlastnosti("Alena", "Vavrova", 180, 70);
            MessageBox.Show(osobavl.ToString());
        }
    }
}
