using Lab3.Model;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.StepDefinitions
{
    [Binding]
    public class LoremPicsumAPIStepDefinitions
    {
        RestClient client;
        RestRequest request;
        RestResponse responseGetRandomImage;
        RestResponse responseGetListImages;
        [Given(@"open Lorem Picsum website")]
        public void GivenOpenLoremPicsumWebsite()
        {
            client = new RestClient("https://picsum.photos/");
        }

        [When(@"make randomImageGet request to the server")]
        public void WhenMakeRandomImageGetRequestToTheServer()
        {
            request = new RestRequest("500", Method.Get);

            responseGetRandomImage = client.Execute(request);
        }

        [When(@"make listImagesGet request to the server")]
        public void WhenMakeListImagesGetRequestToTheServer()
        {
            request = new RestRequest("v2/list", Method.Get);

            responseGetListImages = client.Execute<ImagesList>(request);
        }

        [Then(@"the results should be success")]
        public void ThenTheResultsShouldBeSuccess()
        {
            Assert.That(responseGetRandomImage.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseGetListImages.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
