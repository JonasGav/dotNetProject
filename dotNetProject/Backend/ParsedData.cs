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
        public string TimestampRaw { get; private set; }
        public string Message { get; private set; }
        public float Longitude { get; private set; }
        public float Latitude { get; private set; }
        public ParsedData( IFormatedTime formatedTime, IRawTime rawTime)
        {
            _FormatedTime = formatedTime;
            _RawTime = rawTime;
        }
        public void setData(System.Windows.Forms.TextBox messageTextBox, System.Windows.Forms.TextBox timestampTextBox,
            System.Windows.Forms.TextBox longitudeTextBox, System.Windows.Forms.TextBox latitudeTextBox, 
            System.Windows.Forms.TextBox CountryNameTxt, System.Windows.Forms.TextBox CountryTagTxt, System.Windows.Forms.Label ErrorTxt, int selectedIndex,
            IRestClientCall _RestClientIss, IRestClientCall _RestClientLoc)
        {
            dynamic parsed = _RestClientIss.callApi();
            Timestamp = _FormatedTime.GetTimestamp(Convert.ToString(parsed.timestamp));
            TimestampRaw = _RawTime.GetTimestamp(Convert.ToString(parsed.timestamp));
            Message = parsed.message;
            Latitude = parsed.iss_position.latitude;
            Longitude = parsed.iss_position.longitude;
            messageTextBox.Text = Message;
            timestampTextBox.Text = (selectedIndex == 1 ? Timestamp : TimestampRaw);
            longitudeTextBox.Text = Longitude.ToString();
            latitudeTextBox.Text = Latitude.ToString();
            dynamic parsedLoc = _RestClientLoc.callApi(true, Longitude.ToString(), Latitude.ToString());
            if (parsedLoc.message != null) ErrorTxt.Text = "aaaa";
            else
            {
                CountryNameTxt.Text = parsedLoc.countryName;
                CountryTagTxt.Text = parsedLoc.countryCode;
            }

        }

        public void HttpSetData(string response, System.Windows.Forms.TextBox messageTextBox, System.Windows.Forms.TextBox timestampTextBox,
            System.Windows.Forms.TextBox longitudeTextBox, System.Windows.Forms.TextBox latitudeTextBox, int selectedIndex)
        {
            dynamic parsed = JsonConvert.DeserializeObject(response);
            Timestamp = _FormatedTime.GetTimestamp(Convert.ToString(parsed.timestamp));
            TimestampRaw = _RawTime.GetTimestamp(Convert.ToString(parsed.timestamp));
            Message = parsed.message;
            Latitude = parsed.iss_position.latitude;
            Longitude = parsed.iss_position.longitude;
            messageTextBox.Text = Message;
            timestampTextBox.Text = (selectedIndex == 1 ? Timestamp : TimestampRaw);
            longitudeTextBox.Text = Longitude.ToString();
            latitudeTextBox.Text = Latitude.ToString();
        }

        /*public void ChangeValues(System.Windows.Forms.TextBox messageTextBox, System.Windows.Forms.TextBox timestampTextBox,
            System.Windows.Forms.TextBox longitudeTextBox, System.Windows.Forms.TextBox latitudeTextBox, int selectedIndex)
        {
            //Timestamp = (selectedIndex == 1 ? Timestamp)
            messageTextBox.Text = Message;
            timestampTextBox.Text = (selectedIndex == 1 ? Timestamp : TimestampRaw);
            longitudeTextBox.Text = Longitude.ToString();
            latitudeTextBox.Text = Latitude.ToString();
        }*/
    }
}
// {"timestamp": 1545005235, "iss_position": {"latitude": "-4.1035", "longitude": "-76.4796"}, "message": "success"}