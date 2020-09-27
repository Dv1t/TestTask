using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System;
using System.Xml;

namespace TestTask
{
    public static class GetRequestService
    {
		public static async Task<T> Get<T>(string url)
		{
			if (string.IsNullOrEmpty(url))
			{
				throw new NullReferenceException("Url is null.");
			}

			using (HttpClientHandler handler = new HttpClientHandler())
			{
				if (handler.SupportsAutomaticDecompression)
				{
					handler.AutomaticDecompression = DecompressionMethods.Deflate;
				}
				using (HttpClient httpClient = new HttpClient(handler))
				{
					string data = await httpClient.GetStringAsync(url).ConfigureAwait(false);

					if (!string.IsNullOrEmpty(data))
					{
						var serializer = new XmlSerializer(typeof(T));
						XmlDocument doc = new XmlDocument();
						doc.LoadXml(data);
						MemoryStream xmlStream = new MemoryStream();
						doc.Save(xmlStream);
						xmlStream.Flush();
						xmlStream.Position = 0;
						return (T)serializer.Deserialize(xmlStream);
					}
					return default(T);
				}
			}
		}
	}
}
