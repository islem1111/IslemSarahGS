using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;
using BEL;
namespace DAL
{
    public class MachineDAO
    {
        public static bool Insert_Machine(string TAG, string libellé, float prix,string  image, string constructeur)
        {
            string requete = String.Format("insert into Machine (TAG,libellé,prix,image,constructeur )" +
                " values ('{0}','{1}','{2}','{3}','{4}');", TAG, libellé, prix, image, constructeur);
            return utils.miseajour(requete);
        }


        public static bool Update_Machine(string TAG, string libellé, float prix, string image, string constructeur)
        {
            string requete = String.Format("update Machine set libellé='{0}',prix='{1}',image='{2}',constructeur={3}" +
                "  where TAG={4};", libellé, prix, image, constructeur, TAG);
            return utils.miseajour(requete);
        }


        public static bool supprimer(string TAG)
        {
            string requete = String.Format("delete from Machine where TAG={0};", TAG);
            return utils.miseajour(requete);

        }
    }
}
