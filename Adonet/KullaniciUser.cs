﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adonet
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciDal kullaniciDal = new KullaniciDal();

        private void KullaniciUser_Load(object sender, EventArgs e)
        {

            dgvKullaniciUser.DataSource = kullaniciDal.KayıtlarDatatableileGetir("select * from Kullanicilar");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
