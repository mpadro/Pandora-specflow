using System.Configuration;
using RestSharp;

namespace Pandora.Cases.AcceptanceTest.Helpers
{
    public static class RestClientHelper
    {
        private static RestClient _restClient;
        public static RestClient RestClient
        {
            get => _restClient ?? (_restClient = new RestClient(ConfigurationManager.AppSettings["baseUrl"]));
            internal set => _restClient = value;
        }
    }
}
