using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumirServicioUploadfile
{
    public class DataUser // Envíar al servicio
    {

        [JsonProperty(PropertyName = "user", Required = Required.Always)]
        public string user { get; set; }

        [JsonProperty(PropertyName = "password", Required = Required.Always)]
        public string password { get; set; }

        [JsonProperty(PropertyName = "app", Required = Required.Always)]
        public string app { get; set; }

        [JsonProperty(PropertyName = "ip", Required = Required.Always)]
        public string ip { get; set; }

        [JsonProperty(PropertyName = "userid", Required = Required.Always)]
        public string userid { get; set; }

        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public int duration { get; set; }

    }
}
