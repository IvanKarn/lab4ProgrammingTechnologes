using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Iterator
{
    internal class WebIterator : IIterator<string>
    {
        private int Index = 0;
        private List<Uri> Urls;
        public WebIterator(List<Uri> Urls)
        {
            this.Urls = Urls;
        }
        public bool HasNext()
        {
            return Urls.Count > Index;
        }

        public string Next()
        {
            using (var client = new HttpClient())
            {
                using var result = client.GetAsync(Urls[Index]).Result;
                ++Index;
                return result.StatusCode.ToString();
            }
        }
    }
}
