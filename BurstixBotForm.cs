using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Net.Http;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using Newtonsoft.Json.Linq;
using TwitchLib.Client.Events;
using TwitchLib.Api;
using NHttp;
using TwitchLib.Communication.Events;
using System.Configuration;

namespace BurstixBot
{
    public partial class BurstixBotForm : Form
    {

        private HttpServer WebServer;
        private readonly string RedirectUrl = "http://localhost";
        private readonly string ClientId = ConfigurationManager.AppSettings["clientid"];
        private readonly string ClientSecret = ConfigurationManager.AppSettings["clientsecret"];
        private readonly List<string> Scopes = new List<string> { "chat:read", "chat:edit" };

        private TwitchClient OwnerOfChannelConnection;
        private TwitchAPI twitchAPI;

        private string CachedOwnerOfChannelAccessToken = "needsaccesstoken";
        private string TwitchChannelName;
        private string TwitchChannelId;

        string icaoFromVar;
        string icaoToVar;

        Dictionary<string, string> CommandsStaticResponses = new Dictionary<string, string>
        {
            { "route", "Displays the route that is currently being flown." }
        };

        public BurstixBotForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void initialiseBotButton_Click(object sender, EventArgs e)
        {
            initializeWebServer();

            var authUrl = $"https://id.twitch.tv/oauth2/authorize?response_type=code&client_id={ClientId}&redirect_uri={RedirectUrl}&scope={String.Join("+", Scopes)}&state=frontend|NWt2SFl0OVplN0FKMUw5NFc5eE1aZz09&force_verify=true";
            Process.Start(authUrl);
        }

        void initializeWebServer()
        {
            WebServer = new HttpServer();
            WebServer.EndPoint = new IPEndPoint(IPAddress.Loopback, 80);

            WebServer.RequestReceived += async (s, e) =>
            {
                using (var writer = new StreamWriter(e.Response.OutputStream))
                {
                    if (e.Request.QueryString.AllKeys.Any("code".Contains))
                    {
                        var code = e.Request.QueryString["code"];
                        var ownerOfChannelAccessAndRefresh = await getAccessAndRefreshTokens(code);
                        CachedOwnerOfChannelAccessToken = ownerOfChannelAccessAndRefresh.Item1;
                        SetNameAndIdByOauthedUser(CachedOwnerOfChannelAccessToken).Wait();
                        InitializeOwnerOfChannelConnection(TwitchChannelName, CachedOwnerOfChannelAccessToken);
                        InitializeTwitchAPI(CachedOwnerOfChannelAccessToken);
                    }
                }
            };

            WebServer.Start();
            Console.Write($"Web server started on: {WebServer.EndPoint}");
        }

        void InitializeTwitchAPI(string accessToken)
        {
            twitchAPI = new TwitchAPI();
            twitchAPI.Settings.ClientId = ClientId;
            twitchAPI.Settings.AccessToken = accessToken;
        }

        void InitializeOwnerOfChannelConnection(string username, string accessToken)
        {
            OwnerOfChannelConnection = new TwitchClient();
            OwnerOfChannelConnection.Initialize(new ConnectionCredentials(username, accessToken), TwitchChannelName);

            OwnerOfChannelConnection.OnConnected += Client_OnConnected;
            OwnerOfChannelConnection.OnDisconnected += OwnerOfChannelConnection_OnDisconnected;
            OwnerOfChannelConnection.OnChatCommandReceived += Bot_OnChatCommandReceived;

            OwnerOfChannelConnection.Connect();
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Log($"User {e.BotUsername} connected (bot access)!");
        }

        private void OwnerOfChannelConnection_OnDisconnected(object sender, OnDisconnectedEventArgs e)
        {
            Log($"OnDisconnected event");
        }

        private void OwnerOfChannelConnection_OnLog(object sender, OnLogArgs e)
        {
            Log($"OnLog: {e.Data}");
        }

        private void Bot_OnChatCommandReceived(object sender, OnChatCommandReceivedArgs e)
        {
            string commandText = e.Command.CommandText.ToLower();

            if (commandText.Equals("route", StringComparison.OrdinalIgnoreCase))
            {
                OwnerOfChannelConnection.SendMessage(TwitchChannelName, $"We're flying from {icaoFromVar} to {icaoToVar}!");
            }

            if (CommandsStaticResponses.ContainsKey(commandText))
            {
                OwnerOfChannelConnection.SendMessage(TwitchChannelName, CommandsStaticResponses[commandText]);
            }
        }

        private void Log(string printMessage)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                formLogBox.Text += printMessage + "\n";
            }));
            Console.WriteLine(printMessage);
        }

        async Task SetNameAndIdByOauthedUser(string accessToken)
        {
            var api = new TwitchLib.Api.TwitchAPI();
            api.Settings.ClientId = ClientId;
            api.Settings.AccessToken = accessToken;

            var oautheduser = await api.Helix.Users.GetUsersAsync();
            TwitchChannelId = oautheduser.Users[0].Id;
            TwitchChannelName = oautheduser.Users[0].Login;
        }

        async Task<Tuple<string, string>> getAccessAndRefreshTokens(string code)
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "client_id", ClientId },
                { "client_secret", ClientSecret },
                { "code", code },
                { "grant_type", "authorization_code" },
                { "redirect_uri", RedirectUrl }
            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://id.twitch.tv/oauth2/token", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(responseString);
            return new Tuple<string, string>(json["access_token"].ToString(), json["refresh_token"].ToString());
        }

        private void BurstixBotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OwnerOfChannelConnection != null)
            {
                OwnerOfChannelConnection.Disconnect();
            }

            if (WebServer != null)
            {
                WebServer.Stop();
                WebServer.Dispose();
            }
        }

        private void submitICAO_Click(object sender, EventArgs e)
        {
            icaoFromVar = icaoFrom.Text;
            icaoToVar = icaoTo.Text;
            Log($"Route set as {icaoFromVar} to {icaoToVar}");
        }
    }
}
