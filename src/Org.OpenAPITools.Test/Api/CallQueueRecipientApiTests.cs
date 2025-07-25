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
    ///  Class for testing CallQueueRecipientApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallQueueRecipientApiTests : IDisposable
    {
        private CallQueueRecipientApi instance;

        public CallQueueRecipientApiTests()
        {
            instance = new CallQueueRecipientApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallQueueRecipientApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CallQueueRecipientApi
            //Assert.IsType<CallQueueRecipientApi>(instance);
        }

        /// <summary>
        /// Test V1AccountAccountIDLoginrecipientRecipientIDPost
        /// </summary>
        [Fact]
        public void V1AccountAccountIDLoginrecipientRecipientIDPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string recipientID = null;
            //ServiceVOIPCallQueueRecipientLoginLogoutData reqBody = null;
            //var response = instance.V1AccountAccountIDLoginrecipientRecipientIDPost(accountID, recipientID, reqBody);
            //Assert.IsType<ServiceDocsCallQueueRecipientLoginLogoutOutput>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDQueuerecipientGet
        /// </summary>
        [Fact]
        public void V1AccountAccountIDQueuerecipientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //var response = instance.V1AccountAccountIDQueuerecipientGet(accountID);
            //Assert.IsType<ServiceDocsGetQueueRecipients>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDRecipientRecipientIDStatusPost
        /// </summary>
        [Fact]
        public void V1AccountAccountIDRecipientRecipientIDStatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string recipientID = null;
            //ServiceVOIPCallQueueRecipientStatusData reqBody = null;
            //var response = instance.V1AccountAccountIDRecipientRecipientIDStatusPost(accountID, recipientID, reqBody);
            //Assert.IsType<ServiceAPIResponse>(response);
        }
    }
}
