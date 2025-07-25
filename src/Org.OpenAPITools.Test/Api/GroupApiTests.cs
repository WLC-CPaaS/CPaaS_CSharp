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
    ///  Class for testing GroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupApiTests : IDisposable
    {
        private GroupApi instance;

        public GroupApiTests()
        {
            instance = new GroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupApi
            //Assert.IsType<GroupApi>(instance);
        }

        /// <summary>
        /// Test V1AccountAccountIDGroupGet
        /// </summary>
        [Fact]
        public void V1AccountAccountIDGroupGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string? startKey = null;
            //int? pageSize = null;
            //var response = instance.V1AccountAccountIDGroupGet(accountID, startKey, pageSize);
            //Assert.IsType<ServiceDocGroupGetAll>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDGroupGroupIDDelete
        /// </summary>
        [Fact]
        public void V1AccountAccountIDGroupGroupIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string groupID = null;
            //var response = instance.V1AccountAccountIDGroupGroupIDDelete(accountID, groupID);
            //Assert.IsType<ServiceDocGroupGetSingle>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDGroupGroupIDGet
        /// </summary>
        [Fact]
        public void V1AccountAccountIDGroupGroupIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string groupID = null;
            //var response = instance.V1AccountAccountIDGroupGroupIDGet(accountID, groupID);
            //Assert.IsType<ServiceDocGroupGetSingle>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDGroupGroupIDPut
        /// </summary>
        [Fact]
        public void V1AccountAccountIDGroupGroupIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //string groupID = null;
            //ServiceVOIPGroupAddEdit2 reqBody = null;
            //var response = instance.V1AccountAccountIDGroupGroupIDPut(accountID, groupID, reqBody);
            //Assert.IsType<ServiceDocGroupGetSingle>(response);
        }

        /// <summary>
        /// Test V1AccountAccountIDGroupPost
        /// </summary>
        [Fact]
        public void V1AccountAccountIDGroupPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountID = null;
            //ServiceVOIPGroupAddEdit2 group = null;
            //var response = instance.V1AccountAccountIDGroupPost(accountID, group);
            //Assert.IsType<ServiceDocGroupGetSingle>(response);
        }
    }
}
