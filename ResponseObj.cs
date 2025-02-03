using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("modified")]
    public bool modified { get; set; }

    [JsonProperty("text")]
    public string text { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
