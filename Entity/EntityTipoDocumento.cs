using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class EntityTipoDocumento
    {
        
        private int _CodTipoDocumento;
        private string _DesTipoDocumento;
        private int _Estado;

        public int CodTipoDocumento { get => _CodTipoDocumento; set => _CodTipoDocumento = value; }
        public string DesTipoDocumento { get => _DesTipoDocumento; set => _DesTipoDocumento = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
