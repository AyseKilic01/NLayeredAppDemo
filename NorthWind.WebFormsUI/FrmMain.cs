using NorthWind.Business.Concrete;
using NorthWind.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.WebFormsUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ProductManager _manager = new ProductManager(new EfProductDAL());
            dgwProduct.DataSource = _manager.GetAll();
        }
    }
}
