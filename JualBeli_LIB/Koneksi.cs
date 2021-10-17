using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace JualBeli_LIB
{
    public class Koneksi
    {
        #region Field
        private MySqlConnection koneksiDB;
        #endregion

        #region Constructor
        public Koneksi (string serverName, string databaseName, string username, string password)
        {
            string connectString = "server=" + serverName + ";database=" + databaseName + ";uid=" + username + ";password=" + password + ";SSL Mode=None";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connectString;
            Connect();
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Method
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        #endregion
    }
}
