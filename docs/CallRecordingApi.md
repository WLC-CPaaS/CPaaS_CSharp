# Org.OpenAPITools.Api.CallRecordingApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDRecordingGet**](CallRecordingApi.md#v1accountaccountidrecordingget) | **GET** /v1/account/{accountID}/recording | Get Account Call Recording |
| [**V1AccountAccountIDRecordingRecordingIDDelete**](CallRecordingApi.md#v1accountaccountidrecordingrecordingiddelete) | **DELETE** /v1/account/{accountID}/recording/{recordingID} | Delete Call Recording |
| [**V1AccountAccountIDRecordingRecordingIDGet**](CallRecordingApi.md#v1accountaccountidrecordingrecordingidget) | **GET** /v1/account/{accountID}/recording/{recordingID} | Get Call Recording Details |
| [**V1AccountAccountIDUserUserIDRecordingGet**](CallRecordingApi.md#v1accountaccountiduseruseridrecordingget) | **GET** /v1/account/{accountID}/user/{userID}/recording | Get User Call Recording |

<a id="v1accountaccountidrecordingget"></a>
# **V1AccountAccountIDRecordingGet**
> ServiceDocsCallRecordingGetAll V1AccountAccountIDRecordingGet (string accountID)

Get Account Call Recording

Obtain a list of the call recordings within an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDRecordingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallRecordingApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Call Recording
                ServiceDocsCallRecordingGetAll result = apiInstance.V1AccountAccountIDRecordingGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDRecordingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Call Recording
    ApiResponse<ServiceDocsCallRecordingGetAll> response = apiInstance.V1AccountAccountIDRecordingGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallRecordingGetAll**](ServiceDocsCallRecordingGetAll.md)

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

<a id="v1accountaccountidrecordingrecordingiddelete"></a>
# **V1AccountAccountIDRecordingRecordingIDDelete**
> ServiceDocsCallRecordingGetSingle V1AccountAccountIDRecordingRecordingIDDelete (string accountID, string recordingID)

Delete Call Recording

Delete a single call recording from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDRecordingRecordingIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallRecordingApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recordingID = "recordingID_example";  // string | Recording ID, 39 (yyyymm-<32 id>)

            try
            {
                // Delete Call Recording
                ServiceDocsCallRecordingGetSingle result = apiInstance.V1AccountAccountIDRecordingRecordingIDDelete(accountID, recordingID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingRecordingIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDRecordingRecordingIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Call Recording
    ApiResponse<ServiceDocsCallRecordingGetSingle> response = apiInstance.V1AccountAccountIDRecordingRecordingIDDeleteWithHttpInfo(accountID, recordingID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingRecordingIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recordingID** | **string** | Recording ID, 39 (yyyymm-&lt;32 id&gt;) |  |

### Return type

[**ServiceDocsCallRecordingGetSingle**](ServiceDocsCallRecordingGetSingle.md)

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

<a id="v1accountaccountidrecordingrecordingidget"></a>
# **V1AccountAccountIDRecordingRecordingIDGet**
> ServiceDocsCallRecordingGetSingle V1AccountAccountIDRecordingRecordingIDGet (string accountID, string recordingID)

Get Call Recording Details

Access details for each recorded call in an account (e.g., duration, names and numbers of call participants, etc.).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDRecordingRecordingIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallRecordingApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recordingID = "recordingID_example";  // string | Recording ID, 39 (yyyymm-<32 id>)

            try
            {
                // Get Call Recording Details
                ServiceDocsCallRecordingGetSingle result = apiInstance.V1AccountAccountIDRecordingRecordingIDGet(accountID, recordingID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingRecordingIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDRecordingRecordingIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Recording Details
    ApiResponse<ServiceDocsCallRecordingGetSingle> response = apiInstance.V1AccountAccountIDRecordingRecordingIDGetWithHttpInfo(accountID, recordingID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDRecordingRecordingIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recordingID** | **string** | Recording ID, 39 (yyyymm-&lt;32 id&gt;) |  |

### Return type

[**ServiceDocsCallRecordingGetSingle**](ServiceDocsCallRecordingGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, audio/mp3, audio/mpeg, audio/mpeg3, audio/x-wav, audio/wav


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountiduseruseridrecordingget"></a>
# **V1AccountAccountIDUserUserIDRecordingGet**
> ServiceDocsCallRecordingGetAll V1AccountAccountIDUserUserIDRecordingGet (string accountID, string userID)

Get User Call Recording

Retrieve a list of call recordings for a user within an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDRecordingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallRecordingApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | User ID, 32 alpha numeric

            try
            {
                // Get User Call Recording
                ServiceDocsCallRecordingGetAll result = apiInstance.V1AccountAccountIDUserUserIDRecordingGet(accountID, userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDUserUserIDRecordingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDRecordingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Call Recording
    ApiResponse<ServiceDocsCallRecordingGetAll> response = apiInstance.V1AccountAccountIDUserUserIDRecordingGetWithHttpInfo(accountID, userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallRecordingApi.V1AccountAccountIDUserUserIDRecordingGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsCallRecordingGetAll**](ServiceDocsCallRecordingGetAll.md)

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

