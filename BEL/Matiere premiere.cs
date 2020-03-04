using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BEL
{
    public class Matiere_premiere
    {
        public int TAG { get; set; }
        public string libellé { get; set; }
        public string  image { get; set; }
        public int prix { get; set; }
        public string fournisseur { get; set; }
        public DateTime date_entree { get; set; }
        public DateTime date_expiration { get; set; }

    }
}
