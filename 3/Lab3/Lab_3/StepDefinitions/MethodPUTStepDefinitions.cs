using Lab3.Model;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.StepDefinitions
{
    [Binding]
    public class MethodPUTStepDefinitions
    {

        RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        RestResponse response;
        [When(@"make UpdateBooking request to the server")]
        public void WhenMakeUpdateBookingRequestToTheServer()
        {
            RestRequest request = new RestRequest("booking/3227", Method.Put);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(new Booking()
            {
                firstname = "Marta",
                lastname = "Blue",
                totalprice = 1000,
                depositpaid = true,
                bookingdates = new Bookingdates()
                {
                    checkin = "2022-01-01",
                    checkout = "2022-01-05"
                },
                additionalneeds = "Generator"
            });


            client.Authenticator = new HttpBasicAuthenticator("admin", "password123");

            response = client.Execute<Booking>(request);
        }

        [Then(@"the result of UpdateBooking request should be success")]
        public void ThenTheResultOfUpdateBookingRequestShouldBeSuccess()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
