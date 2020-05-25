using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyFirstApi
{
    public class ServiceFile
    {

        public Countries GetFileData()
        {
            var webclient = new WebClient();
            var json = webclient.DownloadString(@"C:\Users\Lavanya\Desktop\github\CsharpSamples-Lavanya-master\MyFirstApi\wwwroot\lib\CountryJson\gistfile1.json");
            var result = JsonConvert.DeserializeObject<Countries>(json);

            return(result);
        }
    }
}
