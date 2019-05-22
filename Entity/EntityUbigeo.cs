using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class EntityUbigeo
    {
        private int _CodUbigeo;
        private int _CodDepartamento;
        private int _CodProvincia;
        private int _CodDistrito;
        private string _DescDepartamento;
        private string _DescProvincia;
        private string _DescDistrito;
        private int _Estado;

        public int CodUbigeo { get => _CodUbigeo; set => _CodUbigeo = value; }
        public int CodDepartamento { get => _CodDepartamento; set => _CodDepartamento = value; }
        public int CodProvincia { get => _CodProvincia; set => _CodProvincia = value; }
        public int CodDistrito { get => _CodDistrito; set => _CodDistrito = value; }
        public string DescDepartamento { get => _DescDepartamento; set => _DescDepartamento = value; }
        public string DescProvincia { get => _DescProvincia; set => _DescProvincia = value; }
        public string DescDistrito { get => _DescDistrito; set => _DescDistrito = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
