using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.StepDefinitions
{
    [Binding]
    public class MethodDELETEStepDefinitions
    {
        RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        RestResponse response;
        [When(@"make DeleteBooking request to the server")]
        public void WhenMakeDeleteBookingRequestToTheServer()
        {
            RestRequest request = new RestRequest("booking/225", Method.Delete);

            client.Authenticator = new HttpBasicAuthenticator("admin", "password123");

            response = client.Execute(request);
        }

        [Then(@"the result of DeleteBooking request should be success")]
        public void ThenTheResultOfDeleteBookingRequestShouldBeSuccess()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
    }
}
