using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonderCMS
{
    public partial class ViewReservations : Form
    {
        int account_id; 
        public ViewReservations(int id)
        {
            InitializeComponent();
            account_id = id;
        }
    }
}
