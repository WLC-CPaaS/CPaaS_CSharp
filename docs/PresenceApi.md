# Org.OpenAPITools.Api.PresenceApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDPresenceExtensionPut**](PresenceApi.md#v1accountaccountidpresenceextensionput) | **PUT** /v1/account/{accountID}/presence/{extension} | Set/Reset Presence for Extension |
| [**V1AccountAccountIDPresenceGet**](PresenceApi.md#v1accountaccountidpresenceget) | **GET** /v1/account/{accountID}/presence | Get Presence Details |
| [**V1AccountAccountIDUserUserIDPresencePut**](PresenceApi.md#v1accountaccountiduseruseridpresenceput) | **PUT** /v1/account/{accountID}/user/{userID}/presence | Set/Reset Presence for User |

<a id="v1accountaccountidpresenceextensionput"></a>
# **V1AccountAccountIDPresenceExtensionPut**
> ServiceAPIResponse V1AccountAccountIDPresenceExtensionPut (string accountID, string extension, ServiceVOIPPresenceSetResetEditData reqBody)

Set/Reset Presence for Extension

Set or reset the presence status of an extension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDPresenceExtensionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PresenceApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var extension = "extension_example";  // string | Extension
            var reqBody = new ServiceVOIPPresenceSetResetEditData(); // ServiceVOIPPresenceSetResetEditData | payload fields

            try
            {
                // Set/Reset Presence for Extension
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDPresenceExtensionPut(accountID, extension, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDPresenceExtensionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDPresenceExtensionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set/Reset Presence for Extension
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDPresenceExtensionPutWithHttpInfo(accountID, extension, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDPresenceExtensionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **extension** | **string** | Extension |  |
| **reqBody** | [**ServiceVOIPPresenceSetResetEditData**](ServiceVOIPPresenceSetResetEditData.md) | payload fields |  |

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

<a id="v1accountaccountidpresenceget"></a>
# **V1AccountAccountIDPresenceGet**
> ServiceDocsPresenceGet V1AccountAccountIDPresenceGet (string accountID)

Get Presence Details

Retrieve details of presence subscriptions in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDPresenceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PresenceApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Presence Details
                ServiceDocsPresenceGet result = apiInstance.V1AccountAccountIDPresenceGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDPresenceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDPresenceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Presence Details
    ApiResponse<ServiceDocsPresenceGet> response = apiInstance.V1AccountAccountIDPresenceGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDPresenceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsPresenceGet**](ServiceDocsPresenceGet.md)

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

<a id="v1accountaccountiduseruseridpresenceput"></a>
# **V1AccountAccountIDUserUserIDPresencePut**
> ServiceAPIResponse V1AccountAccountIDUserUserIDPresencePut (string accountID, string userID, ServiceVOIPPresenceSetResetEditData reqBody)

Set/Reset Presence for User

Set or reset the presence status of a user within an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDPresencePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PresenceApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | User ID, 32 alpha numeric
            var reqBody = new ServiceVOIPPresenceSetResetEditData(); // ServiceVOIPPresenceSetResetEditData | payload fields

            try
            {
                // Set/Reset Presence for User
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDUserUserIDPresencePut(accountID, userID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDUserUserIDPresencePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDPresencePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set/Reset Presence for User
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDUserUserIDPresencePutWithHttpInfo(accountID, userID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PresenceApi.V1AccountAccountIDUserUserIDPresencePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **userID** | **string** | User ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPPresenceSetResetEditData**](ServiceVOIPPresenceSetResetEditData.md) | payload fields |  |

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

