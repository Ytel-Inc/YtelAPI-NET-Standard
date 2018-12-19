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
    public class CarrierControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static CarrierController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Carrier;
        }

        /// <summary>
        /// Retrieve a list of carrier lookup objects. 
        /// </summary>
        [Test]
        public async Task TestTestCarrierResults() 
        {
            // Parameters for the API call
            int? page = null;
            int? pageSize = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateCarrierResultsAsync(page, pageSize);
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