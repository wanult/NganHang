using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class FormGiaoDich : Form
    {
        public FormGiaoDich()
        {
            InitializeComponent();
        }

        private void FormGiaoDich_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = true;
            picrut.Visible = false;
            picnhan.Visible = true;
            ktrut.Visible = false;
            ktnhan.Visible = true;
            lbgui.Visible = false;
            tbrut.Visible = false;
            lbnhan.Visible = true;
            tbnhan.Visible = true;
        }

        private void ruttien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = true;
            picrut.Visible = true;
            picnhan.Visible = false;
            ktrut.Visible = true;
            ktnhan.Visible = false;
            lbgui.Visible = true;
            tbrut.Visible = true;
            lbnhan.Visible = false;
            tbnhan.Visible = false;
        }

        private void chuyentien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = true;
            picrut.Visible = true;
            picnhan.Visible = true;
            ktrut.Visible = true;
            ktnhan.Visible = true;
            lbgui.Visible = true;
            tbrut.Visible = true;
            lbnhan.Visible = true;
            tbnhan.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
