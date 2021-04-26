using System;
using System.Collections.Generic;
using System.Xml;
using System.Net;
using System.IO;



namespace Chatbot
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static string soapResult;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1.callapi();
            System.Diagnostics.Debug.WriteLine("Inside function");
            Label1.Text = soapResult;

        }

        private static void callapi()
        {
            var _url = "http://korbsbvm33:8080/arsys/services/ARService?server=korbsbvm33&webService=SMTbot_Ws";
            var _action = "add";
            Console.Write("Inside function");
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
           
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                System.Diagnostics.Debug.WriteLine(soapResult);
               
            }
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:urn=""urn:SMTbot_Ws""><soapenv:Header><urn:AuthenticationInfo><urn:userName>AdminShubhanshu</urn:userName><urn:password>shub@1998</urn:password><!--Optional:--><urn:authentication>?</urn:authentication><!--Optional:--><urn:locale>?</urn:locale><!--Optional:--><urn:timeZone>?</urn:timeZone></urn:AuthenticationInfo></soapenv:Header><soapenv:Body><urn:New_GetList_Operation_0><urn:Qualification>1=1</urn:Qualification><urn:startRecord>?</urn:startRecord><urn:maxLimit>?</urn:maxLimit></urn:New_GetList_Operation_0></soapenv:Body></soapenv:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
  }
