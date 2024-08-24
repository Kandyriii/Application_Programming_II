using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
class NewsAggregator
{
static async Task FetchNewsAsync()
{
using (HttpClient client = new HttpClient())
{
HttpResponseMessage response = await
client.GetAsync("https://jsonplaceholder.typicode.com/posts");
response.EnSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
JArray articles = JArray.Parse(responseBody);
foreach (var article in articles)
{
Console.WriteLine("Title: " + article["title"]);
Console.WriteLine("Summary: " + article["body"]);
Console.WriteLine();
}
}
}
static void Main(string[] args)
{
FetchNewsAsync().Wait();
}
}