using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EntityTipoContacto
    {
        private int _CodTipoContacto;
        private string _DescTipoContacto;
        private int _Estado;

        public int CodTipoContacto { get => _CodTipoContacto; set => _CodTipoContacto = value; }
        public string DescTipoContacto { get => _DescTipoContacto; set => _DescTipoContacto = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
