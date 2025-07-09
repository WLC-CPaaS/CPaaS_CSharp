# Org.OpenAPITools.Api.CallQueueManagementApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDCallqueueGet**](CallQueueManagementApi.md#v1accountaccountidcallqueueget) | **GET** /v1/account/{accountID}/callqueue | Get Call Queues |
| [**V1AccountAccountIDCallqueuePost**](CallQueueManagementApi.md#v1accountaccountidcallqueuepost) | **POST** /v1/account/{accountID}/callqueue | Create Call Queue |
| [**V1AccountAccountIDCallqueueQueueIDDelete**](CallQueueManagementApi.md#v1accountaccountidcallqueuequeueiddelete) | **DELETE** /v1/account/{accountID}/callqueue/{queueID} | Delete Call Queue |
| [**V1AccountAccountIDCallqueueQueueIDGet**](CallQueueManagementApi.md#v1accountaccountidcallqueuequeueidget) | **GET** /v1/account/{accountID}/callqueue/{queueID} | Get Call Queue Details |
| [**V1AccountAccountIDCallqueueQueueIDPut**](CallQueueManagementApi.md#v1accountaccountidcallqueuequeueidput) | **PUT** /v1/account/{accountID}/callqueue/{queueID} | Update Call Queue |
| [**V1AccountAccountIDCallqueueQueueIDStatusGet**](CallQueueManagementApi.md#v1accountaccountidcallqueuequeueidstatusget) | **GET** /v1/account/{accountID}/callqueue/{queueID}/status | Get Call Queue Status |
| [**V1AccountAccountIDQueuerolesGet**](CallQueueManagementApi.md#v1accountaccountidqueuerolesget) | **GET** /v1/account/{accountID}/queueroles | Get Queue Roles of Account |
| [**V1AccountAccountIDQueuerolesQueueIDPost**](CallQueueManagementApi.md#v1accountaccountidqueuerolesqueueidpost) | **POST** /v1/account/{accountID}/queueroles/{queueID} | Assign Queue Role to Call Queue |

<a id="v1accountaccountidcallqueueget"></a>
# **V1AccountAccountIDCallqueueGet**
> ServiceDocsCallQueueGetAll V1AccountAccountIDCallqueueGet (string accountID)

Get Call Queues

Retrieve call queue details for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueueGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Call Queues
                ServiceDocsCallQueueGetAll result = apiInstance.V1AccountAccountIDCallqueueGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueueGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Queues
    ApiResponse<ServiceDocsCallQueueGetAll> response = apiInstance.V1AccountAccountIDCallqueueGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallQueueGetAll**](ServiceDocsCallQueueGetAll.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidcallqueuepost"></a>
# **V1AccountAccountIDCallqueuePost**
> ServiceDocsCallQueueGetSingle V1AccountAccountIDCallqueuePost (string accountID, ServiceVOIPCallQueueAddEditData reqBody)

Create Call Queue

Set up a call queue in an account for specific inbound calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueuePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueAddEditData(); // ServiceVOIPCallQueueAddEditData | payload fields

            try
            {
                // Create Call Queue
                ServiceDocsCallQueueGetSingle result = apiInstance.V1AccountAccountIDCallqueuePost(accountID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueuePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueuePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Call Queue
    ApiResponse<ServiceDocsCallQueueGetSingle> response = apiInstance.V1AccountAccountIDCallqueuePostWithHttpInfo(accountID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueuePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueAddEditData**](ServiceVOIPCallQueueAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsCallQueueGetSingle**](ServiceDocsCallQueueGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidcallqueuequeueiddelete"></a>
# **V1AccountAccountIDCallqueueQueueIDDelete**
> ServiceDocsCallQueueGetSingle V1AccountAccountIDCallqueueQueueIDDelete (string accountID, string queueID)

Delete Call Queue

Remove the call queue from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueueQueueIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var queueID = "queueID_example";  // string | Queue ID, 32 alpha numeric

            try
            {
                // Delete Call Queue
                ServiceDocsCallQueueGetSingle result = apiInstance.V1AccountAccountIDCallqueueQueueIDDelete(accountID, queueID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueueQueueIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Call Queue
    ApiResponse<ServiceDocsCallQueueGetSingle> response = apiInstance.V1AccountAccountIDCallqueueQueueIDDeleteWithHttpInfo(accountID, queueID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **queueID** | **string** | Queue ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallQueueGetSingle**](ServiceDocsCallQueueGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidcallqueuequeueidget"></a>
# **V1AccountAccountIDCallqueueQueueIDGet**
> ServiceDocsCallQueueGetSingle V1AccountAccountIDCallqueueQueueIDGet (string accountID, string queueID)

Get Call Queue Details

Capture metadata about a specific queue, such as queue_type and agent_wrapup_time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueueQueueIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var queueID = "queueID_example";  // string | Queue ID, 32 alpha numeric

            try
            {
                // Get Call Queue Details
                ServiceDocsCallQueueGetSingle result = apiInstance.V1AccountAccountIDCallqueueQueueIDGet(accountID, queueID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueueQueueIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Queue Details
    ApiResponse<ServiceDocsCallQueueGetSingle> response = apiInstance.V1AccountAccountIDCallqueueQueueIDGetWithHttpInfo(accountID, queueID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **queueID** | **string** | Queue ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallQueueGetSingle**](ServiceDocsCallQueueGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidcallqueuequeueidput"></a>
# **V1AccountAccountIDCallqueueQueueIDPut**
> ServiceDocsCallQueueGetSingle V1AccountAccountIDCallqueueQueueIDPut (string accountID, string queueID, ServiceVOIPCallQueueAddEditData reqBody)

Update Call Queue

Update the metadata mentioned above.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueueQueueIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var queueID = "queueID_example";  // string | Queue ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueAddEditData(); // ServiceVOIPCallQueueAddEditData | payload fields

            try
            {
                // Update Call Queue
                ServiceDocsCallQueueGetSingle result = apiInstance.V1AccountAccountIDCallqueueQueueIDPut(accountID, queueID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueueQueueIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Call Queue
    ApiResponse<ServiceDocsCallQueueGetSingle> response = apiInstance.V1AccountAccountIDCallqueueQueueIDPutWithHttpInfo(accountID, queueID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **queueID** | **string** | Queue ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueAddEditData**](ServiceVOIPCallQueueAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsCallQueueGetSingle**](ServiceDocsCallQueueGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidcallqueuequeueidstatusget"></a>
# **V1AccountAccountIDCallqueueQueueIDStatusGet**
> ServiceDocsCallQueueGetSingleStatus V1AccountAccountIDCallqueueQueueIDStatusGet (string accountID, string queueID)

Get Call Queue Status

Access the status of a call queue in an account, such as the number of available agents (recipients), estimated wait time, and number of active sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallqueueQueueIDStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var queueID = "queueID_example";  // string | Queue ID, 32 alpha numeric

            try
            {
                // Get Call Queue Status
                ServiceDocsCallQueueGetSingleStatus result = apiInstance.V1AccountAccountIDCallqueueQueueIDStatusGet(accountID, queueID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallqueueQueueIDStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Queue Status
    ApiResponse<ServiceDocsCallQueueGetSingleStatus> response = apiInstance.V1AccountAccountIDCallqueueQueueIDStatusGetWithHttpInfo(accountID, queueID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDCallqueueQueueIDStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **queueID** | **string** | Queue ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallQueueGetSingleStatus**](ServiceDocsCallQueueGetSingleStatus.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidqueuerolesget"></a>
# **V1AccountAccountIDQueuerolesGet**
> ServiceDocsCallQueueGetRoles V1AccountAccountIDQueuerolesGet (string accountID)

Get Queue Roles of Account

Obtain data about each queue role in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuerolesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Queue Roles of Account
                ServiceDocsCallQueueGetRoles result = apiInstance.V1AccountAccountIDQueuerolesGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDQueuerolesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuerolesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Queue Roles of Account
    ApiResponse<ServiceDocsCallQueueGetRoles> response = apiInstance.V1AccountAccountIDQueuerolesGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDQueuerolesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallQueueGetRoles**](ServiceDocsCallQueueGetRoles.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidqueuerolesqueueidpost"></a>
# **V1AccountAccountIDQueuerolesQueueIDPost**
> ServiceAPIResponse V1AccountAccountIDQueuerolesQueueIDPost (string accountID, string queueID, ServiceVOIPCallQueueRoleAssignData reqBody)

Assign Queue Role to Call Queue

Assign roles to members in a call queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuerolesQueueIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueManagementApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var queueID = "queueID_example";  // string | Queue ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueRoleAssignData(); // ServiceVOIPCallQueueRoleAssignData | payload fields

            try
            {
                // Assign Queue Role to Call Queue
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDQueuerolesQueueIDPost(accountID, queueID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDQueuerolesQueueIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuerolesQueueIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign Queue Role to Call Queue
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDQueuerolesQueueIDPostWithHttpInfo(accountID, queueID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueManagementApi.V1AccountAccountIDQueuerolesQueueIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **queueID** | **string** | Queue ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueRoleAssignData**](ServiceVOIPCallQueueRoleAssignData.md) | payload fields |  |

### Return type

[**ServiceAPIResponse**](ServiceAPIResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

