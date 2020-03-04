using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb ;
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
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\WIN10\Desktop\PFA");
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