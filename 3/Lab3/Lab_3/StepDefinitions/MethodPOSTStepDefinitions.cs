using Lab3.Model;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.StepDefinitions
{
    [Binding]
    public class MethodPOSTStepDefinitions
    {

        RestClient client = new RestClient("https://restful-booker.herokuapp.com/");
        RestResponse response;
        [When(@"make CreateBooking request to the server")]
        public void WhenMakeCreateBookingRequestToTheServer()
        {
            RestRequest request = new RestRequest("booking", Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(new Booking()
            {
                firstname = "Marta",
                lastname = "Green",
                totalprice = 1250,
                depositpaid = true,
                bookingdates = new Bookingdates()
                {
                    checkin = "2022-01-01",
                    checkout = "2022-01-05"
                },
                additionalneeds = "Generator"
            });

            response = client.Execute<Booking>(request);
        }

        [Then(@"the result of CreateBooking request should be success")]
        public void ThenTheResultOfCreateBookingRequestShouldBeSuccess()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
