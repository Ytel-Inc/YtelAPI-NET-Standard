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
    public partial class UsageController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static UsageController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static UsageController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new UsageController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests.
        /// </summary>
        /// <param name="productCode">Optional parameter: Filter usage results by product type.</param>
        /// <param name="startDate">Optional parameter: Filter usage objects by start date.</param>
        /// <param name="endDate">Optional parameter: Filter usage objects by end date.</param>
        /// <param name="includeSubAccounts">Optional parameter: Will include all subaccount usage data</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListUsage(
                Models.ProductCodeEnum? productCode = null,
                string startDate = null,
                string endDate = null,
                string includeSubAccounts = null)
        {
            Task<string> t = CreateListUsageAsync(productCode, startDate, endDate, includeSubAccounts);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests.
        /// </summary>
        /// <param name="productCode">Optional parameter: Filter usage results by product type.</param>
        /// <param name="startDate">Optional parameter: Filter usage objects by start date.</param>
        /// <param name="endDate">Optional parameter: Filter usage objects by end date.</param>
        /// <param name="includeSubAccounts">Optional parameter: Will include all subaccount usage data</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListUsageAsync(
                Models.ProductCodeEnum? productCode = null,
                string startDate = null,
                string endDate = null,
                string includeSubAccounts = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/usage/listusage.json");


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
                new KeyValuePair<string, object>( "ProductCode", (productCode.HasValue) ? (int?)productCode.Value : null ),
                new KeyValuePair<string, object>( "startDate", startDate ),
                new KeyValuePair<string, object>( "endDate", endDate ),
                new KeyValuePair<string, object>( "IncludeSubAccounts", includeSubAccounts )
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