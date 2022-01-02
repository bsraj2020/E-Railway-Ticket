using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticket_Pro_472
{
    class RestAPI_Helper
    {
        public static async Task<string> All_trains(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                
                
                using (HttpResponseMessage Res = await client.GetAsync(url) )
                {
                    using (HttpContent content = Res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null) return data;
                    }
                }
            }
            return string.Empty;
        }
    }
}
