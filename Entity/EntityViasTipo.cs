using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class EntityViasTipo
    {
        private int _CodTipoVia;
        private string _DescTipoVia;
        private string _AbrevTipoVia;
        private int _Estado;

        public int CodTipoVia { get => _CodTipoVia; set => _CodTipoVia = value; }
        public string DescTipoVia { get => _DescTipoVia; set => _DescTipoVia = value; }
        public string AbrevTipoVia { get => _AbrevTipoVia; set => _AbrevTipoVia = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
