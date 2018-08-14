using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirServicioUploadfile
{

    class CallWebService
    {

        public static int callWebServiceToken(string user, string password, string app, string ip, string userid, int duration, ref string data)
        {
            HttpRequest request = new HttpRequest();
            request.endpoint = @"http://manager-test.knowitive.com:8080/";
            request.contentType = "application/json";
            request.resource = "auth/rest/token/";
            request.method = RestSharp.Method.POST;
            DataUser dataUser = new DataUser();
            dataUser.user = user;
            dataUser.password = password;
            dataUser.app = app;
            dataUser.ip = ip;
            dataUser.userid = userid;
            dataUser.duration = duration;
            int ret = request.Execute(ref data, dataUser);
            return ret;
        }
        public static int callWebServiceUploadFile(string token,string nameArchivo, ref string data)
        {
            HttpRequest request = new HttpRequest();
            request.endpoint = @"http://manager-test.knowitive.com:8080/";
            request.contentType = "application/json";
            //string path = @"C:\KnowitiveData\tripleter\QA_files\";
            request.resource = @"tripleter/rest/uploadfile/?user=knowitive&filepath="/*+path*/+nameArchivo;
            request.token = token;
            request.method = RestSharp.Method.POST;
            int ret = request.Execute(ref data);
            return ret;
        }
    }
}
