﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class FlairRichtext
    {
        [JsonProperty("e")]
        public string E;

        [JsonProperty("t")]
        public string T;
    }
}