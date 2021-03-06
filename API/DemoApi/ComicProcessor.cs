﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi
{
    public class ComicProcessor
    {
        public static async Task<ComicModel> LoadComic(int number=0)
        {
            string url = "";

            if (number > 0)
                url = $"https://xkcd.com/{ number }/info.0.json";
            else
                url = $"https://xkcd.com/info.0.json";

            using (HttpResponseMessage response=await ApiHelper.Client.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }



    }
}
