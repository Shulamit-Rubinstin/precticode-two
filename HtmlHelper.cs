using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Prakticode2
{
    internal class HtmlHelper
    {
        private readonly static HtmlHelper _instance=new HtmlHelper();
        public static HtmlHelper Instance { get { return _instance; } }
        public string[] Tags { get; set; }
        public string[] HtmlVoidTags { get; set; }
        private HtmlHelper()
        {
                string json1 = File.ReadAllText("jsonFiles/HtmlTags.json");
                string json2 = File.ReadAllText("jsonFiles/HtmlVoidTags.json");

            Tags = JsonSerializer.Deserialize<string[]>(json1);
            HtmlVoidTags = JsonSerializer.Deserialize<string[]>(json2);
        }
    }
}
