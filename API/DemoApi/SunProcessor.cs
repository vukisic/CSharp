using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunTime()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today";

            using (HttpResponseMessage response = await ApiHelper.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();
                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
