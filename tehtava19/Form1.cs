using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava19
{
    public partial class Ruokalista : Form
    {
        public Ruokalista()
        {
            InitializeComponent();
            meista_label.Visible = true;
        }

        private void kori_panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Ruokalista_Load(object sender, EventArgs e)
        {
            meista_label.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meista_label.Text += "9:00 - 14:30 joka päivä maanantaista tortaisin ja perjantaisin \n";
            meista_label.Text += "9:00 -12:30. \n\n Keudan oppilaiskunnan kahvilasta saa lämpimien \n";
            meista_label.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia\n";
            meista_label.Text += "Tervetuloa tutustumaan";
            meista_label.Font = new Font("Arial", 12);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void meista_button1_Click(object sender, EventArgs e)
        {
            meesta_panel1.Visible = true;
            ruuat_panel1.Visible = false;
            juomat_panel1.Visible = false;
            herkut_panel1.Visible = false;
            kori_panel1.Visible = false;
        }

        private void herkut_panel1_Paint(object sender, PaintEventArgs e)
        {
            meesta_panel1.Visible = false;
            ruuat_panel1.Visible = false;
            juomat_panel1.Visible = false;
            herkut_panel1.Visible = true;
            kori_panel1.Visible = false;
        }


        private void ruuat_button1_Click(object sender, EventArgs e)
        {
            meesta_panel1.Visible = false;
            ruuat_panel1.Visible = true;
            juomat_panel1.Visible = false;
            herkut_panel1.Visible = false;
            kori_panel1.Visible = false;
        }

        private void juomat_button1_Click(object sender, EventArgs e)
        {
            meesta_panel1.Visible = false;
            ruuat_panel1.Visible = false;
            juomat_panel1.Visible = true;
            herkut_panel1.Visible = false;
            kori_panel1.Visible = false;
        }

        private void herkut_button1_Click(object sender, EventArgs e)
        {
            meesta_panel1.Visible = false;
            ruuat_panel1.Visible = false;
            juomat_panel1.Visible = false;
            herkut_panel1.Visible = true;
            kori_panel1.Visible = false;
        }

        private void korit_button1_Click(object sender, EventArgs e)
        {
            meesta_panel1.Visible = false;
            ruuat_panel1.Visible = false;
            juomat_panel1.Visible = false;
            herkut_panel1.Visible = false;
            kori_panel1.Visible = true;
        }

        private void poistu_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
