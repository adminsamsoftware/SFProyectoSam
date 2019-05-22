using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class EntityTipoNumeracion
    {
        private int _CodTipoNumeracion;
        private string _DescTipoNumeracion;
        private string _AbrevNumeracion;
        private int _Estado;

        public int CodTipoNumeracion { get => _CodTipoNumeracion; set => _CodTipoNumeracion = value; }
        public string DescTipoNumeracion { get => _DescTipoNumeracion; set => _DescTipoNumeracion = value; }
        public string AbrevNumeracion { get => _AbrevNumeracion; set => _AbrevNumeracion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
