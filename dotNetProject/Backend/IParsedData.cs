using System.Windows.Forms;

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
        void setData(TextBox messageTextBox, TextBox timestampTextBox, TextBox longitudeTextBox, TextBox latitudeTextBox, TextBox CountryNameTxt, TextBox CountryTagTxt, Label ErrorTxt, int selectedIndex, IRestClientCall _RestClientIss, IRestClientCall _RestClientLoc);
    }
}