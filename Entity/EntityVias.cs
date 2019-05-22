using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class EntityVias
    {
        private int _CodVia;
        private int _CodTipoVia;
        private int _CodUbigeo;
        private string _DescVia;
        private int _Estado;

        public int CodVia { get => _CodVia; set => _CodVia = value; }
        public int CodTipoVia { get => _CodTipoVia; set => _CodTipoVia = value; }
        public int CodUbigeo { get => _CodUbigeo; set => _CodUbigeo = value; }
        public string DescVia { get => _DescVia; set => _DescVia = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
