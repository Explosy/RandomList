using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;


namespace RandomList
{
    /// <summary>
    /// Класс реализующий отправку POST запроса с сформированной последовательностью чисел на указанный сервер
    /// </summary>
    internal class ListSender
    {
        public bool Send(int[] array)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8888/connection/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(array);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.Accepted) return true;
            return false;
        }
    }
}
