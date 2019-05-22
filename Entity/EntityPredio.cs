using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EntityPredio
    {
        private int _CodPredio;
        private int _CodDireccion;
        private decimal _FrenteLineal;
        private int _FrentePavimentado;
        private string _LadoPredio;
        private string _TipoPredio;
        private string _UbicParques;
        private string _CuadAsignada;
        private string _NomPredio;
        private decimal _TotalFrentePavim;
        private int _CodAgrupacion;
        private string _Manzana;
        private string _Lote;
        private string _PartRegistral;
        private int _CodDirCatastro;
        private int _CodSector;
        private int _CodManzana;
        private int _CodLote;
        private decimal _AreaTerreno;
        private decimal _AreConstruida;
        private decimal _AreaTerreComun;
        private decimal _AreaConstComun;
        private int _SitPredio;
        private int _Estado;

        public int CodPredio { get => _CodPredio; set => _CodPredio = value; }
        public int CodDireccion { get => _CodDireccion; set => _CodDireccion = value; }
        public decimal FrenteLineal { get => _FrenteLineal; set => _FrenteLineal = value; }
        public int FrentePavimentado { get => _FrentePavimentado; set => _FrentePavimentado = value; }
        public string LadoPredio { get => _LadoPredio; set => _LadoPredio = value; }
        public string TipoPredio { get => _TipoPredio; set => _TipoPredio = value; }
        public string UbicParques { get => _UbicParques; set => _UbicParques = value; }
        public string CuadAsignada { get => _CuadAsignada; set => _CuadAsignada = value; }
        public string NomPredio { get => _NomPredio; set => _NomPredio = value; }
        public decimal TotalFrentePavim { get => _TotalFrentePavim; set => _TotalFrentePavim = value; }
        public int CodAgrupacion { get => _CodAgrupacion; set => _CodAgrupacion = value; }
        public string Manzana { get => _Manzana; set => _Manzana = value; }
        public string Lote { get => _Lote; set => _Lote = value; }
        public string PartRegistral { get => _PartRegistral; set => _PartRegistral = value; }
        public int CodDirCatastro { get => _CodDirCatastro; set => _CodDirCatastro = value; }
        public int CodSector { get => _CodSector; set => _CodSector = value; }
        public int CodManzana { get => _CodManzana; set => _CodManzana = value; }
        public int CodLote { get => _CodLote; set => _CodLote = value; }
        public decimal AreaTerreno { get => _AreaTerreno; set => _AreaTerreno = value; }
        public decimal AreConstruida { get => _AreConstruida; set => _AreConstruida = value; }
        public decimal AreaTerreComun { get => _AreaTerreComun; set => _AreaTerreComun = value; }
        public decimal AreaConstComun { get => _AreaConstComun; set => _AreaConstComun = value; }
        public int SitPredio { get => _SitPredio; set => _SitPredio = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
