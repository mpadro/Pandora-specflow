using System;
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
            _caseId = "3d3eaf26-cf7e-45af-b37b-f061c32d80c5";
            _guid = "067ab03d-952f-4039-9396-662bd3399dfd";
        }

        [When(@"I get the case")]
        public void WhenIGetTheCase()
        {
            _response = RestCasesHelper.CasesGet(_caseId, _guid);
        }

        [Then(@"The case information is retrieved")]
        public void ThenTheCaseInformationIsRetrieved()
        {
            Assert.AreEqual(_response.Data.name, "Sebastian Talamoni");
        }
    }
}
