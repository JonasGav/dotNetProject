using RestSharp;

namespace dotNetProject
{
    interface IParsedData
    {
        string Message { get; }
        string Timestamp { get; }
        void ChangeValues(System.Windows.Forms.TextBox messageTextBox, System.Windows.Forms.TextBox timestampTextBox,
            System.Windows.Forms.TextBox longitudeTextBox, System.Windows.Forms.TextBox latitudeTextBox);
        void setData(IRestResponse response);
    }
}