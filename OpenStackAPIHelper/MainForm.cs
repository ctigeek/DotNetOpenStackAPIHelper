using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;


namespace OpenStackAPIHelper
{
    public partial class MainForm : Form
    {
        //http://api.openstack.org/api-ref.html
        //http://docs.openstack.org/api/quick-start/content/

        private string IdentityUrl = "https://identity.api.rackspacecloud.com/v2.0/tokens";
        private string computeUrl = string.Empty;
        private Entities.Access Access;

        public MainForm()
        {
            InitializeComponent();
            this.tbServerDetails.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Servers
        private void bGetServers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                LoadAuth();
                var servers = GetServers();
                this.lbServers.Items.Clear();
                foreach (var server in servers.ServerList)
                {
                    this.lbServers.Items.Add(server);
                }
            }
            catch (System.Net.WebException webex)
            {
                this.tbServerDetails.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void lbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var server = (Entities.Server)this.lbServers.Items[lbServers.SelectedIndex];

                this.tbServerDetails.Text = string.Format("########## SERVER ###########\r\nName={0}\r\nID={1}\r\nLink={2}\r\n", server.Name, server.Id, server.Links[0].Href);
                if (!string.IsNullOrEmpty(server.DetailJson))
                {
                    this.tbServerDetails.Text += server.DetailJson;
                }
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
        }
        private void lbServers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                object obj = this.lbServers.SelectedItem;
                if (obj != null)
                {
                    var server = (Entities.Server)obj;
                    string result = GetServerDetail(server.Id);
                    server.DetailJson = FormatJson(result);
                    lbServers_SelectedIndexChanged(sender, e);
                }
            }
            catch (System.Net.WebException webex)
            {
                this.tbServerDetails.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void contextMenuServers_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.ClickedItem.Text);
                if (e.ClickedItem.Text == "Create Image")
                {
                    //CreateImageFromSelectedServer();
                }
                else if (e.ClickedItem.Text == "Delete")
                {

                }
                else if (e.ClickedItem.Text == "Reboot")
                {

                }
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
        }
        
        #endregion
        #region Images
        
        private void bRetrieveImages_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();

                LoadAuth();
                var images = GetImages();
                this.lbImages.Items.Clear();
                foreach (var image in images.ImageList)
                {
                    this.lbImages.Items.Add(image);
                }
            }
            catch (System.Net.WebException webex)
            {
                this.tbServerDetails.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var image = (Entities.ServerImage)this.lbImages.SelectedItem;

                this.tbServerDetails.Text = string.Format("*********** Image **********\r\nName={0}\r\nID={1}\r\nLink={2}\r\n", image.Name, image.Id, image.Links[0].Href);
                if (!string.IsNullOrEmpty(image.DetailJson))
                {
                    this.tbServerDetails.Text += image.DetailJson;
                }
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
        }
        private void lbImages_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                object obj = this.lbImages.SelectedItem;
                if (obj != null)
                {
                    var image = (Entities.ServerImage)obj;
                    string result = GetImageDetail(image.Id);
                    image.DetailJson = FormatJson(result);
                    lbImages_SelectedIndexChanged(sender, e);
                }
            }
            catch (System.Net.WebException webex)
            {
                this.tbServerDetails.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void contextMenuImages_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion
        #region GET tab
        private void tbUrl_DoubleClick(object sender, EventArgs e)
        {
            LoadAuth();
            this.tbGetUrl.Text = computeUrl;
        }

        private void bGetURL_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.tbGetUrl.Text.StartsWith(this.computeUrl))
                {
                    MessageBox.Show("URL must start with the Openstack endpoint. Double-click in the text box to set it.");
                    return;
                }
                string url = this.tbGetUrl.Text;
                var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);

                this.tbGetResults.Text = FormatJson(GetStringFromStream(response.GetResponseStream()));
            }
            catch (System.Net.WebException webex)
            {
                this.tbGetResults.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbGetResults.Text = ex.ToString();
            }
        }

        #endregion


        #region ServersAPI
        private Entities.Servers GetServers()
        {
            string url = computeUrl + "/servers";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            var responsestream = response.GetResponseStream();
            Entities.Servers servers = null;
            using (responsestream)
            {
                servers = DeserializeJson<Entities.Servers>(responsestream);
            }
            return servers;
        }
        private string GetServerDetail(string serverId)
        {
            string url = computeUrl + "/servers/" + serverId;
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        private void CreateImageFromSelectedServer()
        {
            object obj = this.lbServers.SelectedItem;
            if (obj != null)
            {
                var server = (Entities.Server)obj;
                var frmImage = new FrmCreateImage();
                frmImage.ServerName = server.Name;
                frmImage.ImageName = server.Name + "_NewImage";
                var result = frmImage.ShowDialog(this);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string url = computeUrl + "/servers/" + server.Id + "/action";
                    string json = "{\"createImage\":{\"name\":\"" + frmImage.ImageName + "\"}}";
                    var response = MakeRequest(json, url, "POST", this.Access.Token.tokenString);
                    if (response.ContentLength > 0)
                    {
                        MessageBox.Show(GetStringFromStream(response.GetResponseStream()));
                    }
                }
            }
        }
        #endregion

        private string GetLimits()
        {
            string url = computeUrl + "/limits";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        #region ImagesAPI
        private Entities.Images GetImages()
        {
            string url = computeUrl + "/images";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            Entities.Images images = null;
            using (var responseStream = response.GetResponseStream())
            {
                images = DeserializeJson<Entities.Images>(responseStream);
            }
            return images;
        }
        private string GetImageDetail(string imageId)
        {
            string url = computeUrl + "/images/" + imageId;
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        #endregion
        #region AuthAPI
        private void LoadAuth()
        {
            if (Access == null)
            {
                var id = System.Configuration.ConfigurationManager.AppSettings["Id"];
                var pass = System.Configuration.ConfigurationManager.AppSettings["Pass"];
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
                {
                    var idpass = new IDandPass();
                    var result = idpass.ShowDialog(this);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        id = idpass.Id;
                        pass = idpass.Password;
                    }
                    else
                    {
                        return;
                    }
                }
                this.Access = GetAuth(id, pass);
                if (this.Access == null)
                {
                    throw new ArgumentNullException("Authentication failed.");
                }
                this.computeUrl = this.Access.ServiceCatalog.FirstOrDefault(sc => sc.Type == "compute").Endpoints[0].PublicUrl;
                this.tbGetUrl.Text = this.computeUrl;
            }
        }

        private Entities.Access GetAuth(string userId, string password)
        {
            try
            {
                var identityUrl = System.Configuration.ConfigurationManager.AppSettings["IdentityUrl"];
                if (!string.IsNullOrEmpty(identityUrl))
                {
                    this.IdentityUrl = identityUrl;
                }
                ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
                string json = "{\"auth\":{\"passwordCredentials\":{\"username\":\"" + userId + "\",\"password\":\"" + password + "\"},\"tenantId\":\"\"}}";
                var response = MakeRequest(json, identityUrl, "POST");
                var responsestream = response.GetResponseStream();
                Entities.AccessWrapper access = null;
                using (responsestream)
                {
                    access = DeserializeJson<Entities.AccessWrapper>(responsestream);
                    responsestream.Close();
                }
                return access.Access;
            }
            catch (System.Net.WebException webex)
            {
                MessageBox.Show(webex.ToString());
                if (webex.Response.ContentLength > 0)
                {
                    MessageBox.Show(GetStringFromStream(webex.Response.GetResponseStream()));
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
            return null;
        }
        #endregion

        private HttpWebResponse MakeRequest(string jsonBody, string url, string method, string token = null)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = method;
            request.Accept = "*/*";
            request.UserAgent = "OpenstackTest";
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Add("X-Auth-Token", token);
            }

            if (!string.IsNullOrEmpty(jsonBody))
            {
                request.ContentType = "application/json";
                var bytes = System.Text.Encoding.UTF8.GetBytes(jsonBody);
                request.ContentLength = bytes.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            var response = (HttpWebResponse)request.GetResponse();
            return response;
        }

        private string GetStringFromStream(System.IO.Stream stream)
        {
            using (stream)
            {
                using (var sr = new System.IO.StreamReader(stream))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        private T DeserializeJson<T>(System.IO.Stream stream)
        {
            var serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));
            var graph = serializer.ReadObject(stream);
            return (T)graph;
        }

        private string ResponseDebugString(System.Net.HttpWebResponse response)
        {
            StringBuilder sb = new StringBuilder();
            if (response != null)
            {
                sb.AppendFormat("URI = {0}\r\n", response.ResponseUri.ToString());
                sb.AppendFormat("Response Code = {0}", response.StatusCode.ToString());
                sb.Append("Headers:\r\n");
                foreach (var key in response.Headers.AllKeys)
                {
                    sb.AppendFormat("{0} = {1}\r\n", key, response.Headers[key]);
                }
                if (response.ContentLength > 0)
                {
                    sb.Append("Body:\r\n");
                    if (response.ContentType.ToLower().Contains("json"))
                    {
                        sb.Append(FormatJson(
                                        GetStringFromStream(
                                            response.GetResponseStream())));
                    }
                    else
                    {
                        sb.Append(GetStringFromStream(response.GetResponseStream()));
                    }
                }
                else
                {
                    sb.Append("No body.");
                }
            }
            return sb.ToString();
        }

        private string FormatJson(string raw)
        {
            //yes, this is very hacky... but it works fairly well.
            bool insideQuote = false;
            int spaces = 3;
            StringBuilder sb = new StringBuilder();
            int tabcounter = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                char chr = raw[i];
                if (chr == '"')
                {
                    insideQuote = !insideQuote;
                }
                if (insideQuote)
                {
                    sb.Append(chr);
                }
                else
                {
                    if (chr == '{')
                    {
                        if (i + 1 < raw.Length && raw[i + 1] == '}')
                        {   //special case for empty brackets.
                            sb.AppendFormat("{0}{1}", chr, raw[i + 1]);
                            i++;
                        }
                        else
                        {
                            tabcounter++;
                            sb.AppendFormat("{0}\r\n{1}", chr, new string(' ', tabcounter * spaces));
                        }
                    }
                    else if (chr == '[')  //yes, I know this is identical to the above if, but I keep toying with doing different things with square vs squigly.
                    {
                        if (i + 1 < raw.Length && raw[i + 1] == ']')
                        {   //special case for empty brackets.
                            sb.AppendFormat("{0}{1}", chr, raw[i + 1]);
                            i++;
                        }
                        else
                        {
                            tabcounter++;
                            sb.AppendFormat("{0}\r\n{1}", chr, new string(' ', tabcounter * spaces));
                        }
                    }
                    else if (chr == '}' || chr == ']')
                    {
                        tabcounter--;
                        if (i + 1 < raw.Length && raw[i + 1] == ',')
                        {
                            sb.AppendFormat("\r\n{0}{1}", new string(' ', tabcounter * spaces), chr);
                        }
                        else if (i + 1 < raw.Length && (raw[i + 1] == '}' || raw[i + 1] == ']'))
                        {
                            sb.AppendFormat("\r\n{0}{1}", new string(' ', tabcounter * spaces), chr);
                        }
                        else
                        {
                            sb.AppendFormat("\r\n{0}{1}\r\n{2}", new string(' ', tabcounter * spaces), chr, new string(' ', tabcounter * spaces));
                        }
                    }
                    else if (chr == ',')
                    {
                        sb.AppendFormat("{0}\r\n{1}", chr, new string(' ', tabcounter * spaces));
                    }
                    else
                    {
                        sb.Append(chr);
                    }
                }
            }
            return sb.ToString();
        }

        
    }
}
