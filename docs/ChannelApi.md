# Org.OpenAPITools.Api.ChannelApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDChannelChannelIDGet**](ChannelApi.md#v1accountaccountidchannelchannelidget) | **GET** /v1/account/{accountID}/channel/{channelID} | Get Channel Details |
| [**V1AccountAccountIDChannelChannelIDPost**](ChannelApi.md#v1accountaccountidchannelchannelidpost) | **POST** /v1/account/{accountID}/channel/{channelID} | Associate Action to Channel |
| [**V1AccountAccountIDChannelChannelIDPut**](ChannelApi.md#v1accountaccountidchannelchannelidput) | **PUT** /v1/account/{accountID}/channel/{channelID} | Associate Metaflow to Channel |
| [**V1AccountAccountIDChannelGet**](ChannelApi.md#v1accountaccountidchannelget) | **GET** /v1/account/{accountID}/channel | Get Account Channel List |
| [**V1AccountAccountIDDeviceDeviceIDChannelGet**](ChannelApi.md#v1accountaccountiddevicedeviceidchannelget) | **GET** /v1/account/{accountID}/device/{deviceID}/channel | Get Device Channel List |
| [**V1AccountAccountIDUserUserIDChannelGet**](ChannelApi.md#v1accountaccountiduseruseridchannelget) | **GET** /v1/account/{accountID}/user/{userID}/channel | Get User Channel List |

<a id="v1accountaccountidchannelchannelidget"></a>
# **V1AccountAccountIDChannelChannelIDGet**
> ServiceDocsChannelGetSingle V1AccountAccountIDChannelChannelIDGet (string accountID, string channelID)

Get Channel Details

Access details about each channel in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDChannelChannelIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var channelID = "channelID_example";  // string | Channel ID

            try
            {
                // Get Channel Details
                ServiceDocsChannelGetSingle result = apiInstance.V1AccountAccountIDChannelChannelIDGet(accountID, channelID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDChannelChannelIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Channel Details
    ApiResponse<ServiceDocsChannelGetSingle> response = apiInstance.V1AccountAccountIDChannelChannelIDGetWithHttpInfo(accountID, channelID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **channelID** | **string** | Channel ID |  |

### Return type

[**ServiceDocsChannelGetSingle**](ServiceDocsChannelGetSingle.md)

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

<a id="v1accountaccountidchannelchannelidpost"></a>
# **V1AccountAccountIDChannelChannelIDPost**
> ServiceAPIResponse V1AccountAccountIDChannelChannelIDPost (string accountID, string channelID, ServiceVOIPChannelRunActionData reqBody)

Associate Action to Channel

Link an action, such as transfer or hangup to a channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDChannelChannelIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var channelID = "channelID_example";  // string | Channel ID
            var reqBody = new ServiceVOIPChannelRunActionData(); // ServiceVOIPChannelRunActionData | payload fields

            try
            {
                // Associate Action to Channel
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDChannelChannelIDPost(accountID, channelID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDChannelChannelIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate Action to Channel
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDChannelChannelIDPostWithHttpInfo(accountID, channelID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **channelID** | **string** | Channel ID |  |
| **reqBody** | [**ServiceVOIPChannelRunActionData**](ServiceVOIPChannelRunActionData.md) | payload fields |  |

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

<a id="v1accountaccountidchannelchannelidput"></a>
# **V1AccountAccountIDChannelChannelIDPut**
> ServiceAPIResponse V1AccountAccountIDChannelChannelIDPut (string accountID, string channelID, ServiceVOIPChannelRunMetaflowData reqBody)

Associate Metaflow to Channel

Link a metaflow to an active channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDChannelChannelIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var channelID = "channelID_example";  // string | Channel ID
            var reqBody = new ServiceVOIPChannelRunMetaflowData(); // ServiceVOIPChannelRunMetaflowData | payload fields

            try
            {
                // Associate Metaflow to Channel
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDChannelChannelIDPut(accountID, channelID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDChannelChannelIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate Metaflow to Channel
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDChannelChannelIDPutWithHttpInfo(accountID, channelID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelChannelIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **channelID** | **string** | Channel ID |  |
| **reqBody** | [**ServiceVOIPChannelRunMetaflowData**](ServiceVOIPChannelRunMetaflowData.md) | payload fields |  |

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

<a id="v1accountaccountidchannelget"></a>
# **V1AccountAccountIDChannelGet**
> ServiceDocsChannelGetAll V1AccountAccountIDChannelGet (string accountID)

Get Account Channel List

Get a list of active channels for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDChannelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Channel List
                ServiceDocsChannelGetAll result = apiInstance.V1AccountAccountIDChannelGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDChannelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Channel List
    ApiResponse<ServiceDocsChannelGetAll> response = apiInstance.V1AccountAccountIDChannelGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDChannelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsChannelGetAll**](ServiceDocsChannelGetAll.md)

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

<a id="v1accountaccountiddevicedeviceidchannelget"></a>
# **V1AccountAccountIDDeviceDeviceIDChannelGet**
> ServiceDocsChannelGetAll V1AccountAccountIDDeviceDeviceIDChannelGet (string accountID, string deviceID)

Get Device Channel List

Get the list of active channels for a device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDDeviceDeviceIDChannelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var deviceID = "deviceID_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Get Device Channel List
                ServiceDocsChannelGetAll result = apiInstance.V1AccountAccountIDDeviceDeviceIDChannelGet(accountID, deviceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDDeviceDeviceIDChannelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDDeviceDeviceIDChannelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Device Channel List
    ApiResponse<ServiceDocsChannelGetAll> response = apiInstance.V1AccountAccountIDDeviceDeviceIDChannelGetWithHttpInfo(accountID, deviceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDDeviceDeviceIDChannelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **deviceID** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsChannelGetAll**](ServiceDocsChannelGetAll.md)

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

<a id="v1accountaccountiduseruseridchannelget"></a>
# **V1AccountAccountIDUserUserIDChannelGet**
> ServiceDocsChannelGetAll V1AccountAccountIDUserUserIDChannelGet (string accountID, string userID)

Get User Channel List

Get the list of active channels for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDChannelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | User ID, 32 alpha numeric

            try
            {
                // Get User Channel List
                ServiceDocsChannelGetAll result = apiInstance.V1AccountAccountIDUserUserIDChannelGet(accountID, userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDUserUserIDChannelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDChannelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Channel List
    ApiResponse<ServiceDocsChannelGetAll> response = apiInstance.V1AccountAccountIDUserUserIDChannelGetWithHttpInfo(accountID, userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChannelApi.V1AccountAccountIDUserUserIDChannelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **userID** | **string** | User ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsChannelGetAll**](ServiceDocsChannelGetAll.md)

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

