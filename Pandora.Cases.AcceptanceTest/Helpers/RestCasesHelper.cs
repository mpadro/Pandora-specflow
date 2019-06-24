using Pandora.Cases.AcceptanceTest.Models;
using RestSharp;

namespace Pandora.Cases.AcceptanceTest.Helpers
{
    public static class RestCasesHelper
    {
        private static readonly RestClient Client = new RestClient("https://p112client.test.pandoraintelligence.com/api/cases");

        public static IRestResponse<Case> CasesGet(string caseId, string guid)
        {
            var request = new RestRequest($"/{guid}/entities/{caseId}", Method.GET);
            request.AddHeader("authorization", "Bearer " /*+ authtoken*/);
            return Client.Execute<Case>(request);
        }
    }
}
