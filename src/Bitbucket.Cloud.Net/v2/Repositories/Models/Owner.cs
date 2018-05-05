﻿using System;
using Bitbucket.Cloud.Net.v2.Models;
using Newtonsoft.Json;

namespace Bitbucket.Cloud.Net.v2.Repositories.Models
{
    public class Owner
    {
        public string UserName { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        public string Type { get; set; }
        public Guid Uuid { get; set; }
        public OwnerLinks Links { get; set; }
    }
}