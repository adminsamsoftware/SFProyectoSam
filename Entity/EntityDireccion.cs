using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityDireccion
    {

        private int _CodDireccion;
        private int _CodVia;
        private string _DescDireccion;
        private string _DescAqrupacion;
        private string _DescUbigeo;
        private int _Estado;

        public int CodDireccion { get => _CodDireccion; set => _CodDireccion = value; }
        public int CodVia { get => _CodVia; set => _CodVia = value; }
        public string DescDireccion { get => _DescDireccion; set => _DescDireccion = value; }
        public string DescAqrupacion { get => _DescAqrupacion; set => _DescAqrupacion = value; }
        public string DescUbigeo { get => _DescUbigeo; set => _DescUbigeo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
