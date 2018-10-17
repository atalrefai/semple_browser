using System;
using System.IO;
using System.Net;
using System.Text;

namespace restClient_0
{

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RESTClient
    {
        //to read web file to end
        public string endPoint { get; set; }
        // to use enum to get data
        public httpVerb httpMethod { get; set; }

        //this constracter to make prevous variable working when start
        public RESTClient()
        {
            endPoint = "";
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {

            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                string MessageText = "";
                if (ex.Message.Contains("400"))
                {
                    MessageText = "400 Bad Request \n";
                }
                else if (ex.Message.Contains("403"))
                {
                    MessageText = "403 Forbidden  \n";
                }
                else if (ex.Message.Contains("404"))
                {
                    MessageText = "404 Not Found \n";
                }

                else if (ex.Message.Contains("401"))
                {
                    MessageText = "401 Unauthorized \n";
                }

                else if (ex.Message.Contains("408"))
                {
                    MessageText = "408 Request Timeout \n";
                }

                else
                {
                    MessageText = ex.Message.ToString();
                }
                strResponseValue = "Error: " + MessageText;
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return strResponseValue;
        }
    }
}
