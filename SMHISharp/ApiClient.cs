﻿using Piksel.SMHISharp.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using NetJSON;
using Newtonsoft.Json;

namespace Piksel.SMHISharp
{
    public class ApiClient
    {
        const string Version = "1.0";
        public string EntryPoint { get; set; } = "http://opendata-download-metobs.smhi.se/api";

        public Dictionary<string, Resource> _resources;
        private JsonSerializerSettings _settings;

        public ApiClient()
        {
            _settings = new JsonSerializerSettings();
            _settings.Converters.Add(new IntDateConverter());
        }

        public async void GetResources(Action<Resource[]> callback, bool refresh = false)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryPoint}/version/{Version}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var version = await JsonConvert.DeserializeObjectAsync<VersionResult>(Encoding.UTF8.GetString(result), _settings);
                callback(version.Resource);
            }
        }

        public async void GetStations(string parameter, Action<Station[]> callback)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryPoint}/version/{Version}/parameter/{parameter}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var param = await JsonConvert.DeserializeObjectAsync<Parameter>(Encoding.UTF8.GetString(result), _settings);
                callback(param.Station);
            }
        }
    }
}