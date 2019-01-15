using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using dotNetProject.Backend;
using dotNetProject.Time;
using RestSharp;

namespace dotNetProject
{
    public partial class Form1 : Form
    {
        private Autofac.IContainer container;
        private Autofac.ILifetimeScope scope;
        private IRestClientCall _RestClientIss;
        private IRestClientCall _RestClientLoc;
        public Form1()
        {
            container = ContainerConfig.Configure();
            container.BeginLifetimeScope();
            scope = container.BeginLifetimeScope();
            InitializeComponent();
            _RestClientIss = new RestClientCall("http://api.open-notify.org/iss-now.json");
            _RestClientLoc = new RestClientCall("http://api.geonames.org/");
        }
        private void GetApi_Click(object sender, EventArgs e)
        { 
            var app = scope.Resolve<IParsedData>();
            app.setData(MessageTextBox, TimestampTextBox, LongitudeTextBox, LatitudeTextBox, CountryNameTxt, CountryTagTxt, ErrorTxt, listBox1.SelectedIndex, _RestClientIss, _RestClientLoc);

            /*HttpClientCall httpClient = new HttpClientCall();
            var t = Task.Run(() => HttpClientCall.CustomExceptionCallAsync());
            t.Wait();
            app.HttpSetData(t.Result, MessageTextBox, TimestampTextBox, LongitudeTextBox, LatitudeTextBox, listBox1.SelectedIndex);
            ApiData.Text = t.Result;
            */
            //http://api.geonames.org/countryCode?lat=47.03&lng=10.2&username=demo 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void ErrorTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
