using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMail
{
    public class MessageData
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
