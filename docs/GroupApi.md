# Org.OpenAPITools.Api.GroupApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDGroupGet**](GroupApi.md#v1accountaccountidgroupget) | **GET** /v1/account/{accountID}/group | Get Group List |
| [**V1AccountAccountIDGroupGroupIDDelete**](GroupApi.md#v1accountaccountidgroupgroupiddelete) | **DELETE** /v1/account/{accountID}/group/{groupID} | Delete Group |
| [**V1AccountAccountIDGroupGroupIDGet**](GroupApi.md#v1accountaccountidgroupgroupidget) | **GET** /v1/account/{accountID}/group/{groupID} | Get Group Details |
| [**V1AccountAccountIDGroupGroupIDPut**](GroupApi.md#v1accountaccountidgroupgroupidput) | **PUT** /v1/account/{accountID}/group/{groupID} | Update Group |
| [**V1AccountAccountIDGroupPost**](GroupApi.md#v1accountaccountidgrouppost) | **POST** /v1/account/{accountID}/group | Create Group |

<a id="v1accountaccountidgroupget"></a>
# **V1AccountAccountIDGroupGet**
> ServiceDocGroupGetAll V1AccountAccountIDGroupGet (string accountID, string? startKey = null, int? pageSize = null)

Get Group List

Get a list of groups associated with an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDGroupGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Group List
                ServiceDocGroupGetAll result = apiInstance.V1AccountAccountIDGroupGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDGroupGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group List
    ApiResponse<ServiceDocGroupGetAll> response = apiInstance.V1AccountAccountIDGroupGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **startKey** | **string?** | start_key for pagination that was returned as next_start_key from your previous call | [optional]  |
| **pageSize** | **int?** | number of records to return, range 1 to 50 | [optional]  |

### Return type

[**ServiceDocGroupGetAll**](ServiceDocGroupGetAll.md)

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

<a id="v1accountaccountidgroupgroupiddelete"></a>
# **V1AccountAccountIDGroupGroupIDDelete**
> ServiceDocGroupGetSingle V1AccountAccountIDGroupGroupIDDelete (string accountID, string groupID)

Delete Group

Delete a call group in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDGroupGroupIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var groupID = "groupID_example";  // string | group ID, 32 alpha numeric

            try
            {
                // Delete Group
                ServiceDocGroupGetSingle result = apiInstance.V1AccountAccountIDGroupGroupIDDelete(accountID, groupID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDGroupGroupIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group
    ApiResponse<ServiceDocGroupGetSingle> response = apiInstance.V1AccountAccountIDGroupGroupIDDeleteWithHttpInfo(accountID, groupID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **groupID** | **string** | group ID, 32 alpha numeric |  |

### Return type

[**ServiceDocGroupGetSingle**](ServiceDocGroupGetSingle.md)

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

<a id="v1accountaccountidgroupgroupidget"></a>
# **V1AccountAccountIDGroupGroupIDGet**
> ServiceDocGroupGetSingle V1AccountAccountIDGroupGroupIDGet (string accountID, string groupID)

Get Group Details

Access details about a single group within an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDGroupGroupIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var groupID = "groupID_example";  // string | Group ID, 32 alpha numeric

            try
            {
                // Get Group Details
                ServiceDocGroupGetSingle result = apiInstance.V1AccountAccountIDGroupGroupIDGet(accountID, groupID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDGroupGroupIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Details
    ApiResponse<ServiceDocGroupGetSingle> response = apiInstance.V1AccountAccountIDGroupGroupIDGetWithHttpInfo(accountID, groupID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **groupID** | **string** | Group ID, 32 alpha numeric |  |

### Return type

[**ServiceDocGroupGetSingle**](ServiceDocGroupGetSingle.md)

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

<a id="v1accountaccountidgroupgroupidput"></a>
# **V1AccountAccountIDGroupGroupIDPut**
> ServiceDocGroupGetSingle V1AccountAccountIDGroupGroupIDPut (string accountID, string groupID, ServiceVOIPGroupAddEdit2 reqBody)

Update Group

Modify the name, settings and other information for a group within an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDGroupGroupIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var groupID = "groupID_example";  // string | Group ID, 32 alpha numeric
            var reqBody = new ServiceVOIPGroupAddEdit2(); // ServiceVOIPGroupAddEdit2 | payload fields

            try
            {
                // Update Group
                ServiceDocGroupGetSingle result = apiInstance.V1AccountAccountIDGroupGroupIDPut(accountID, groupID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDGroupGroupIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group
    ApiResponse<ServiceDocGroupGetSingle> response = apiInstance.V1AccountAccountIDGroupGroupIDPutWithHttpInfo(accountID, groupID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupGroupIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **groupID** | **string** | Group ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPGroupAddEdit2**](ServiceVOIPGroupAddEdit2.md) | payload fields |  |

### Return type

[**ServiceDocGroupGetSingle**](ServiceDocGroupGetSingle.md)

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

<a id="v1accountaccountidgrouppost"></a>
# **V1AccountAccountIDGroupPost**
> ServiceDocGroupGetSingle V1AccountAccountIDGroupPost (string accountID, ServiceVOIPGroupAddEdit2 group)

Create Group

Provide an additional resource by adding a group list to an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var group = new ServiceVOIPGroupAddEdit2(); // ServiceVOIPGroupAddEdit2 | group fields

            try
            {
                // Create Group
                ServiceDocGroupGetSingle result = apiInstance.V1AccountAccountIDGroupPost(accountID, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Group
    ApiResponse<ServiceDocGroupGetSingle> response = apiInstance.V1AccountAccountIDGroupPostWithHttpInfo(accountID, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.V1AccountAccountIDGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **group** | [**ServiceVOIPGroupAddEdit2**](ServiceVOIPGroupAddEdit2.md) | group fields |  |

### Return type

[**ServiceDocGroupGetSingle**](ServiceDocGroupGetSingle.md)

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

