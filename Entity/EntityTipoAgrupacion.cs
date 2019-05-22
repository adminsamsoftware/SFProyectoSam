using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class EntityTipoAgrupacion
    {
        private int _CodTipoAgrupacion;
        private string _DescTipoAgrupacion;
        private string _AbrevAgrupacion;
        private int _Estado;

        public int CodTipoAgrupacion { get => _CodTipoAgrupacion; set => _CodTipoAgrupacion = value; }
        public string DescTipoAgrupacion { get => _DescTipoAgrupacion; set => _DescTipoAgrupacion = value; }
        public string AbrevAgrupacion { get => _AbrevAgrupacion; set => _AbrevAgrupacion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }

    }
}
