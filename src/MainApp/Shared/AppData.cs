﻿using Camunda.Http.Api.Api;
using Camunda.Http.Api.Client;
using Camunda.Http.Api.Model;

namespace MainApp.Shared
{
    using System.Net.Http;
    using Camunda.Http;
    using System;
    using Blazorise.Snackbar;

    public class AppData
        {

        public CamundaClient CamundaClient { get; set; }

        public string EngineUrl { get; set; } = "https://localhost:8080/engine-rest";

        public string EngineUsername { get; set; } = "admin";

        public string EnginePassword { get; set; } = "admin";

        private readonly IHttpClientFactory ClientFactory;

        public SnackbarStack snackbarStack;
        public int intervalBeforeMsgClose = 8000;

        public HttpClient HttpClient { get; set; }


        public AppData(IHttpClientFactory clientFactory)
        {
            this.ClientFactory = clientFactory;
            CreateClient();
        }

        public string GetBasicAuthValue(string username, string password)
        {
            string encoded = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(EngineUsername + ":" + EnginePassword));
            return "Basic " + encoded;
        }

        public void CreateClient()
        {
            var client = this.ClientFactory.CreateClient("CamundaAPI");
            var config = new Configuration
            {
                BasePath = EngineUrl
            };
            var handler = new HttpClientHandler();
            
            // client.BaseAddress = new Uri(EngineUrl);

            if (!String.IsNullOrEmpty(EngineUsername))
            {
                this.CamundaClient = new CamundaClient(config, client, handler, EngineUsername, EnginePassword);
                // client.DefaultRequestHeaders.Add("Authorization", GetBasicAuthValue(EngineUsername, EnginePassword));
            }
            else
            {
                this.CamundaClient = new CamundaClient(config, client, handler);
            }
        }

        public void PushToSnackBar(string Message, SnackbarColor color)
        {
            snackbarStack.PushAsync(Message, color, options => {
                options.IntervalBeforeClose = intervalBeforeMsgClose;
            });
        }
    }
}
