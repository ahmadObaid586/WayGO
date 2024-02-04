using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Security.Policy;
using Newtonsoft.Json;
using System.Runtime.InteropServices.JavaScript;
using Newtonsoft.Json.Linq;
using WinGo;
using static System.Windows.Forms.AxHost;
using System.Data.Common;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;
//using System.Net.WebSockets;
using WebSocketSharp;
using WebSocketSharp.Net;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_project
{
    public class ResttHelper
    {
        public static String baseURL = "http://localhost:19991/company/";
        public static String TokenLogin;
      /*  public static void test_WS(String url)
        { 
            UriBuilder uriBuilder = new UriBuilder("ws://waygo-git-main-yaseralsamsamsyr.vercel.app/company/" + url);
            uriBuilder.Query = $"token={TokenLogin}";
            using (WebSocket webSocket = new WebSocket(uriBuilder.Uri.ToString())) 
            {
                webSocket.OnOpen += (sender, e) =>
                {
                    Console.WriteLine("WebSocket connection opened.");
                };

                webSocket.OnClose += (sender, e) =>
                {
                    if (e.Code == 1000)
                    {
                        MessageBox.Show("WebSocket connection closed gracefully.");
                    }
                    else
                    {
                        MessageBox.Show("WebSocket connection closed with error: " + e.Reason.ToString());
                    }
                };

                webSocket.OnError += (sender, e) =>
                {
                    MessageBox.Show("WebSocket error: " + e.Message);
                    if (e.Exception != null)
                    {
                        Console.WriteLine("Error Type: " + e.Exception.GetType().ToString());
                    }
                };

                webSocket.Connect();

            }
        }

        public static void WebSocket_OnMessage(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Data);
        }
      */
        public static async Task<JObject> GetAll(String URL) // get any file json 
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TokenLogin);
                    // System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                    //             SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    using (HttpResponseMessage res = await client.GetAsync(baseURL + URL))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String data = await content.ReadAsStringAsync();
                            var jsondata = (JObject)JsonConvert.DeserializeObject(data);
                            if (res.StatusCode.ToString() == "OK")
                            {
                                return jsondata;
                            }
                        }
                    }
                }
            }
            catch (Exception g) { MessageBox.Show("catch\n" + g.ToString()); }
            return null;
        }
        public static async Task<JObject> POST_Login(String URL, String inputJson) // to send json to server 
        {
            try
            {
                var stringContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {

                        System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                    SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    using (HttpResponseMessage res = await client.PostAsync(baseURL + URL, stringContent))
                    {
                        using (HttpContent content = res.Content)
                        {

                            String data = await content.ReadAsStringAsync();
                            var jsondata = (JObject)JsonConvert.DeserializeObject(data);
                            TokenLogin = jsondata["token"].Value<String>();
                            if (res.StatusCode.ToString() == "OK")
                            {
                                return jsondata;

                            }
                            else
                                return null;
                        }
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show("The error \n"+r.ToString());
            }
            return null;
        }
        public static async Task<bool> POST(String URL, String inputJson) // to send json to server 
        {
            try
            {
                var stringContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TokenLogin);
                    /*  System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;*/
                    using (HttpResponseMessage res = await client.PostAsync(baseURL + URL, stringContent))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String data = await content.ReadAsStringAsync();
                            var jsondata = (JObject)JsonConvert.DeserializeObject(data);
                            if (res.StatusCode.ToString() == "Created")
                            {
                                return true;

                            }
                            else
                                return false;
                        }
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }
            return false;
        }
        public static async Task<bool> PUT(String URL, String inputJson)    //// to updata data in server 
        {
            try
            {
                var stringContent = new StringContent(inputJson, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TokenLogin);
                    //System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                    //SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    using (HttpResponseMessage res = await client.PutAsync(baseURL + URL, stringContent))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String data = await content.ReadAsStringAsync();
                            var jsondata = (JObject)JsonConvert.DeserializeObject(data);
                            if (res.StatusCode != null)
                            {
                                return true;

                            }
                        }
                    }
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
            }
            return false;
        }
        public static async Task<bool> Delete(String URL, int id)     //// to delete trip or customer 
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TokenLogin);
                //  System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                //   SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + URL + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        String data = await content.ReadAsStringAsync();
                        var jsondata = (JObject)JsonConvert.DeserializeObject(data);
                        if (res.StatusCode.ToString() == "OK")
                        {
                            return true; }
                    }
                }
            }
            return false;
        }

        public static async Task<byte[]> Downloadpdf(String URL) 
        {
            using (HttpClient client = new HttpClient())
            {
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TokenLogin);
                    // System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 |
                    //             SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    using (HttpResponseMessage res = await client.GetAsync(baseURL+URL))
                    if (res.IsSuccessStatusCode)
                    {
                        return await res.Content.ReadAsByteArrayAsync();
                    }
                    return null;
                }

            }
            }
            
      /*  public static async Task ReceiveAndPrintJson(String URL)
        {
            try
            {
                using (var webSocket = new ClientWebSocket())
                {
                    Uri serverUri = new Uri("ws://localhost:19991/company/trip/getChear/9");
                    await webSocket.ConnectAsync(serverUri, CancellationToken.None);


                    byte[] buffer = new byte[1024 * 4]; // Adjust buffer size as needed
                    MemoryStream receivedData = new MemoryStream();

                    while (webSocket.State == WebSocketState.Open)
                    {
                        WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                        if (result.MessageType == WebSocketMessageType.Binary)
                        {
                            receivedData.Write(buffer, 0, result.Count);

                            if (result.EndOfMessage)
                            {
                                // JSON file received completely
                                MessageBox.Show(receivedData.ToString());
                                receivedData = new MemoryStream(); // Reset the stream for the next file
                            }
                        }
                        else if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "WebSocket closed", CancellationToken.None);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(($"Error in ReceiveAndPrintJson: {ex.Message}"));
            }
        }*/

    }
}