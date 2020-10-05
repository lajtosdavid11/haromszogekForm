﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszogek
{
    public partial class frmFo : Form
    {
        private int Aoldal;
        private int Boldal;
        private int Coldal;
        public frmFo()
        {
            Aoldal = 0;
            Boldal = 0;
            Coldal = 0;
            InitializeComponent();
            tbAoldal.Text = Aoldal.ToString();
            tbBoldal.Text = Boldal.ToString();
            tbColdal.Text = Coldal.ToString();
            lbHaromszogLista.Items.Clear();


        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            Aoldal = int.Parse(tbAoldal.Text);
            Boldal = int.Parse(tbBoldal.Text);
            Coldal = int.Parse(tbColdal.Text);
            if (Aoldal == 0 || Boldal == 0 || Coldal == 0)
            {
                MessageBox.Show("Ez nem lehet nulla", "Ez jó",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var h = new Haromszog(Aoldal, Boldal, Coldal);
               
                List<string> adatok = h.AdatokSzoveg();
                foreach (var a in adatok)
                {
                    lbHaromszogLista.Items.Add(a);
                }
            }
        }

        private void lbHaromszogLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromszogLista.Items.Count > 0)
            {
                lbHaromszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs adat");
            }
            

        }
    }
}
