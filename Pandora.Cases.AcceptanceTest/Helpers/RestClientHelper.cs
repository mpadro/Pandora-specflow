using System.Configuration;
using RestSharp;

namespace Pandora.Cases.AcceptanceTest.Helpers
{
    public static class RestClientHelper
    {
        private static RestClient _restClient;
        public static RestClient RestClient
        {
            get
            {
                if (_restClient == null)
                    _restClient = new RestClient(ConfigurationManager.AppSettings["baseUrl"]);

                return _restClient;
            }
            internal set => _restClient = value;
        }
    }
}
