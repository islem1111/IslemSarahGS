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
    public class Matiere_premiereDAO
    {
        public static bool Insert_MatièrePremière(string TAG, string libellé, float prix, string  image, string fournisseur,DateTime date_entrée,DateTime date_expiration)
        {
            string requete = String.Format("insert into Matière_Première (TAG,libellé,prix,image,fournisseur )" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", TAG, libellé, prix, image, fournisseur, date_entrée, date_expiration);
        
            return utils.miseajour(requete);
        }

        public static bool Update_Matière_Première(string TAG, string libellé, float prix, string image, string fournisseur, DateTime date_entrée, DateTime date_expiration)
        
        {
            string requete = String.Format("update Matière_Première set libellé='{0}',prix='{1}',image='{2}',fournisseur='{3}',date_entrée='{4}',date_expiration='{5}'" +
                "  where TAG={6};", libellé, prix, image, fournisseur,date_entrée,date_expiration, TAG);
            return utils.miseajour(requete);
        }

        public static bool supprimer(string TAG)
        {
            string requete = String.Format("delete from Matière_premiere where TAG={0};", TAG);
            return utils.miseajour(requete);

        }
    }
}
