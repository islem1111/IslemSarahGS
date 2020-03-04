using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class utilisateurDAO
    {

        public static bool verif (string login, string MDP) //pour l'authentification
        {
            string requete = String.Format("select MDP from utilisateur where id ={0};", login);
            OleDbDataReader rd = utils.lire(requete);
            string X;
            int result = 1;
            while (rd.Read())
            {
                //Console.WriteLine("verif");
                X = rd.GetString(0);
                result = string.Compare(X, MDP);
            }
            utils.Disconnect();
            if (result == 0)
                return true;
            else
                return false;

        }


        public static bool Ajout (int id, string nom, string prenom, string MDP, string email, string adresse, string poste, string service, int tel)
        {
            //Console.WriteLine("insert");
            string requete = String.Format("insert into utilisateur(id, nom, prenom, MDP, mail" +
                ", Adresse, poste, service, tel) values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}', {8});", id, nom, prenom, MDP, email, adresse, poste, service, tel);
            return utils.miseajour(requete);
        } //pour l'ajout


        public static utilisateur consulter (int id)
        {
            string requete = String.Format("select * from utilisateur where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            utilisateur u = new utilisateur();
            while (rd.Read())
            {
                u.id = rd.GetInt32(0);
                u.nom = rd.GetString(1);
                u.prenom = rd.GetString(2);
                u.MDP = rd.GetString(3);
                u.email = rd.GetString(4);
                u.adresse = rd.GetString(5);
                u.poste = rd.GetString(6);
                u.service = rd.GetString(7);
                u.tel = rd.GetInt32(8);
            }
            utils.Disconnect();
            return u;
        } //pour consulter son compte


        public static bool modifier(int id, string nom, string prenom, string MDP, string email, string adresse, string poste, string service, int tel)
        {
            string requete = String.Format("update utilisateur set  nom='{0}', prenom='{1}', MDP={2}, email='{2}', adresse ='{3}', poste ='{4}',"+
                "service ='{5}', tel = {6} where id={7};", nom, prenom, MDP, email, adresse, poste, service, tel, id);
            return utils.miseajour(requete);
        } //pour modifier une donnée
    }
}
