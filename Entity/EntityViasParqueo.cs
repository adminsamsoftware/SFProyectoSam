using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class EntityViasParqueo
    {

        private int _CodViasParqueo;
        private int _CodVia;
        private int _CuadraInicial;
        private int _CuadraFinal;
        private int _UbiPaqueo;
        private int _Estado;

        public int CodViasParqueo { get => _CodViasParqueo; set => _CodViasParqueo = value; }
        public int CodVia { get => _CodVia; set => _CodVia = value; }
        public int CuadraInicial { get => _CuadraInicial; set => _CuadraInicial = value; }
        public int CuadraFinal { get => _CuadraFinal; set => _CuadraFinal = value; }
        public int UbiPaqueo { get => _UbiPaqueo; set => _UbiPaqueo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
