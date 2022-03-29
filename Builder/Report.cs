using System;

namespace Builder
{
    public class Report
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public void Save(string path)
        {

        }
    }
}
