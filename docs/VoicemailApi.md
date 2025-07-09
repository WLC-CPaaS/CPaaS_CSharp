# Org.OpenAPITools.Api.VoicemailApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDVoicemailGet**](VoicemailApi.md#v1accountaccountidvoicemailget) | **GET** /v1/account/{accountID}/voicemail | Get Voicemail Box List |
| [**V1AccountAccountIDVoicemailPost**](VoicemailApi.md#v1accountaccountidvoicemailpost) | **POST** /v1/account/{accountID}/voicemail | Create Voicemail Box |
| [**V1AccountAccountIDVoicemailVoicemailIDDelete**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailiddelete) | **DELETE** /v1/account/{accountID}/voicemail/{voicemailID} | Delete Voicemail Box |
| [**V1AccountAccountIDVoicemailVoicemailIDGet**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidget) | **GET** /v1/account/{accountID}/voicemail/{voicemailID} | Get Voicemail Box Details |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageGet**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessageget) | **GET** /v1/account/{accountID}/voicemail/{voicemailID}/message | Get Voicemail Message List |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDelete**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagemessageiddelete) | **DELETE** /v1/account/{accountID}/voicemail/{voicemailID}/message/{messageID} | Delete Voicemail Message |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGet**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagemessageidget) | **GET** /v1/account/{accountID}/voicemail/{voicemailID}/message/{messageID} | Get Voicemail Message Details |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPut**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagemessageidput) | **PUT** /v1/account/{accountID}/voicemail/{voicemailID}/message/{messageID} | Update Voicemail Message |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGet**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagemessageidrawget) | **GET** /v1/account/{accountID}/voicemail/{voicemailID}/message/{messageID}/raw | Get Voicemail Message File |
| [**V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPost**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagemessageidrawpost) | **POST** /v1/account/{accountID}/voicemail/{voicemailID}/message/{messageID}/raw | Add Voicemail Message File |
| [**V1AccountAccountIDVoicemailVoicemailIDMessagePost**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidmessagepost) | **POST** /v1/account/{accountID}/voicemail/{voicemailID}/message | Create Voicemail Message |
| [**V1AccountAccountIDVoicemailVoicemailIDPut**](VoicemailApi.md#v1accountaccountidvoicemailvoicemailidput) | **PUT** /v1/account/{accountID}/voicemail/{voicemailID} | Update Voicemail Box |

<a id="v1accountaccountidvoicemailget"></a>
# **V1AccountAccountIDVoicemailGet**
> ServiceDocsVoicemailGetAll V1AccountAccountIDVoicemailGet (string accountID, string? startKey = null, int? pageSize = null)

Get Voicemail Box List

List all voicemail boxes in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Voicemail Box List
                ServiceDocsVoicemailGetAll result = apiInstance.V1AccountAccountIDVoicemailGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voicemail Box List
    ApiResponse<ServiceDocsVoicemailGetAll> response = apiInstance.V1AccountAccountIDVoicemailGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsVoicemailGetAll**](ServiceDocsVoicemailGetAll.md)

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

<a id="v1accountaccountidvoicemailpost"></a>
# **V1AccountAccountIDVoicemailPost**
> ServiceDocsVoicemailGetSingle V1AccountAccountIDVoicemailPost (string accountID, ServiceVOIPVoicemailAddEditData voicemail)

Create Voicemail Box

Create a voicemail box for receiving and storing voicemail messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | account ID, 32 alphanumeric
            var voicemail = new ServiceVOIPVoicemailAddEditData(); // ServiceVOIPVoicemailAddEditData | voicemail payload fields

            try
            {
                // Create Voicemail Box
                ServiceDocsVoicemailGetSingle result = apiInstance.V1AccountAccountIDVoicemailPost(accountID, voicemail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Voicemail Box
    ApiResponse<ServiceDocsVoicemailGetSingle> response = apiInstance.V1AccountAccountIDVoicemailPostWithHttpInfo(accountID, voicemail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | account ID, 32 alphanumeric |  |
| **voicemail** | [**ServiceVOIPVoicemailAddEditData**](ServiceVOIPVoicemailAddEditData.md) | voicemail payload fields |  |

### Return type

[**ServiceDocsVoicemailGetSingle**](ServiceDocsVoicemailGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailiddelete"></a>
# **V1AccountAccountIDVoicemailVoicemailIDDelete**
> ServiceDocsVoicemailGetSingle V1AccountAccountIDVoicemailVoicemailIDDelete (string accountID, string voicemailID)

Delete Voicemail Box

Delete a voicemail box in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric

            try
            {
                // Delete Voicemail Box
                ServiceDocsVoicemailGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDDelete(accountID, voicemailID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Voicemail Box
    ApiResponse<ServiceDocsVoicemailGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDDeleteWithHttpInfo(accountID, voicemailID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsVoicemailGetSingle**](ServiceDocsVoicemailGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidget"></a>
# **V1AccountAccountIDVoicemailVoicemailIDGet**
> ServiceDocsVoicemailGetSingle V1AccountAccountIDVoicemailVoicemailIDGet (string accountID, string voicemailID)

Get Voicemail Box Details

Get information about a single voicemail box.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric

            try
            {
                // Get Voicemail Box Details
                ServiceDocsVoicemailGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDGet(accountID, voicemailID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voicemail Box Details
    ApiResponse<ServiceDocsVoicemailGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDGetWithHttpInfo(accountID, voicemailID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsVoicemailGetSingle**](ServiceDocsVoicemailGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidmessageget"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageGet**
> ServiceDocsVoicemailMessageGetAll V1AccountAccountIDVoicemailVoicemailIDMessageGet (string accountID, string voicemailID, string? startKey = null, int? pageSize = null)

Get Voicemail Message List

Get a list of voicemail messages from an account's voicemail box.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | voicemail ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Voicemail Message List
                ServiceDocsVoicemailMessageGetAll result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageGet(accountID, voicemailID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voicemail Message List
    ApiResponse<ServiceDocsVoicemailMessageGetAll> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageGetWithHttpInfo(accountID, voicemailID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | voicemail ID, 32 alpha numeric |  |
| **startKey** | **string?** | start_key for pagination that was returned as next_start_key from your previous call | [optional]  |
| **pageSize** | **int?** | number of records to return, range 1 to 50 | [optional]  |

### Return type

[**ServiceDocsVoicemailMessageGetAll**](ServiceDocsVoicemailMessageGetAll.md)

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

<a id="v1accountaccountidvoicemailvoicemailidmessagemessageiddelete"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDelete**
> ServiceDocsVoicemailMessageGetSingle V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDelete (string accountID, string voicemailID, string messageID)

Delete Voicemail Message

Delete a voicemail message from a voicemail box in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric
            var messageID = "messageID_example";  // string | message ID, 32 alpha numeric

            try
            {
                // Delete Voicemail Message
                ServiceDocsVoicemailMessageGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDelete(accountID, voicemailID, messageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Voicemail Message
    ApiResponse<ServiceDocsVoicemailMessageGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDeleteWithHttpInfo(accountID, voicemailID, messageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |
| **messageID** | **string** | message ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsVoicemailMessageGetSingle**](ServiceDocsVoicemailMessageGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidmessagemessageidget"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGet**
> ServiceDocsVoicemailMessageGetSingle V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGet (string accountID, string voicemailID, string messageID)

Get Voicemail Message Details

Retrieve the container details of an individual voicemail message. This includes a reference to the audio file, but not the message itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric
            var messageID = "messageID_example";  // string | Message ID, 39 (yyyymm-<32 id>)

            try
            {
                // Get Voicemail Message Details
                ServiceDocsVoicemailMessageGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGet(accountID, voicemailID, messageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voicemail Message Details
    ApiResponse<ServiceDocsVoicemailMessageGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGetWithHttpInfo(accountID, voicemailID, messageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |
| **messageID** | **string** | Message ID, 39 (yyyymm-&lt;32 id&gt;) |  |

### Return type

[**ServiceDocsVoicemailMessageGetSingle**](ServiceDocsVoicemailMessageGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidmessagemessageidput"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPut**
> ServiceDocsVoicemailMessageGetSingle V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPut (string accountID, string voicemailID, string messageID, ServiceVOIPVoicemailMessageChange reqBody)

Update Voicemail Message

Copy or move a voicemail message to a different folder in the same voicemail box or move the message to a separate voicemail box.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric
            var messageID = "messageID_example";  // string | Message ID, 39 (yyyymm-<32 id>)
            var reqBody = new ServiceVOIPVoicemailMessageChange(); // ServiceVOIPVoicemailMessageChange | payload fields

            try
            {
                // Update Voicemail Message
                ServiceDocsVoicemailMessageGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPut(accountID, voicemailID, messageID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Voicemail Message
    ApiResponse<ServiceDocsVoicemailMessageGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPutWithHttpInfo(accountID, voicemailID, messageID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |
| **messageID** | **string** | Message ID, 39 (yyyymm-&lt;32 id&gt;) |  |
| **reqBody** | [**ServiceVOIPVoicemailMessageChange**](ServiceVOIPVoicemailMessageChange.md) | payload fields |  |

### Return type

[**ServiceDocsVoicemailMessageGetSingle**](ServiceDocsVoicemailMessageGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidmessagemessageidrawget"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGet**
> System.IO.Stream V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGet (string accountID, string voicemailID, string messageID)

Get Voicemail Message File

Get the original audio content of a specific voicemail message identified by its unique ID within an account's voicemail box. URL Param \"voicemailID\" is a unique 32-character alphanumeric identifier assigned by the system, which refers to a specific voicemail box. URL Param \"messageID\" is a unique 32-character alphanumeric identifier assigned by the system, which refers to a specific message within a voicemail box.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, unique 32-character alphanumeric identifier
            var voicemailID = "voicemailID_example";  // string | Voicemail Box ID, unique 32-character alphanumeric identifier
            var messageID = "messageID_example";  // string | Message ID, unique 32-character alphanumeric identifier

            try
            {
                // Get Voicemail Message File
                System.IO.Stream result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGet(accountID, voicemailID, messageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voicemail Message File
    ApiResponse<System.IO.Stream> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGetWithHttpInfo(accountID, voicemailID, messageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, unique 32-character alphanumeric identifier |  |
| **voicemailID** | **string** | Voicemail Box ID, unique 32-character alphanumeric identifier |  |
| **messageID** | **string** | Message ID, unique 32-character alphanumeric identifier |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidvoicemailvoicemailidmessagemessageidrawpost"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPost**
> Dictionary&lt;string, Object&gt; V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPost (string accountID, string voicemailID, string messageID, System.IO.Stream file)

Add Voicemail Message File

Associate an audio recording file with the voicemail to fully complete the message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alphanumeric characters
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alphanumeric characters
            var messageID = "messageID_example";  // string | Message ID, 32 alphanumeric characters
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Audio file to upload

            try
            {
                // Add Voicemail Message File
                Dictionary<string, Object> result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPost(accountID, voicemailID, messageID, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Voicemail Message File
    ApiResponse<Dictionary<string, Object>> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPostWithHttpInfo(accountID, voicemailID, messageID, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessageMessageIDRawPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alphanumeric characters |  |
| **voicemailID** | **string** | Voicemail ID, 32 alphanumeric characters |  |
| **messageID** | **string** | Message ID, 32 alphanumeric characters |  |
| **file** | **System.IO.Stream****System.IO.Stream** | Audio file to upload |  |

### Return type

**Dictionary<string, Object>**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidvoicemailvoicemailidmessagepost"></a>
# **V1AccountAccountIDVoicemailVoicemailIDMessagePost**
> ServiceDocsVoicemailMessageGetSingle V1AccountAccountIDVoicemailVoicemailIDMessagePost (string accountID, string voicemailID, ServiceVOIPVoicemailMessageAddData message)

Create Voicemail Message

Create the container information for a recorded voicemail message in a voicemail box.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDMessagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | account ID, 32 alphanumeric
            var voicemailID = "voicemailID_example";  // string | voicemail ID, 32 alphanumeric
            var message = new ServiceVOIPVoicemailMessageAddData(); // ServiceVOIPVoicemailMessageAddData | voicemail message payload fields

            try
            {
                // Create Voicemail Message
                ServiceDocsVoicemailMessageGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessagePost(accountID, voicemailID, message);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessagePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDMessagePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Voicemail Message
    ApiResponse<ServiceDocsVoicemailMessageGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDMessagePostWithHttpInfo(accountID, voicemailID, message);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDMessagePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | account ID, 32 alphanumeric |  |
| **voicemailID** | **string** | voicemail ID, 32 alphanumeric |  |
| **message** | [**ServiceVOIPVoicemailMessageAddData**](ServiceVOIPVoicemailMessageAddData.md) | voicemail message payload fields |  |

### Return type

[**ServiceDocsVoicemailMessageGetSingle**](ServiceDocsVoicemailMessageGetSingle.md)

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

<a id="v1accountaccountidvoicemailvoicemailidput"></a>
# **V1AccountAccountIDVoicemailVoicemailIDPut**
> ServiceDocsVoicemailGetSingle V1AccountAccountIDVoicemailVoicemailIDPut (string accountID, string voicemailID, ServiceVOIPVoicemailAddEditData reqBody)

Update Voicemail Box

Update the settings in an individual voicemail box, such as the owner, PIN, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDVoicemailVoicemailIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var voicemailID = "voicemailID_example";  // string | Voicemail ID, 32 alpha numeric
            var reqBody = new ServiceVOIPVoicemailAddEditData(); // ServiceVOIPVoicemailAddEditData | payload fields

            try
            {
                // Update Voicemail Box
                ServiceDocsVoicemailGetSingle result = apiInstance.V1AccountAccountIDVoicemailVoicemailIDPut(accountID, voicemailID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDVoicemailVoicemailIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Voicemail Box
    ApiResponse<ServiceDocsVoicemailGetSingle> response = apiInstance.V1AccountAccountIDVoicemailVoicemailIDPutWithHttpInfo(accountID, voicemailID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoicemailApi.V1AccountAccountIDVoicemailVoicemailIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **voicemailID** | **string** | Voicemail ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPVoicemailAddEditData**](ServiceVOIPVoicemailAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsVoicemailGetSingle**](ServiceDocsVoicemailGetSingle.md)

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

