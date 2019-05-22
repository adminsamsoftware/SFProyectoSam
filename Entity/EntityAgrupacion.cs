using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityAgrupacion
    {
        private  int _CodAgrupacion;
        private int _CodTipoAgrupacion;
        private string _DescAgrupacion;
        private int _Estado;

        public int CodAgrupacion { get => _CodAgrupacion; set => _CodAgrupacion = value; }
        public int CodTipoAgrupacion { get => _CodTipoAgrupacion; set => _CodTipoAgrupacion = value; }
        public string DescAgrupacion { get => _DescAgrupacion; set => _DescAgrupacion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
