/*
 * YtelAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities;
using YtelAPI.Standard.Http.Request;
using YtelAPI.Standard.Http.Response;
using YtelAPI.Standard.Http.Client;
using YtelAPI.Standard.Exceptions;

namespace YtelAPI.Standard.Controllers
{
    public partial class DedicatedShortCodeController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DedicatedShortCodeController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DedicatedShortCodeController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DedicatedShortCodeController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Update a dedicated shortcode.
        /// </summary>
        /// <param name="shortcode">Required parameter: List of valid dedicated shortcode to your Ytel account.</param>
        /// <param name="friendlyName">Optional parameter: User generated name of the dedicated shortcode.</param>
        /// <param name="callbackMethod">Optional parameter: Specifies the HTTP method used to request the required StatusCallBackUrl once call connects.</param>
        /// <param name="callbackUrl">Optional parameter: URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished.</param>
        /// <param name="fallbackMethod">Optional parameter: Specifies the HTTP method used to request the required FallbackUrl once call connects.</param>
        /// <param name="fallbackUrl">Optional parameter: URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST.</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateShortcode(
                string shortcode,
                string friendlyName = null,
                string callbackMethod = null,
                string callbackUrl = null,
                string fallbackMethod = null,
                string fallbackUrl = null)
        {
            Task<string> t = UpdateShortcodeAsync(shortcode, friendlyName, callbackMethod, callbackUrl, fallbackMethod, fallbackUrl);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a dedicated shortcode.
        /// </summary>
        /// <param name="shortcode">Required parameter: List of valid dedicated shortcode to your Ytel account.</param>
        /// <param name="friendlyName">Optional parameter: User generated name of the dedicated shortcode.</param>
        /// <param name="callbackMethod">Optional parameter: Specifies the HTTP method used to request the required StatusCallBackUrl once call connects.</param>
        /// <param name="callbackUrl">Optional parameter: URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished.</param>
        /// <param name="fallbackMethod">Optional parameter: Specifies the HTTP method used to request the required FallbackUrl once call connects.</param>
        /// <param name="fallbackUrl">Optional parameter: URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateShortcodeAsync(
                string shortcode,
                string friendlyName = null,
                string callbackMethod = null,
                string callbackUrl = null,
                string fallbackMethod = null,
                string fallbackUrl = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/updateshortcode.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Shortcode", shortcode ),
                new KeyValuePair<string, object>( "FriendlyName", friendlyName ),
                new KeyValuePair<string, object>( "CallbackMethod", callbackMethod ),
                new KeyValuePair<string, object>( "CallbackUrl", callbackUrl ),
                new KeyValuePair<string, object>( "FallbackMethod", fallbackMethod ),
                new KeyValuePair<string, object>( "FallbackUrl", fallbackUrl )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of Short Code assignment associated with your Ytel account.
        /// </summary>
        /// <param name="shortcode">Optional parameter: Only list Short Code Assignment sent from this Short Code</param>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: The count of objects to return per page.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListShortcodes(string shortcode = null, string page = null, string pagesize = null)
        {
            Task<string> t = CreateListShortcodesAsync(shortcode, page, pagesize);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of Short Code assignment associated with your Ytel account.
        /// </summary>
        /// <param name="shortcode">Optional parameter: Only list Short Code Assignment sent from this Short Code</param>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: The count of objects to return per page.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListShortcodesAsync(string shortcode = null, string page = null, string pagesize = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/listshortcode.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Shortcode", shortcode ),
                new KeyValuePair<string, object>( "page", page ),
                new KeyValuePair<string, object>( "pagesize", pagesize )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrive a list of inbound Sms Short Code messages associated with your Ytel account.
        /// </summary>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: Only list SMS messages sent from this number</param>
        /// <param name="shortcode">Optional parameter: Only list SMS messages sent to Shortcode</param>
        /// <param name="datecreated">Optional parameter: Only list SMS messages sent in the specified date MAKE REQUEST</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListInboundSMS(
                int? page = null,
                int? pagesize = null,
                string mfrom = null,
                string shortcode = null,
                string datecreated = null)
        {
            Task<string> t = CreateListInboundSMSAsync(page, pagesize, mfrom, shortcode, datecreated);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrive a list of inbound Sms Short Code messages associated with your Ytel account.
        /// </summary>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: Number of individual resources listed in the response per page</param>
        /// <param name="mfrom">Optional parameter: Only list SMS messages sent from this number</param>
        /// <param name="shortcode">Optional parameter: Only list SMS messages sent to Shortcode</param>
        /// <param name="datecreated">Optional parameter: Only list SMS messages sent in the specified date MAKE REQUEST</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListInboundSMSAsync(
                int? page = null,
                int? pagesize = null,
                string mfrom = null,
                string shortcode = null,
                string datecreated = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/getinboundsms.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "page", page ),
                new KeyValuePair<string, object>( "pagesize", pagesize ),
                new KeyValuePair<string, object>( "From", mfrom ),
                new KeyValuePair<string, object>( "Shortcode", shortcode ),
                new KeyValuePair<string, object>( "Datecreated", datecreated )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a single Short Code object by its shortcode assignment.
        /// </summary>
        /// <param name="shortcode">Required parameter: List of valid Dedicated Short Code to your Ytel account</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewSMS(string shortcode)
        {
            Task<string> t = CreateViewSMSAsync(shortcode);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a single Short Code object by its shortcode assignment.
        /// </summary>
        /// <param name="shortcode">Required parameter: List of valid Dedicated Short Code to your Ytel account</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewSMSAsync(string shortcode)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/viewshortcode.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Shortcode", shortcode )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of Short Code messages.
        /// </summary>
        /// <param name="shortcode">Optional parameter: Only list messages sent from this Short Code</param>
        /// <param name="to">Optional parameter: Only list messages sent to this number</param>
        /// <param name="dateSent">Optional parameter: Only list messages sent with the specified date</param>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pageSize">Optional parameter: The count of objects to return per page.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListSMS(
                string shortcode = null,
                string to = null,
                string dateSent = null,
                int? page = null,
                int? pageSize = null)
        {
            Task<string> t = CreateListSMSAsync(shortcode, to, dateSent, page, pageSize);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of Short Code messages.
        /// </summary>
        /// <param name="shortcode">Optional parameter: Only list messages sent from this Short Code</param>
        /// <param name="to">Optional parameter: Only list messages sent to this number</param>
        /// <param name="dateSent">Optional parameter: Only list messages sent with the specified date</param>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pageSize">Optional parameter: The count of objects to return per page.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListSMSAsync(
                string shortcode = null,
                string to = null,
                string dateSent = null,
                int? page = null,
                int? pageSize = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/listsms.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Shortcode", shortcode ),
                new KeyValuePair<string, object>( "To", to ),
                new KeyValuePair<string, object>( "DateSent", dateSent ),
                new KeyValuePair<string, object>( "Page", page ),
                new KeyValuePair<string, object>( "PageSize", pageSize )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Send Dedicated Shortcode
        /// </summary>
        /// <param name="shortcode">Required parameter: Your dedicated shortcode</param>
        /// <param name="to">Required parameter: The number to send your SMS to</param>
        /// <param name="body">Required parameter: The body of your message</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST</param>
        /// <param name="messagestatuscallback">Optional parameter: URL that can be requested to receive notification when Short Code message was sent.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateSendSMS(
                int shortcode,
                double to,
                string body,
                string method = null,
                string messagestatuscallback = null)
        {
            Task<string> t = CreateSendSMSAsync(shortcode, to, body, method, messagestatuscallback);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Dedicated Shortcode
        /// </summary>
        /// <param name="shortcode">Required parameter: Your dedicated shortcode</param>
        /// <param name="to">Required parameter: The number to send your SMS to</param>
        /// <param name="body">Required parameter: The body of your message</param>
        /// <param name="method">Optional parameter: Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST</param>
        /// <param name="messagestatuscallback">Optional parameter: URL that can be requested to receive notification when Short Code message was sent.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateSendSMSAsync(
                int shortcode,
                double to,
                string body,
                string method = null,
                string messagestatuscallback = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/dedicatedshortcode/sendsms.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "shortcode", shortcode ),
                new KeyValuePair<string, object>( "to", to ),
                new KeyValuePair<string, object>( "body", body ),
                new KeyValuePair<string, object>( "method", method ),
                new KeyValuePair<string, object>( "messagestatuscallback", messagestatuscallback )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// View a single Sms Short Code message.
        /// </summary>
        /// <param name="messageSid">Required parameter: The unique identifier for the sms resource</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewSMS(string messageSid)
        {
            Task<string> t = CreateViewSMSAsync(messageSid);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View a single Sms Short Code message.
        /// </summary>
        /// <param name="messageSid">Required parameter: The unique identifier for the sms resource</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewSMSAsync(string messageSid)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/shortcode/viewsms.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "MessageSid", messageSid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 