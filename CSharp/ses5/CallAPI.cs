using System;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
namespace CSharp.ses5
{
	public class CallAPI
	{
		public async Task<Product> FetchData()
		{
			string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";

			HttpClient client = new HttpClient();
			var rs = await client.GetAsync(url);
			if (rs.StatusCode == HttpStatusCode.OK) {
				string rsText = await rs.Content.ReadAsStringAsync();
				Product p = JsonConvert.DeserializeObject<Product>(rsText);
				return p;
			}
			return null;
		}
		public CallAPI()
		{
		}
	}
}
