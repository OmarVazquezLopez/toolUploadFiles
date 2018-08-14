using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using NLog;
using System.Diagnostics;
using System.IO;
namespace ConsumirServicioUploadfile
{
    public partial class Form1 : Form
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
           
        }
        string data;
        string tok = string.Empty;
        bool success = false;
        int code = 0;
        string data2 = string.Empty;
        private void btnLlamarToken_Click(object sender, EventArgs e)
        {
            

            int ret = CallWebService.callWebServiceToken("knowitive", "12345", "***", "***", "***", 300,  ref data);
            if (ret <= 0)
            {
                MessageBox.Show("Ocurrió algun error!");
                return;
            }
            Token token = JsonConvert.DeserializeObject<Token>(data);
            this.tok = token.token;
            this.success = token.Success;
            txtIngresarToken.Text = 
            textBox1.Text = tok;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            Stopwatch timeService = new Stopwatch();

            listBox1.Items.Clear();
            timeService.Reset();
            timeService.Start();
            int ret = CallWebService.callWebServiceUploadFile(txtIngresarToken.Text, txtIngresarArchivo.Text, ref data);
            timeService.Stop();
            if(ret <= 0)
            {
                MessageBox.Show("Error: "+data);
                return;
            }
            ResponseUploadfile response = JsonConvert.DeserializeObject<ResponseUploadfile>(data);
            this.success = response.Success;
            this.code = response.Code;
            this.data2 = response.Data;

            listBox1.Items.Add(string.Format("Archivo = {0}", txtIngresarArchivo.Text));
            listBox1.Items.Add(string.Format("success = {0}",success));
            listBox1.Items.Add(string.Format("code = {0}", code));
            listBox1.Items.Add(string.Format("data = {0}", data2));
            listBox1.Items.Add(string.Format("timeService = {0}:{1}.{2}",timeService.Elapsed.Minutes,timeService.Elapsed.Seconds, timeService.Elapsed.Milliseconds));
        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            Stopwatch tiempoPorArchivo = new Stopwatch();
            listBox1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"C:\Archivos");
            List<string> archivos = new List<string>();
            foreach(var fi in di.GetFiles())
            {
                archivos.Add(fi.Name);
            }
            log.Info("---------Iniciando proceso carga de archivos..." + Environment.NewLine);
            foreach (string archivo in archivos)
            {
                log.Info("Iniciando carga|" + archivo + Environment.NewLine);
                tiempoPorArchivo.Reset();
                tiempoPorArchivo.Start();
                int ret = CallWebService.callWebServiceUploadFile(txtIngresarToken.Text, archivo, ref data);
                tiempoPorArchivo.Stop();
                if(ret <= 0)
                {
                    log.Error("Fallo|" + archivo + Environment.NewLine);
                    continue;
                }
                ResponseUploadfile response = JsonConvert.DeserializeObject<ResponseUploadfile>(data);
                this.success = response.Success;
                this.code = response.Code;
                this.data2 = response.Data;
                string tiempoTranscurrido = string.Format("{0}:{1}.{2}",tiempoPorArchivo.Elapsed.Minutes, tiempoPorArchivo.Elapsed.Seconds, tiempoPorArchivo.Elapsed.Milliseconds);
                log.Info("Terminada carga archivo|" + archivo + "|Tiempo|" + tiempoTranscurrido + "|Mensaje|" + data2 + Environment.NewLine);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            btnCargarArchivos.Enabled = (checkBox1.CheckState == CheckState.Checked);
        }
    }
}
