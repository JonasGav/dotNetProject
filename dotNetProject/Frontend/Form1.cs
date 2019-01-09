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
        public Form1()
        {
            InitializeComponent();
        }
        private void GetApi_Click(object sender, EventArgs e)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                //RestClientCall client = new RestClientCall();
                HttpClientCall httpClient = new HttpClientCall();
                var app = scope.Resolve<IParsedData>();
                //app.setData(client.callApi());
                var t = Task.Run(() => HttpClientCall.CustomExceptionCallAsync());
                t.Wait();
                app.HttpSetData(t.Result, MessageTextBox, TimestampTextBox, LongitudeTextBox, LatitudeTextBox, listBox1.SelectedIndex);
                ApiData.Text = t.Result;
                //app.ChangeValues(MessageTextBox, TimestampTextBox, LongitudeTextBox, LatitudeTextBox,listBox1.SelectedIndex);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
