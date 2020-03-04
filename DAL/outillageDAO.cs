using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;
using System.Drawing;

namespace DAL
{
     public class outillageDAO
    {
        public static bool Insert_outillage(string TAG, string libellé, float prix_unitaire, string image, string fournisseur, DateTime Date_entrée)
        {
            string requete = String.Format("insert into outillage (TAG,libellé,prix_unitaire,image,fournisseur,Date_entrée )" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}');", TAG, libellé, prix_unitaire, image, fournisseur, Date_entrée);
            return utils.miseajour(requete);
        }


        public static bool Update_outillage(string TAG, string libellé, float prix_unitaire, string image, string fournisseur, DateTime Date_entrée)
        {
            string requete = String.Format("update outillage set libellé='{0}',prix_unitaire='{1}',image='{2}',fournisseur='{3}',Date_entrée='{4}'" +
                "  where TAG='{5}';", libellé, prix_unitaire, image, fournisseur, Date_entrée, TAG);
            return utils.miseajour(requete);
        }

        public static bool supprimer(string TAG)
        {
            string requete = String.Format("delete from outillage where TAG={0};", TAG);
            return utils.miseajour(requete);

        }
    }
}
