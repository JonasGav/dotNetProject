using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RestSharp;
using Newtonsoft.Json;
using dotNetProject.Time;

namespace dotNetProject
{
    class ParsedData : IParsedData
    {
        IFormatedTime  _FormatedTime;
        IRawTime _RawTime;

        public string Timestamp { get; private set; }
        public string Message { get; private set; }
        public float Longitude { get; private set; }
        public float Latitude { get; private set; }
        public ParsedData( IFormatedTime formatedTime, IRawTime rawTime)
        {
            _FormatedTime = formatedTime;
            _RawTime = rawTime;
        }
        public void setData(IRestResponse response)
        {
            dynamic parsed = JsonConvert.DeserializeObject  (response.Content);
            Timestamp = _FormatedTime.GetTimestamp(Convert.ToString(parsed.timestamp));
            Message = parsed.message;
            Latitude = parsed.iss_position.latitude;
            Longitude = parsed.iss_position.longitude;
        }

        public void ChangeValues(System.Windows.Forms.TextBox messageTextBox, System.Windows.Forms.TextBox timestampTextBox,
            System.Windows.Forms.TextBox longitudeTextBox, System.Windows.Forms.TextBox latitudeTextBox)
        {
            messageTextBox.Text = Message;
            timestampTextBox.Text = Timestamp;
            longitudeTextBox.Text = Longitude.ToString();
            latitudeTextBox.Text = Latitude.ToString();
        }
    }
}
// {"timestamp": 1545005235, "iss_position": {"latitude": "-4.1035", "longitude": "-76.4796"}, "message": "success"}