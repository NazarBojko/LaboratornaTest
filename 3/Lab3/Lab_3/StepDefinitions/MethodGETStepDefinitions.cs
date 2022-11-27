using Lab3.Model;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.StepDefinitions
{
    [Binding]
    public class MethodGETStepDefinitions
    {
        RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        RestResponse response;
        [When(@"make GetBookingIds request to the server")]
        public void WhenMakeGetBookingIdsRequestToTheServer()
        {
            RestRequest request = new RestRequest("booking", Method.Get);
            response = client.Execute<Booking>(request);
        }

        [Then(@"the result of GetBookingIds request should be success")]
        public void ThenTheResultOfGetBookingIdsRequestShouldBeSuccess()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
