using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;

namespace SampleProject.TemplateClasses
{
    public class ConnectionUtils
    {
        public static HttpClient webService = new HttpClient();
        public static string _serializedKey;


        /// <summary>
        /// INICIALIZA WebService DO TIPO HTTP CLIENT
        /// </summary>
        /// <param name="UriHost">string do caminho, será convertido internamente para URI</param>
        /// <param name="MD5serializerContents">
        /// Conteúdo que será criptografado MD5 a lista deve estar na ordem em que deve ser criptografado
        /// 
        /// </param>
        public void InitializeWebService(string UriHost, List<string> MD5serializerContents)
        {
            if (TestConnection() != IPStatus.TimedOut)
            {
                webService.BaseAddress = new Uri(UriHost);
                _serializedKey = CryptUtils.MD5Hash(MD5serializerContents);
            }
        }

        /// <summary>
        /// INICIALIZA WebService DO TIPO HTTP CLIENT
        /// </summary>
        /// <param name="UriHost">string do caminho, será convertido internamente para URI</param>
        public void InitializeWebService(string UriHost)
        {
            if (TestConnection() != IPStatus.TimedOut)
            {
                webService.BaseAddress = new Uri(UriHost);
            }
        }

        /// <summary>
        /// Testa conexão com a url passada como parametro
        /// </summary>
        /// <param name="Url">URL para testar conexão</param>
        /// <returns>Retorno é ENUM de IPStatus, irá falhar caso ocorra exceção ou ocorra timeout</returns>
        private IPStatus TestConnection(string Url = "") // Testa conexão com a API
        {
            try
            {
                return new Ping().Send(Url.Replace("http://", "").Replace("/", "")).Status;
            }
            catch (Exception ex)
            {
                return IPStatus.TimedOut;
            }

        }
    }
}
