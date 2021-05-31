using NorthWind.Business.Abstract;
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
        private IProductService _managerservice;
        public FrmMain()
        {
            InitializeComponent();
            _managerservice = new ProductManager(new EfProductDAL());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <= 500; i++)
            dgwProduct.DataSource = _managerservice.GetAll();
        }
    }
}
