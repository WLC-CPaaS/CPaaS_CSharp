# Org.OpenAPITools.Api.CallflowApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDCallflowCallflowIDDelete**](CallflowApi.md#v1accountaccountidcallflowcallflowiddelete) | **DELETE** /v1/account/{accountID}/callflow/{callflowID} | Delete Call Group |
| [**V1AccountAccountIDCallflowCallflowIDGet**](CallflowApi.md#v1accountaccountidcallflowcallflowidget) | **GET** /v1/account/{accountID}/callflow/{callflowID} | Get Call Group Details |
| [**V1AccountAccountIDCallflowCallflowIDPut**](CallflowApi.md#v1accountaccountidcallflowcallflowidput) | **PUT** /v1/account/{accountID}/callflow/{callflowID} | Update Call Group |
| [**V1AccountAccountIDCallflowGet**](CallflowApi.md#v1accountaccountidcallflowget) | **GET** /v1/account/{accountID}/callflow | Get Callflow List |
| [**V1AccountAccountIDCallflowPost**](CallflowApi.md#v1accountaccountidcallflowpost) | **POST** /v1/account/{accountID}/callflow | Create Call Group |

<a id="v1accountaccountidcallflowcallflowiddelete"></a>
# **V1AccountAccountIDCallflowCallflowIDDelete**
> ServiceDocsCallflowGetSingle V1AccountAccountIDCallflowCallflowIDDelete (string accountID, string callflowID)

Delete Call Group

Delete a callflow in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallflowCallflowIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var callflowID = "callflowID_example";  // string | callflow ID, 32 alpha numeric

            try
            {
                // Delete Call Group
                ServiceDocsCallflowGetSingle result = apiInstance.V1AccountAccountIDCallflowCallflowIDDelete(accountID, callflowID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallflowCallflowIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Call Group
    ApiResponse<ServiceDocsCallflowGetSingle> response = apiInstance.V1AccountAccountIDCallflowCallflowIDDeleteWithHttpInfo(accountID, callflowID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **callflowID** | **string** | callflow ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallflowGetSingle**](ServiceDocsCallflowGetSingle.md)

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

<a id="v1accountaccountidcallflowcallflowidget"></a>
# **V1AccountAccountIDCallflowCallflowIDGet**
> ServiceDocsCallflowGetSingle V1AccountAccountIDCallflowCallflowIDGet (string accountID, string callflowID)

Get Call Group Details

Get the details for a single callflow in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallflowCallflowIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var callflowID = "callflowID_example";  // string | Callflow ID, 32 alpha numeric

            try
            {
                // Get Call Group Details
                ServiceDocsCallflowGetSingle result = apiInstance.V1AccountAccountIDCallflowCallflowIDGet(accountID, callflowID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallflowCallflowIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Group Details
    ApiResponse<ServiceDocsCallflowGetSingle> response = apiInstance.V1AccountAccountIDCallflowCallflowIDGetWithHttpInfo(accountID, callflowID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **callflowID** | **string** | Callflow ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallflowGetSingle**](ServiceDocsCallflowGetSingle.md)

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

<a id="v1accountaccountidcallflowcallflowidput"></a>
# **V1AccountAccountIDCallflowCallflowIDPut**
> ServiceDocsCallflowGetSingle V1AccountAccountIDCallflowCallflowIDPut (string accountID, string callflowID, ServiceCallflowAddEditData reqBody)

Update Call Group

Update the details for a single callflow in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallflowCallflowIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var callflowID = "callflowID_example";  // string | Callflow ID, 32 alpha numeric
            var reqBody = new ServiceCallflowAddEditData(); // ServiceCallflowAddEditData | payload fields

            try
            {
                // Update Call Group
                ServiceDocsCallflowGetSingle result = apiInstance.V1AccountAccountIDCallflowCallflowIDPut(accountID, callflowID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallflowCallflowIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Call Group
    ApiResponse<ServiceDocsCallflowGetSingle> response = apiInstance.V1AccountAccountIDCallflowCallflowIDPutWithHttpInfo(accountID, callflowID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowCallflowIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **callflowID** | **string** | Callflow ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceCallflowAddEditData**](ServiceCallflowAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsCallflowGetSingle**](ServiceDocsCallflowGetSingle.md)

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

<a id="v1accountaccountidcallflowget"></a>
# **V1AccountAccountIDCallflowGet**
> ServiceDocsCallflowGetAll V1AccountAccountIDCallflowGet (string accountID, string? startKey = null, int? pageSize = null)

Get Callflow List

Permit a user to view the callflow details in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallflowGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Callflow List
                ServiceDocsCallflowGetAll result = apiInstance.V1AccountAccountIDCallflowGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallflowGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Callflow List
    ApiResponse<ServiceDocsCallflowGetAll> response = apiInstance.V1AccountAccountIDCallflowGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsCallflowGetAll**](ServiceDocsCallflowGetAll.md)

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

<a id="v1accountaccountidcallflowpost"></a>
# **V1AccountAccountIDCallflowPost**
> ServiceDocsCallflowGetSingle V1AccountAccountIDCallflowPost (string accountID, ServiceCallflowAddEditData request)

Create Call Group

Create instructions for routing a call to a user or system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCallflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha-numeric
            var request = new ServiceCallflowAddEditData(); // ServiceCallflowAddEditData | Call flow configuration

            try
            {
                // Create Call Group
                ServiceDocsCallflowGetSingle result = apiInstance.V1AccountAccountIDCallflowPost(accountID, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCallflowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Call Group
    ApiResponse<ServiceDocsCallflowGetSingle> response = apiInstance.V1AccountAccountIDCallflowPostWithHttpInfo(accountID, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallflowApi.V1AccountAccountIDCallflowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha-numeric |  |
| **request** | [**ServiceCallflowAddEditData**](ServiceCallflowAddEditData.md) | Call flow configuration |  |

### Return type

[**ServiceDocsCallflowGetSingle**](ServiceDocsCallflowGetSingle.md)

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

