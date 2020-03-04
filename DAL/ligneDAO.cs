using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
    public class ligneDAO
    {
        public static bool Insert_ligne(string TAG, string libellé, int nb_machine, string gamme_opératoire)
        {
            string requete = String.Format("insert into ligne (TAG,libellé,nb_machine,gamme_opératoire)" +
                " values ('{0}','{1}','{2}','{3}');", TAG, libellé, nb_machine, gamme_opératoire);
            return utils.miseajour(requete);
        }

        public static bool Update_ligne(string TAG, string libellé, int nb_machine, string gamme_opératoire)
        {
            string requete = String.Format("update ligne set libellé='{0}',nb_machine='{1}',gamme_opératoire='{2}'" +
                "  where TAG={3};", libellé, nb_machine, gamme_opératoire, TAG);
            return utils.miseajour(requete);
        }
        public static bool supprimer(string TAG)
        {
            string requete = String.Format("delete from ligne where TAG={0};", TAG);
            return utils.miseajour(requete);

        }
    }
}
