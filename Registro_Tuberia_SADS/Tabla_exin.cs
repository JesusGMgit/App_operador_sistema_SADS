using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Registro_Tuberia_SADS
{
    public class Tabla_exin
    {
        [JsonProperty("T_ID_tubo")]
        public string T_ID_tubo { get; set; }
        [JsonProperty("T_No_tubo")]
        public string T_No_tubo { get; set; }
        [JsonProperty("T_No_placa")]
        public string T_No_placa { get; set; }
        [JsonProperty("T_ID_proyecto")]
        public string T_ID_proyecto { get; set; }
        [JsonProperty("T_Lote_alambre")]
        public string T_Lote_alambre { get; set; }
        [JsonProperty("T_Lote_fundente")]
        public string T_Lote_fundente { get; set; }
        [JsonProperty("T_Maquina")]
        public string T_Maquina { get; set; }
        [JsonProperty("T_FolioOperador")]
        public string T_FolioOperador { get; set; }
        [JsonProperty("T_Fecha")]
        public string T_Fecha { get; set; }
        [JsonProperty("T_Hora")]
        public string T_Hora { get; set; }
        [JsonProperty("T_Hora_db")]
        public string T_Hora_db { get; set; }
        [JsonProperty("T_Archivos_excel")]
        public string T_Archivos_excel { get; set; }
        [JsonProperty("T_Reporte_excel")]
        public string T_Reporte_excel { get; set; }
        [JsonProperty("T_Observaciones")]
        public string T_Observaciones { get; set; }
    }
}
