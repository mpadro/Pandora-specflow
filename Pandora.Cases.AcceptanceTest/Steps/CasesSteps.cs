using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pandora.Cases.AcceptanceTest.Helpers;
using Pandora.Cases.AcceptanceTest.Models;
using RestSharp;
using TechTalk.SpecFlow;

namespace Pandora.Cases.AcceptanceTest.Steps
{
    [Binding]
    public class CasesSteps
    {
        private string _caseId;
        private string _guid;
        private IRestResponse<Case> _response;

        [Given(@"I have a case")]
        public void GivenIHaveACase()
        {
            /* I'm hardcoding data here but the idea would be to get the needed data by having the data that would be passed by parameter */
            _caseId = "3d3eaf26-cf7e-45af-b37b-f061c32d80c5";
            _guid = "067ab03d-952f-4039-9396-662bd3399dfd";
        }

        [Given(@"I have a case for user '(.*)'")]
        public void GivenIHaveACaseForUser(string user)
        {
            /* I'm hardcoding data here but the idea would be to get the needed data, as an example I'm sending username by parameter here and associated/needed data could be get using it */
            _caseId = "3d3eaf26-cf7e-45af-b37b-f061c32d80c5";
            _guid = "067ab03d-952f-4039-9396-662bd3399dfd";
        }


        [When(@"I get the case")]
        public void WhenIGetTheCase()
        {
            RestCasesHelper.SetAuthenticationToken();
            _response = RestCasesHelper.CasesGet(_caseId, _guid);
        }

        [Then(@"The case information is retrieved")]
        public void ThenTheCaseInformationIsRetrieved()
        {
            Assert.IsTrue(_response.IsSuccessful, "The get response wasn't successful");
            Assert.AreEqual(_response.Data.name, "Sebastian Talamoni");
        }
    }
}
