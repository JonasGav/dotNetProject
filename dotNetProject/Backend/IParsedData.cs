using System.Windows.Forms;

namespace dotNetProject
{
    public interface IParsedData
    {
        void HttpSetData(string response, TextBox messageTextBox, TextBox timestampTextBox, TextBox longitudeTextBox, TextBox latitudeTextBox, int selectedIndex);
        void setData(TextBox messageTextBox, TextBox timestampTextBox, TextBox longitudeTextBox, TextBox latitudeTextBox, TextBox CountryNameTxt, TextBox CountryTagTxt, Label ErrorTxt, int selectedIndex, IRestClientCall _RestClientIss, IRestClientCall _RestClientLoc);
    }
}