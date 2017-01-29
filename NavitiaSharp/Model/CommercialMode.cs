﻿using RestSharp.Deserializers;
using System.Collections.Generic;

namespace NavitiaSharp
{
    public class CommercialMode
    {

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}