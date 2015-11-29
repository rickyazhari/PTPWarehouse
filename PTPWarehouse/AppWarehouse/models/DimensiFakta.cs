using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppWarehouse.models
{
    public class DimensiFakta:Base
    {
        private DataTable dt;

        public DataTable Dt
        {
            get {
                if (dt == null)
                {
                    dt = new DataTable();
                }    
                return dt; 
            }
            set { dt = value; }
        }
    }
}
