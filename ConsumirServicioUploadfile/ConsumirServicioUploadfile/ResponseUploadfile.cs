using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumirServicioUploadfile
{
    class ResponseUploadfile
    {

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
        
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
    }
}
