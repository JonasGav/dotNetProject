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

        private string Timestamp { get; set; }
        private string TimestampRaw { get; set; }
        private string Message { get; set; }
        private float Longitude { get; set; }
        private float Latitude { get; set; }
        private string LocMessage { get; set; }
        private int StatusValue { get; set; }
        private string CountryName { get; set; }
        private string CountryTag { get; set; }

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
            try
            {
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
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                ErrorTxt.Text = "No Internet connection";
                return;
            }
            dynamic parsedLoc = _RestClientLoc.callApi(true, Longitude.ToString(), Latitude.ToString());

            try
            {
                CountryName = parsedLoc.countryName;
                CountryTag = parsedLoc.countryCode;
                CountryNameTxt.Text = CountryName;
                CountryTagTxt.Text = CountryTag;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                try
                {
                    StatusValue = parsedLoc.status.value;
                    if (StatusValue != 15) throw new Microsoft.CSharp.RuntimeBinder.RuntimeBinderException();
                    LocMessage = parsedLoc.status.message;
                    CountryNameTxt.Text = "Ocean";
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
                {
                    try
                    {
                        StatusValue = parsedLoc.status.value;
                        LocMessage = parsedLoc.status.message;
                        ErrorTxt.Text = LocMessage;
                    }
                    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
                    {
                        ErrorTxt.Text = "No internet connection";
                    }
                }
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