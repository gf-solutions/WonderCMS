using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderCMS
{
    public class reservation
    {
        public int id, slot;
        public KeyValuePair<int, string> patient, nurse;
        public DateTime visit_date, date;

        public reservation(int id, int patient_id, string patient_name, int nurse_id, string nurse_name, int slot,  DateTime visit_date, DateTime date)
        {
            this.id = id;
            patient = new KeyValuePair<int, string>(patient_id, patient_name);
            nurse = new KeyValuePair<int, string>(nurse_id, nurse_name);
            this.visit_date = visit_date;
            this.date = date;
            this.slot = slot;
        }

        public override string ToString()
        {
            return base.ToString() + ":" + patient.Value + ":" + visit_date.Date.ToString() + "=>" + Utilis.getSlots()[slot];
        }


    }
}
