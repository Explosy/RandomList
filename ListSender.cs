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
        private string serverURL;
        
        public ListSender(string serverURL)
        {
            this.serverURL = serverURL;
        }
        /// <summary>
        /// Метод отправки данных на сервер по URL, заданному при создании класса ListSender
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Возвращает true в случае успеха, false - в случае провала</returns>
        public bool Send(int[] array)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(serverURL);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(array);
                streamWriter.Write(json);
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpResponse.StatusCode == HttpStatusCode.Accepted) return true;
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
    }
}
