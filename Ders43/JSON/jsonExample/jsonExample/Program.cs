using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace jsonExample
{
    class Program
    {


        public static async Task Main(string[] args) //async
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";

            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);

                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                Console.WriteLine(jsonResponse);

                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.Id} {post.Title}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                httpClient.Dispose();
            }

        }

    }
}
