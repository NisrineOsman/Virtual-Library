using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DataPers
{
    public class DataAccess
    {
        private static DataAccess _Instance = null;
        public static DataAccess Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataAccess();
                }
                return _Instance;
            }
        }

        private string _ConnectionString = null;
        public string ConnectionString
        {
            get
            {
                if (_ConnectionString == null)
                    _ConnectionString = "Data Source=NISRINE;Initial Catalog=LibrarySystem;Integrated Security=True";
                return _ConnectionString;
            }
        }


        //private  LibraryDataset _LibraryDataset=null; 
        //public   LibraryDataset  LibraryDtset
        //{ 
        //    get
        //    {
        //        if (_LibraryDataset == null)
        //        {
        //            _LibraryDataset = new LibraryDataset();
        //            _LibraryDataset.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
        //        }
        //        return _LibraryDataset;
        //    }
            
        //}
        

       /// <summary>
       /// maintenant il suffit de creer library dataset connection, ce n'est pas necessaire
       /// de faire la m chose pr table adapters
       /// </summary>
       

        //private LibraryDatasetTableAdapters.AccountTableAdapter _AccountTA = null;
        //public LibraryDatasetTableAdapters.AccountTableAdapter AccountTA
        //{
        //    get
        //    {
        //        if (_AccountTA == null)
        //        {
        //            _AccountTA = new LibraryDatasetTableAdapters.AccountTableAdapter();
        //            _AccountTA.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
        //        }
        //        return _AccountTA;
        //    }
        //}
        
        private LibrarySystem.Controler.LibraryDatasetTableAdapters.AccountAdminTableAdapter _AccountAdminTA = null;
        public LibrarySystem.Controler.LibraryDatasetTableAdapters.AccountAdminTableAdapter AccountAdminTA
        {
            get
            {
                if (_AccountAdminTA == null)
                {
                    _AccountAdminTA = new LibrarySystem.Controler.LibraryDatasetTableAdapters.AccountAdminTableAdapter();
                    _AccountAdminTA.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
                }
                return _AccountAdminTA;
            }
        }
    }
}
