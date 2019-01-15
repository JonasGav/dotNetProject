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
    public class RestClientTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            Mock<IRestClient> restClient = new Mock<IRestClient>();
            restClient.Setup(c => c.ExecuteAsync<MyResult>(
                    It.IsAny<IRestRequest>(),
                    It.IsAny<Action<IRestResponse<MyResult>, RestRequestAsyncHandle>>()))
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
