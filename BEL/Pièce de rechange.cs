using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BEL
{
    public class piece_de_rechange
    {
        public string TAG { get; set; }
        public string libellé { get; set; }
        public string  image { get; set; }
        public int prix { get; set; }
        public DateTime date_reception { get; set; }
        public string fournisseur { get; set; }
    }
}
