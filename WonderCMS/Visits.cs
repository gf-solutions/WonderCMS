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
    public partial class Visits : Form
    {
        int account_id, patient_id, reservation_id;

        public Visits(int account_id, int patient_id, int reservation_id )
        {
            InitializeComponent();

            //initializing constructors 
            this.account_id = account_id;
            this.patient_id = patient_id;
            this.reservation_id = reservation_id;
        }
    }
}
