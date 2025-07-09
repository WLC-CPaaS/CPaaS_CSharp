# Org.OpenAPITools.Api.CallQueueRecipientApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDLoginrecipientRecipientIDPost**](CallQueueRecipientApi.md#v1accountaccountidloginrecipientrecipientidpost) | **POST** /v1/account/{accountID}/loginrecipient/{recipientID} | Login as Recipient |
| [**V1AccountAccountIDQueuerecipientGet**](CallQueueRecipientApi.md#v1accountaccountidqueuerecipientget) | **GET** /v1/account/{accountID}/queuerecipient | Change Recipient Status |
| [**V1AccountAccountIDRecipientRecipientIDStatusPost**](CallQueueRecipientApi.md#v1accountaccountidrecipientrecipientidstatuspost) | **POST** /v1/account/{accountID}/recipient/{recipientID}/status | Get Recipient List |

<a id="v1accountaccountidloginrecipientrecipientidpost"></a>
# **V1AccountAccountIDLoginrecipientRecipientIDPost**
> ServiceDocsCallQueueRecipientLoginLogoutOutput V1AccountAccountIDLoginrecipientRecipientIDPost (string accountID, string recipientID, ServiceVOIPCallQueueRecipientLoginLogoutData reqBody)

Login as Recipient

Agents must log in to receive calls. Depending on their membership, they can log in to one or more queues. (If an agent is a member of more than one queue, they will receive calls from all the queues they are a part of.)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDLoginrecipientRecipientIDPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueRecipientApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recipientID = "recipientID_example";  // string | Recipient ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueRecipientLoginLogoutData(); // ServiceVOIPCallQueueRecipientLoginLogoutData | payload fields

            try
            {
                // Login as Recipient
                ServiceDocsCallQueueRecipientLoginLogoutOutput result = apiInstance.V1AccountAccountIDLoginrecipientRecipientIDPost(accountID, recipientID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDLoginrecipientRecipientIDPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDLoginrecipientRecipientIDPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login as Recipient
    ApiResponse<ServiceDocsCallQueueRecipientLoginLogoutOutput> response = apiInstance.V1AccountAccountIDLoginrecipientRecipientIDPostWithHttpInfo(accountID, recipientID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDLoginrecipientRecipientIDPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recipientID** | **string** | Recipient ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueRecipientLoginLogoutData**](ServiceVOIPCallQueueRecipientLoginLogoutData.md) | payload fields |  |

### Return type

[**ServiceDocsCallQueueRecipientLoginLogoutOutput**](ServiceDocsCallQueueRecipientLoginLogoutOutput.md)

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

<a id="v1accountaccountidqueuerecipientget"></a>
# **V1AccountAccountIDQueuerecipientGet**
> ServiceDocsGetQueueRecipients V1AccountAccountIDQueuerecipientGet (string accountID)

Change Recipient Status

Get a list of all recipients in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuerecipientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueRecipientApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Change Recipient Status
                ServiceDocsGetQueueRecipients result = apiInstance.V1AccountAccountIDQueuerecipientGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDQueuerecipientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuerecipientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Recipient Status
    ApiResponse<ServiceDocsGetQueueRecipients> response = apiInstance.V1AccountAccountIDQueuerecipientGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDQueuerecipientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsGetQueueRecipients**](ServiceDocsGetQueueRecipients.md)

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

<a id="v1accountaccountidrecipientrecipientidstatuspost"></a>
# **V1AccountAccountIDRecipientRecipientIDStatusPost**
> ServiceAPIResponse V1AccountAccountIDRecipientRecipientIDStatusPost (string accountID, string recipientID, ServiceVOIPCallQueueRecipientStatusData reqBody)

Get Recipient List

Change the status of a recipient to ready, away, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDRecipientRecipientIDStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueRecipientApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recipientID = "recipientID_example";  // string | Recipient ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueRecipientStatusData(); // ServiceVOIPCallQueueRecipientStatusData | payload fields

            try
            {
                // Get Recipient List
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDRecipientRecipientIDStatusPost(accountID, recipientID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDRecipientRecipientIDStatusPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDRecipientRecipientIDStatusPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Recipient List
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDRecipientRecipientIDStatusPostWithHttpInfo(accountID, recipientID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueRecipientApi.V1AccountAccountIDRecipientRecipientIDStatusPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recipientID** | **string** | Recipient ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueRecipientStatusData**](ServiceVOIPCallQueueRecipientStatusData.md) | payload fields |  |

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

