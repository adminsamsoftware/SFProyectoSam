using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityPersona
    {
        private int _CodPersona;
        private string _ApePaterno;
        private string _ApeMaterno;
        private string _NomORazon;
        private string _NomCompPersona;
        private string _TipoPersona;
        private string _TipoSexo;
        private int _CodDireccion;
        private int _Estado;
        private string _UsuLogeo;
        private string _UsuMaquina;
        private string _UsuaFecIngreso;

        public int CodPersona { get => _CodPersona; set => _CodPersona = value; }
        public string ApePaterno { get => _ApePaterno; set => _ApePaterno = value; }
        public string ApeMaterno { get => _ApeMaterno; set => _ApeMaterno = value; }
        public string NomORazon { get => _NomORazon; set => _NomORazon = value; }
        public string NomCompPersona { get => _NomCompPersona; set => _NomCompPersona = value; }
        public string TipoPersona { get => _TipoPersona; set => _TipoPersona = value; }
        public string TipoSexo { get => _TipoSexo; set => _TipoSexo = value; }
        public int CodDireccion { get => _CodDireccion; set => _CodDireccion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string UsuLogeo { get => _UsuLogeo; set => _UsuLogeo = value; }
        public string UsuMaquina { get => _UsuMaquina; set => _UsuMaquina = value; }
        public string UsuaFecIngreso { get => _UsuaFecIngreso; set => _UsuaFecIngreso = value; }
    }

}
