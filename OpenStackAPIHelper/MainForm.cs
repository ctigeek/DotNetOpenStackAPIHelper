﻿using System;
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
        private string[] computeUrl;
        private Entities.Access Access;

        public MainForm()
        {
            InitializeComponent();
            this.tbServerDetails.Text = string.Empty;
        }

        private void bAuth_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                this.LoadAuth();
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
            this.Cursor = Cursors.Default;
        }
        #region Servers
        private void bGetServers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                var servers = GetAllServers();
                this.lbServers.Items.Clear();
                foreach (var server in servers.OrderBy(s=>s.Name))
                {
                    this.lbServers.Items.Add(server);
                }
                if (this.lbServers.Items.Count > 0)
                {
                    this.lbServers.SelectedIndex = 0;
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
                var server = (Entities.Server)this.lbServers.SelectedItem;

                this.tbServerDetails.Text = string.Format("########## SERVER ###########\r\nName={0}\r\nID={1}\r\nLink={2}\r\n", server.Name, server.Id, server.SelfLink);
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
                    string result = GetServerDetail(server);
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
                var server = (Entities.Server)this.lbServers.SelectedItem;
                if (server == null || server.SelfLink == null) return;
                switch (e.ClickedItem.Text)
                {
                    case "Create Image":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"createImage\":{\"name\":\"IMAGE_NAME_HERE\",\"metadata\":{\"Description\":\"Image of web server.\"}}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Delete":
                        this.tbDeleteUrl.Text = server.SelfLink;
                        this.tabControl1.SelectedTab = this.tabDelete;
                        this.tbDeleteUrl.Focus();
                        break;
                    case "Reboot":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"reboot\":{\"type\":\"SOFT\"}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Change Password":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"changePassword\":{\"adminPass\":\"ENTER_PASSWORD_HERE___NO_THIS_ISNT_A_GOOD_PASSWORD___DONT_USE_IT\"}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Change Metadata":
                        this.tbPostUrl.Text = server.SelfLink + "/metadata";
                        this.tbPostBody.Text = FormatJson("{\"metadata\":{\"SOME_LABEL\":\"SOME_VALUE\"}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Resize":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"resize\":{\"flavorRef\":\"ENTER_FLAVOR_REF_NUMBER\"}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Confirm Resize":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"confirmResize\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Revert Resize":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"revertResize\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Pause":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"pause\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Unpause":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"unpause\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Suspend":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"suspend\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Resume":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"resume\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Migrate":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"migrate\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Reset Network":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"resetNetwork\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Inject Network":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"injectNetworkInfo\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Lock":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"lock\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Unlock":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"unlock\":null}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Create Backup":
                        this.tbPostUrl.Text = server.SelfLink + "/action";
                        this.tbPostBody.Text = FormatJson("{\"createBackup\":{\"name\":\"ENTER_BACKUP_NAME\", \"backup_type\":\"daily\", \"rotation\":1}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
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
                var images = GetAllImages();
                this.lbImages.Items.Clear();
                foreach (var image in images.OrderBy(i=>i.Region).ThenBy(i=>i.Name))
                {
                    this.lbImages.Items.Add(image);
                }
                if (this.lbImages.Items.Count > 0)
                {
                    this.lbImages.SelectedIndex = 0;
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

                this.tbServerDetails.Text = string.Format("*********** Image **********\r\nName={0}\r\nID={1}\r\nLink={2}\r\n", image.Name, image.Id, image.SelfLink);
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
                    string result = GetImageDetail(image);
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
            try
            {
                var image = (Entities.ServerImage)this.lbImages.SelectedItem;
                
                if (image == null || image.SelfLink == null) return;
                switch (e.ClickedItem.Text)
                {
                    case "Delete":
                        this.tbDeleteUrl.Text = image.SelfLink;
                        this.tabControl1.SelectedTab = this.tabDelete;
                        this.tbDeleteUrl.Focus();
                        break;
                    case "Change Metadata":
                        this.tbPostUrl.Text = image.SelfLink + "/metadata";
                        this.tbPostBody.Text = FormatJson("{\"metadata\":{\"SOME_LABEL\":\"SOME_VALUE\"}}");
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostUrl.Focus();
                        break;
                    case "Create Server using...":
                        this.tbPostUrl.Text = image.SelfLink + "/action";
                        this.tabControl1.SelectedTab = this.tabPost;
                        this.tbPostBody.Text = " not implemented yet. Sorry.  :( ";
                        break;
                }
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
        }
        #endregion
        #region Flavors
        private void bRetrieveFlavors_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                var flavors = GetAllFlavors();
                this.lbFlavors.Items.Clear();
                foreach (var flavor in flavors.OrderBy(f=>f.Region).ThenBy(f=>f.Name))
                {
                    this.lbFlavors.Items.Add(flavor);
                }
                if (this.lbFlavors.Items.Count > 0)
                {
                    this.lbFlavors.SelectedIndex = 0;
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
        private void lbFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var flavor = (Entities.ServerImage)this.lbFlavors.SelectedItem;

                this.tbServerDetails.Text = string.Format("^^^^^^^^^ Flavor ^^^^^^^^^^^^\r\nName={0}\r\nID={1}\r\nLink={2}\r\n", flavor.Name, flavor.Id, flavor.SelfLink);
                if (!string.IsNullOrEmpty(flavor.DetailJson))
                {
                    this.tbServerDetails.Text += flavor.DetailJson;
                }
            }
            catch (Exception ex)
            {
                this.tbServerDetails.Text = ex.ToString();
            }
        }
        private void lbFlavors_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Windows.Forms.Application.DoEvents();
                object obj = this.lbFlavors.SelectedItem;
                if (obj != null)
                {
                    var flavor = (Entities.ServerImage)obj;
                    string result = GetImageDetail(flavor);
                    flavor.DetailJson = FormatJson(result);
                    lbFlavors_SelectedIndexChanged(sender, e);
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
        #endregion
        #region GET tab
        private void tbUrl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                LoadAuth();
            }
            catch (Exception ex)
            {
                this.tbGetResults.Text = ex.ToString();
            }
        }
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (ToolStripMenuItem)sender;
                this.tbGetUrl.Text = computeUrl + "/" + item.Text;
                toolStripSplitButtonGET_ButtonClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void toolStripSplitButtonGET_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                LoadAuth();
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
        #region POST
        private void bPost_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAuth();
                var response = MakeRequest(tbPostBody.Text, tbPostUrl.Text, "POST", Access.Token.tokenString);
                tbPostResults.Text = ResponseDebugString(response);
            }
            catch (System.Net.WebException webex)
            {
                this.tbPostResults.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbPostResults.Text = ex.ToString();
            }
        }
        #endregion
        #region PUT
        private void bPut_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAuth();
                var response = MakeRequest(tbPutBody.Text, tbPutUrl.Text, "POST", Access.Token.tokenString);
                tbPutResults.Text = ResponseDebugString(response);
            }
            catch (System.Net.WebException webex)
            {
                this.tbPutResults.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbPutResults.Text = ex.ToString();
            }
        }

        #endregion
        #region Delete
        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAuth();
                var response = MakeRequest(null, tbDeleteUrl.Text, "POST", Access.Token.tokenString);
                tbDeleteResults.Text = ResponseDebugString(response);
            }
            catch (System.Net.WebException webex)
            {
                this.tbDeleteResults.Text = webex.ToString() + "\r\n" + ResponseDebugString((HttpWebResponse)webex.Response);
            }
            catch (Exception ex)
            {
                this.tbDeleteResults.Text = ex.ToString();
            }
        }
        #endregion

        #region ServersAPI
        private IEnumerable<Entities.Server> GetAllServers()
        {
            foreach (var endpoint in this.computeUrl)
            {
                foreach (var server in GetServers(endpoint).ServerList)
                {
                    yield return server;
                }
            }
        }

        private Entities.Servers GetServers(string baseUrl)
        {
            string url = baseUrl + "/servers";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            var responsestream = response.GetResponseStream();
            Entities.Servers servers = null;
            using (responsestream)
            {
                servers = DeserializeJson<Entities.Servers>(responsestream);
            }
            return servers;
        }
        private string GetServerDetail(Entities.Server server)
        {
            var response = MakeRequest(null, server.SelfLink, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        //private void CreateImageFromSelectedServer()
        //{
        //    object obj = this.lbServers.SelectedItem;
        //    if (obj != null)
        //    {
        //        var server = (Entities.Server)obj;
        //        var frmImage = new FrmCreateImage();
        //        frmImage.ServerName = server.Name;
        //        frmImage.ImageName = server.Name + "_NewImage";
        //        var result = frmImage.ShowDialog(this);
        //        if (result == System.Windows.Forms.DialogResult.OK)
        //        {
        //            //string url = computeUrl + "/servers/" + server.Id + "/action";
        //            string json = "{\"createImage\":{\"name\":\"" + frmImage.ImageName + "\"}}";
        //            var response = MakeRequest(json, url, "POST", this.Access.Token.tokenString);
        //            if (response.ContentLength > 0)
        //            {
        //                MessageBox.Show(GetStringFromStream(response.GetResponseStream()));
        //            }
        //        }
        //    }
        //}
        #endregion

        private string GetLimits()
        {
            string url = computeUrl + "/limits";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        #region ImagesAPI
        private IEnumerable<Entities.ServerImage> GetAllImages()
        {
            foreach (string endpoint in this.computeUrl)
            {
                foreach (var image in GetImages(endpoint).ImageList)
                {
                    yield return image;
                }
            }
        }
        private Entities.Images GetImages(string baseUrl)
        {
            string url = baseUrl + "/images";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            Entities.Images images = null;
            using (var responseStream = response.GetResponseStream())
            {
                images = DeserializeJson<Entities.Images>(responseStream);
            }
            return images;
        }
        private string GetImageDetail(Entities.ServerImage image)
        {
            var response = MakeRequest(null, image.SelfLink, "GET", this.Access.Token.tokenString);
            string result = GetStringFromStream(response.GetResponseStream());
            return result;
        }
        #endregion
        #region Flavors API
        private IEnumerable<Entities.ServerImage> GetAllFlavors()
        {
            foreach (string endpoint in this.computeUrl)
            {
                foreach (var flavor in GetFlavors(endpoint).FlavorList)
                {
                    yield return flavor;
                }
            }
        }
        private Entities.Flavors GetFlavors(string baseUrl)
        {
            string url = baseUrl + "/flavors";
            var response = MakeRequest(null, url, "GET", this.Access.Token.tokenString);
            Entities.Flavors flavors = null;
            using (var responseStream = response.GetResponseStream())
            {
                flavors = DeserializeJson<Entities.Flavors>(responseStream);
            }
            return flavors;
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
                this.computeUrl = GetComputeEndpoints().ToArray();
                this.bGetServers.Enabled = true;
                this.bRetrieveImages.Enabled = true;
                this.bRetrieveFlavors.Enabled = true;
                this.toolStripSplitButtonGET.Enabled = true;
                this.bDelete.Enabled = true;
                this.bPut.Enabled = true;
                this.bPost.Enabled = true;
            }
            this.tbServerDetails.Text = Access.ToString();
        }

        private IEnumerable<string> GetComputeEndpoints()
        {
            foreach (var catalog in this.Access.ServiceCatalog.Where(sc => sc.Type == "compute"))
            {
                foreach (var endpoint in catalog.Endpoints)
                {
                    yield return endpoint.PublicUrl;
                }
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
                sb.AppendFormat("Response Code = {0}-{1}\r\n", ((int)response.StatusCode).ToString(), response.StatusCode.ToString());
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
