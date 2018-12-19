/*
 * YtelAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities; 
using YtelAPI.Standard.Http.Client;
using YtelAPI.Standard.Http.Response;
using YtelAPI.Tests.Helpers;
using NUnit.Framework;
using YtelAPI.Standard;
using YtelAPI.Standard.Controllers;
using YtelAPI.Standard.Exceptions;

namespace YtelAPI.Tests
{
    [TestFixture]
    public class UsageControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static UsageController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Usage;
        }

        /// <summary>
        /// Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests. 
        /// </summary>
        [Test]
        public async Task TestTestListUsage() 
        {
            // Parameters for the API call
            Standard.Models.ProductCodeEnum? productCode = null;
            string startDate = null;
            string endDate = null;
            string includeSubAccounts = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListUsageAsync(productCode, startDate, endDate, includeSubAccounts);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}