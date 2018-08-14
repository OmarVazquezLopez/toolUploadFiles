using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;
using System.Net;

namespace ConsumirServicioUploadfile
{
    class HttpRequest
    {

        public string endpoint { get; set; }
        public string contentType { get; set; }
        public string resource { get; set; }
        public Method method { get; set; }
        public string token { get; set; }

        public int Execute(ref string data, dynamic dataJson = null)
        {
            RestClient client = new RestClient(this.endpoint);
            RestRequest request = new RestRequest(this.resource, this.method);
            int ret;
            if (dataJson != null)
            {
                request.AddJsonBody(dataJson);
            }
            if (this.token != null)
            {
                request.AddHeader("Authorization", "Bearer " + this.token);
            }
            request.AddHeader("ContentType", this.contentType);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = this.contentType;
            IRestResponse response = client.Execute(request);
            client = null;
            request = null;
            data = response.Content;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (data == string.Empty) //No es posible conectar con el servidor remoto
                {
                    data = response.ErrorMessage;
                    ret = -2;
                }
                else
                {
                    ret = -1;
                }
            }
            else
            {
                ret = 1;
            }
            response = null;
            return ret;
        }

    }
}
