using DeezerApp.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DeezerApp.Service.Service
{
    public class DeezerService : IService
    {
        private string mashapeKey = string.Empty;

        public DeezerService(string mashapeKey)
        {
            this.mashapeKey = mashapeKey;
        }

        public ServiceResponse GetSongs(string artistName)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(string.Format("https://deezerdevs-deezer.p.mashape.com/search?q={0}", artistName));

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
            client.DefaultRequestHeaders.Add("X-Mashape-Key", mashapeKey);
            string urlParameters = string.Empty;

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects =  response.Content.ReadAsStringAsync();
                return ServiceResponse.FromJson(dataObjects.Result);
            }
            else
            {
                throw new ApplicationException("Error connecting to Mashape service");
            }
        }

    }
}
