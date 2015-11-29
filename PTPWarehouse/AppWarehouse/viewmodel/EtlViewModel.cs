using System;
using AppWarehouse.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.IntegrationServices;
using System.ComponentModel;
using System.Windows;

namespace AppWarehouse.viewmodel
{
    public class EtlViewModel:BaseBindable
    {
        private EtlModel etl;

        public EtlModel Etl
        {
            get
            {
                if (etl == null)
                {
                    etl = new EtlModel();
                }
                return etl;
            }
            set { etl = value; }
        }


        public EtlViewModel()
        {

        }

        private Package run_etl(Package x, string y, Microsoft.SqlServer.Dts.Runtime.Application z)
        {
            x = z.LoadPackage(@y, null);
            return x;
        }

        public string load_etl()
        {
            bool x = false;
            var bw =  new BackgroundWorker();
            Etl.Lokasi = Environment.CurrentDirectory.ToString() + "\\Resources\\Package.dtsx";
            bw.DoWork+=(sender,args)=>{
                try
                {
                    Etl.Pack = run_etl(Etl.Pack, Etl.Lokasi, Etl.App);
                    Etl.Pack.Execute();
                    Loading = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan pada sistem dalam membaca paket, eksekusi dibatalkan", "General Error", MessageBoxButton.OK);
                }
            };

            bw.RunWorkerCompleted+=(sender,args)=>
            {
                Loading = false;
            };
            bw.RunWorkerAsync();
            return etl.Pack.ExecutionResult.ToString();
        }


    }
}
