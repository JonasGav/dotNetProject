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
using dotNetProject.Time;
using RestSharp;

namespace dotNetProject
{
    public partial class Form1 : Form
    {
        RestClientCall client;
        public Form1()
        {
            client = new RestClientCall();
            InitializeComponent();
        }
        private void GetApi_Click(object sender, EventArgs e)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IParsedData>();
                app.setData(client.callApi());
                ApiData.Text = client.getResponse();
                app.ChangeValues(MessageTextBox, TimestampTextBox, LongitudeTextBox, LatitudeTextBox,listBox1.SelectedIndex);
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
