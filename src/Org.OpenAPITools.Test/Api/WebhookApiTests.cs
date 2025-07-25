/*
 * White Label Communications CPaas API Documentation
 *
 * A CPaaS platform API
 *
 * The version of the OpenAPI document: 1.1
 * Contact: support@whitelabelcomm.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests : IDisposable
    {
        private WebhookApi instance;

        public WebhookApiTests()
        {
            instance = new WebhookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookApi
            //Assert.IsType<WebhookApi>(instance);
        }

        /// <summary>
        /// Test V1WebhookAccountAccountIDGet
        /// </summary>
        [Fact]
        public void V1WebhookAccountAccountIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //int? pageSize = null;
            //int? currentPage = null;
            //var response = instance.V1WebhookAccountAccountIDGet(accountID, pageSize, currentPage);
            //Assert.IsType<ServiceDocsWebhookGetAll>(response);
        }

        /// <summary>
        /// Test V1WebhookAccountAccountIDPost
        /// </summary>
        [Fact]
        public void V1WebhookAccountAccountIDPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //ServiceWebhookAdd body = null;
            //var response = instance.V1WebhookAccountAccountIDPost(accountID, body);
            //Assert.IsType<ServiceDocsWebhookGetSingle>(response);
        }

        /// <summary>
        /// Test V1WebhookAccountAccountIDWebhookIDDelete
        /// </summary>
        [Fact]
        public void V1WebhookAccountAccountIDWebhookIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //int webhookID = null;
            //var response = instance.V1WebhookAccountAccountIDWebhookIDDelete(accountID, webhookID);
            //Assert.IsType<ServiceDocsWebhookDelete>(response);
        }

        /// <summary>
        /// Test V1WebhookAccountAccountIDWebhookIDGet
        /// </summary>
        [Fact]
        public void V1WebhookAccountAccountIDWebhookIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //int webhookID = null;
            //var response = instance.V1WebhookAccountAccountIDWebhookIDGet(accountID, webhookID);
            //Assert.IsType<ServiceDocsWebhookGetSingle>(response);
        }

        /// <summary>
        /// Test V1WebhookAccountAccountIDWebhookIDPut
        /// </summary>
        [Fact]
        public void V1WebhookAccountAccountIDWebhookIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string webhookID = null;
            //ServiceWebhookEdit body = null;
            //var response = instance.V1WebhookAccountAccountIDWebhookIDPut(accountID, webhookID, body);
            //Assert.IsType<ServiceDocsWebhookGetSingle>(response);
        }
    }
}
