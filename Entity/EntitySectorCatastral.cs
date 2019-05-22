using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class EntitySectorCatastral
    {
        private int _CodSector;
        private int _CodUbigeo;
        private string _NumSector;
        private string _DescSector;
        private int _Estado;

        public int CodSector { get => _CodSector; set => _CodSector = value; }
        public int CodUbigeo { get => _CodUbigeo; set => _CodUbigeo = value; }
        public string NumSector { get => _NumSector; set => _NumSector = value; }
        public string DescSector { get => _DescSector; set => _DescSector = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
