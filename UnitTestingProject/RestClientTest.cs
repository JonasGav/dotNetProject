using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using RestSharp;
using Newtonsoft.Json;

namespace UnitTestingProject
{
    public class TestingPurpose
    {
        IRestClientCall rest;
        public TestingPurpose(IRestClientCall _rest)
        {
            rest = _rest;
        }
        public dynamic desValue()
        {
            return (JsonConvert.DeserializeObject (rest.callApi()));
        }
    }

    [TestClass]
    public class IssPositionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var timestamp = "1547536727";
            var latitude = "54.6756144";
            var longitude = "25.2688049";

            Mock<IRestClientCall> mockCall = new Mock<IRestClientCall>();
            mockCall
                .Setup(call => call.callApi(false, It.IsAny<string>(), It.IsAny<string>()))
                .Returns("{\"timestamp\": \"1547536727\", \"iss_position\": {\"latitude\": \"54.6756144\", \"longitude\": \"25.2688049\"}, \"message\": \"success\"}");

            TestingPurpose testMethod = new TestingPurpose(mockCall.Object);
            dynamic test = testMethod.desValue();
            Console.WriteLine(test);
            Assert.AreEqual(timestamp, (string)test.timestamp);
            Assert.AreEqual(latitude, (string)test.iss_position.latitude);
            Assert.AreEqual(longitude, (string)test.iss_position.longitude);
            //mocObj
            //.setup (char => char.GetData())
            //.return (asdflkasdfld)
        }
    }
}