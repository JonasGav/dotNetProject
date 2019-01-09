using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace dotNetProject
{
    interface IParsedData
    {
        float Latitude { get; }
        float Longitude { get; }
        string Message { get; }
        string Timestamp { get; }
        string TimestampRaw { get; }

        void HttpSetData(string response, TextBox messageTextBox, TextBox timestampTextBox, TextBox longitudeTextBox, TextBox latitudeTextBox, int selectedIndex);
        void setData(IRestResponse response);
    }
}