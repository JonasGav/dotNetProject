﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using RestSharp;

namespace UnitTestingProject
{

    public class Sud
    {
        private IRestClient client;

        public Sud(IRestClient client)
        {
            this.client = client;
        }

        public MyResult Foo()
        {
            // NOTE: This code is obviously stupid; it just blocks the thread until the async task completes, which is rather pointless.
            // It's just an example :)
            MyResult result = null;
            var request = new RestRequest();
            var blocker = new AutoResetEvent(false);

            this.client.ExecuteAsync<MyResult>(
                request,
                response =>
                {
                    result = response.Data;
                    blocker.Set();
                });
            blocker.WaitOne();
            return result;
        }
    }

    public class MyResult
    {
        public string Name { get; set; }
    }
    [TestClass]
    public class RestClientCallTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            Mock<IRestClient> restClient = new Mock<IRestClient>();
            restClient.Setup(c => c.ExecuteAsync<MyResult>(
                    Moq.It.IsAny<IRestRequest>(),
                    Moq.It.IsAny<Action<IRestResponse<MyResult>, RestRequestAsyncHandle>>()))
                .Callback<IRestRequest, Action<IRestResponse<MyResult>, RestRequestAsyncHandle>>((request, callback) =>
                {
                    var responseMock = new Mock<IRestResponse<MyResult>>();
                    responseMock.Setup(r => r.Data).Returns(new MyResult() { Name = "Billy Bob" });
                    callback(responseMock.Object, null);
                });

            var Subject = new Sud(restClient.Object);

            var result = Subject.Foo();

            Assert.IsNotNull(result);
            Assert.AreEqual("Billy Bob", result.Name);
        }
    }
}