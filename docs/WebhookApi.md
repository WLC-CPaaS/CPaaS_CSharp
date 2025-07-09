# Org.OpenAPITools.Api.WebhookApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1WebhookAccountAccountIDGet**](WebhookApi.md#v1webhookaccountaccountidget) | **GET** /v1/webhook/account/{accountID} | Get Webhook List |
| [**V1WebhookAccountAccountIDPost**](WebhookApi.md#v1webhookaccountaccountidpost) | **POST** /v1/webhook/account/{accountID} | Create Webhook |
| [**V1WebhookAccountAccountIDWebhookIDDelete**](WebhookApi.md#v1webhookaccountaccountidwebhookiddelete) | **DELETE** /v1/webhook/account/{accountID}/{webhookID} | Delete Webhook |
| [**V1WebhookAccountAccountIDWebhookIDGet**](WebhookApi.md#v1webhookaccountaccountidwebhookidget) | **GET** /v1/webhook/account/{accountID}/{webhookID} | Get Webhook Details |
| [**V1WebhookAccountAccountIDWebhookIDPut**](WebhookApi.md#v1webhookaccountaccountidwebhookidput) | **PUT** /v1/webhook/account/{accountID}/{webhookID} | Update Webhook |

<a id="v1webhookaccountaccountidget"></a>
# **V1WebhookAccountAccountIDGet**
> ServiceDocsWebhookGetAll V1WebhookAccountAccountIDGet (string accountID, int? pageSize = null, int? currentPage = null)

Get Webhook List

Retrieve the webhook list in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1WebhookAccountAccountIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 
            var currentPage = 56;  // int? | Current Page (optional) 

            try
            {
                // Get Webhook List
                ServiceDocsWebhookGetAll result = apiInstance.V1WebhookAccountAccountIDGet(accountID, pageSize, currentPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1WebhookAccountAccountIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Webhook List
    ApiResponse<ServiceDocsWebhookGetAll> response = apiInstance.V1WebhookAccountAccountIDGetWithHttpInfo(accountID, pageSize, currentPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **pageSize** | **int?** | number of records to return, range 1 to 50 | [optional]  |
| **currentPage** | **int?** | Current Page | [optional]  |

### Return type

[**ServiceDocsWebhookGetAll**](ServiceDocsWebhookGetAll.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1webhookaccountaccountidpost"></a>
# **V1WebhookAccountAccountIDPost**
> ServiceDocsWebhookGetSingle V1WebhookAccountAccountIDPost (string accountID, ServiceWebhookAdd body)

Create Webhook

Create a webhook for a specific account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1WebhookAccountAccountIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var body = new ServiceWebhookAdd(); // ServiceWebhookAdd | Webhook data

            try
            {
                // Create Webhook
                ServiceDocsWebhookGetSingle result = apiInstance.V1WebhookAccountAccountIDPost(accountID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1WebhookAccountAccountIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Webhook
    ApiResponse<ServiceDocsWebhookGetSingle> response = apiInstance.V1WebhookAccountAccountIDPostWithHttpInfo(accountID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **body** | [**ServiceWebhookAdd**](ServiceWebhookAdd.md) | Webhook data |  |

### Return type

[**ServiceDocsWebhookGetSingle**](ServiceDocsWebhookGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1webhookaccountaccountidwebhookiddelete"></a>
# **V1WebhookAccountAccountIDWebhookIDDelete**
> ServiceDocsWebhookDelete V1WebhookAccountAccountIDWebhookIDDelete (string accountID, int webhookID)

Delete Webhook

Remove a webhook identified by its ID for a particular account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1WebhookAccountAccountIDWebhookIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var webhookID = 56;  // int | Webhook ID

            try
            {
                // Delete Webhook
                ServiceDocsWebhookDelete result = apiInstance.V1WebhookAccountAccountIDWebhookIDDelete(accountID, webhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1WebhookAccountAccountIDWebhookIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Webhook
    ApiResponse<ServiceDocsWebhookDelete> response = apiInstance.V1WebhookAccountAccountIDWebhookIDDeleteWithHttpInfo(accountID, webhookID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **webhookID** | **int** | Webhook ID |  |

### Return type

[**ServiceDocsWebhookDelete**](ServiceDocsWebhookDelete.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1webhookaccountaccountidwebhookidget"></a>
# **V1WebhookAccountAccountIDWebhookIDGet**
> ServiceDocsWebhookGetSingle V1WebhookAccountAccountIDWebhookIDGet (string accountID, int webhookID)

Get Webhook Details

Access details about a single webhook ID for an individual account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1WebhookAccountAccountIDWebhookIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var webhookID = 56;  // int | Webhook ID

            try
            {
                // Get Webhook Details
                ServiceDocsWebhookGetSingle result = apiInstance.V1WebhookAccountAccountIDWebhookIDGet(accountID, webhookID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1WebhookAccountAccountIDWebhookIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Webhook Details
    ApiResponse<ServiceDocsWebhookGetSingle> response = apiInstance.V1WebhookAccountAccountIDWebhookIDGetWithHttpInfo(accountID, webhookID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **webhookID** | **int** | Webhook ID |  |

### Return type

[**ServiceDocsWebhookGetSingle**](ServiceDocsWebhookGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1webhookaccountaccountidwebhookidput"></a>
# **V1WebhookAccountAccountIDWebhookIDPut**
> ServiceDocsWebhookGetSingle V1WebhookAccountAccountIDWebhookIDPut (string accountID, string webhookID, ServiceWebhookEdit body)

Update Webhook

Update a webhook identified by its ID for a distinct account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1WebhookAccountAccountIDWebhookIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhookApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var webhookID = "webhookID_example";  // string | Webhook ID
            var body = new ServiceWebhookEdit(); // ServiceWebhookEdit | Updated webhook data

            try
            {
                // Update Webhook
                ServiceDocsWebhookGetSingle result = apiInstance.V1WebhookAccountAccountIDWebhookIDPut(accountID, webhookID, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1WebhookAccountAccountIDWebhookIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Webhook
    ApiResponse<ServiceDocsWebhookGetSingle> response = apiInstance.V1WebhookAccountAccountIDWebhookIDPutWithHttpInfo(accountID, webhookID, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.V1WebhookAccountAccountIDWebhookIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **webhookID** | **string** | Webhook ID |  |
| **body** | [**ServiceWebhookEdit**](ServiceWebhookEdit.md) | Updated webhook data |  |

### Return type

[**ServiceDocsWebhookGetSingle**](ServiceDocsWebhookGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

