using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLiPhongMach
{
    public partial class BaoCaoHDTong : Form
    {
        public BaoCaoHDTong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BaoCaoTongQuan rpt = new BaoCaoTongQuan();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
