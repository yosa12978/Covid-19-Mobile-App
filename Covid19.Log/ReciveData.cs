using Covid19.Log.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace Covid19.Log
{
    public class ReciveData
    {
        public static Global GetGlobal() 
        {
            var client = new WebClient();
            string claimData = client.DownloadString("https://coronavirus-19-api.herokuapp.com/all");
            Global global = JsonConvert.DeserializeObject<Global>(claimData);
            return global;
        }
    }
}
