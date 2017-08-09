using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeezerApp.Service.Domain
{
    public class ServiceResponse
    {
        public List<Song> data;

        public static ServiceResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<ServiceResponse>(jsonString);
        }

        public List<Song> GetQuantityOfSongs(int songsQuantity)
        {
            if (data.Count > songsQuantity)
            {
                data.RemoveRange(songsQuantity - 1, data.Count - songsQuantity);
            }

            return data;
        }

    }
}
