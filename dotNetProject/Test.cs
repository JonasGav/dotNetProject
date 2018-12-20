using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject
{
    class Test
    {
        public void Submit_PerformsCorrectRequest()
        {
            /*
            //setup
            var restClient = new RestClient("http://api.open-notify.org/iss-now.json");
            var restResponse = restClient.Execute(new RestRequest());

            //Setup
            //var request = new JobRecWithUserPrefRequestStub("J1234567890123456789", "U1234567890123456789",
              //  "DevKey", "api.careerbuilder.com", "", "");

            //Mock crap
            var response = new RestResponse();

            var restReq = new Mock<IRestRequest>();
            restReq.Setup(x => x.AddParameter("DeveloperKey", "DevKey"));
            restReq.Setup(x => x.AddParameter("JobDID", "J1234567890123456789"));
            restReq.Setup(x => x.AddParameter("UserDID", "U1234567890123456789"));
            restReq.SetupSet(x => x.RootElement = "RecommendJobResults");

            var restClientMock = new Mock<IRestClient>();
            restClientMock.SetupSet(x => x.BaseUrl = "http://api.open-notify.org/iss-now.json");
            restClientMock.Setup(x => x.Execute<List<RecommendJobResult>>(It.IsAny<IRestRequest>())).Returns(response);

            request.Request = restReq.Object;
            request.Client = restClient.Object;

            //Assert
            List<RecommendJobResult> resp = request.GetRecommendations();
            restReq.VerifyAll();
            restClient.VerifyAll();
            */
        }
    }
}
