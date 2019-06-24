using Pandora.Cases.AcceptanceTest.Models;
using RestSharp;

namespace Pandora.Cases.AcceptanceTest.Helpers
{
    public static class RestCasesHelper
    {
        public static IRestResponse<Case> CasesGet(string caseId, string guid)
        {
            var request = new RestRequest($"/{guid}/entities/{caseId}", Method.GET);
            return RestClientHelper.RestClient.Execute<Case>(request);
        }

        public static void SetAuthenticationToken()
        {
            /*Add logic here to get and set the authorization token*/
        }
    }
}
