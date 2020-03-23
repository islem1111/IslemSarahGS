using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace DAL
{
    public static class utils
    {
        public static OleDbConnection cn;
        public static OleDbCommand cmd;
        public static OleDbDataReader rd;

        public static void Connect()
        {    //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Connecter"];
            //string cnstr = settings.ConnectionString;
            string cnstr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\WIN10\\source\repos\\solution2\\solution2\\gestion de Stock.mdb";
            cn = new OleDbConnection(cnstr);
            cn.Open();
      
        }

        public static OleDbDataReader lire(string req)
        {
            Connect();
            cmd = new OleDbCommand(req, cn);
            rd = cmd.ExecuteReader();
            return rd;
        }

        public static bool miseajour(string req)
        {
            Connect();
            cmd = new OleDbCommand(req, cn);
            int nbaffected = cmd.ExecuteNonQuery();
            Disconnect();
            if (nbaffected != 0)
                return true;
            else
                return false;
        }

        public static void Disconnect()
        {
            cn.Close();
            cn.Dispose();
        }
    }
}