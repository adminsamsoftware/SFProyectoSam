using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class EntityDireccionCatastro
    {
        private int _CodDireccion;
        private int _CodVia;
        private string _DescDireccion;
        private int _Estado;

        public int CodDireccion { get => _CodDireccion; set => _CodDireccion = value; }
        public int CodVia { get => _CodVia; set => _CodVia = value; }
        public string DescDireccion { get => _DescDireccion; set => _DescDireccion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }



    }
}
