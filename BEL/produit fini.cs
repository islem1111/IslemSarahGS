using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BEL
{
    public class produit_fini
    {
        public string TAG { get; set; }
        public string libellé { get; set; }
        public string  image { get; set; }
        public int prix { get; set; }
        public int qte_dispo { get; set; }
        public int qte_entree { get; set; }
        public int qte_sortie { get; set; }
        public DateTime date_expiration { get; set; }
    }
}
