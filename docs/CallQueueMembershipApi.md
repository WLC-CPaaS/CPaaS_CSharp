# Org.OpenAPITools.Api.CallQueueMembershipApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDQueuemembershipPost**](CallQueueMembershipApi.md#v1accountaccountidqueuemembershippost) | **POST** /v1/account/{accountID}/queuemembership | Grant Queue Membership to User |
| [**V1AccountAccountIDQueuemembershipRecipientIDDisablePost**](CallQueueMembershipApi.md#v1accountaccountidqueuemembershiprecipientiddisablepost) | **POST** /v1/account/{accountID}/queuemembership/{recipientID}/disable | Disable Queue Membership |
| [**V1AccountAccountIDQueuemembershipRecipientIDEnablePost**](CallQueueMembershipApi.md#v1accountaccountidqueuemembershiprecipientidenablepost) | **POST** /v1/account/{accountID}/queuemembership/{recipientID}/enable | Enable Queue Membership |

<a id="v1accountaccountidqueuemembershippost"></a>
# **V1AccountAccountIDQueuemembershipPost**
> ServiceDocsQueueMembershipOutput V1AccountAccountIDQueuemembershipPost (string accountID, ServiceVOIPQueueMembershipAddData reqBody)

Grant Queue Membership to User

Allow users to create queue memberships for recipients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuemembershipPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueMembershipApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var reqBody = new ServiceVOIPQueueMembershipAddData(); // ServiceVOIPQueueMembershipAddData | payload fields

            try
            {
                // Grant Queue Membership to User
                ServiceDocsQueueMembershipOutput result = apiInstance.V1AccountAccountIDQueuemembershipPost(accountID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuemembershipPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Grant Queue Membership to User
    ApiResponse<ServiceDocsQueueMembershipOutput> response = apiInstance.V1AccountAccountIDQueuemembershipPostWithHttpInfo(accountID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPQueueMembershipAddData**](ServiceVOIPQueueMembershipAddData.md) | payload fields |  |

### Return type

[**ServiceDocsQueueMembershipOutput**](ServiceDocsQueueMembershipOutput.md)

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

<a id="v1accountaccountidqueuemembershiprecipientiddisablepost"></a>
# **V1AccountAccountIDQueuemembershipRecipientIDDisablePost**
> ServiceAPIResponse V1AccountAccountIDQueuemembershipRecipientIDDisablePost (string accountID, string recipientID)

Disable Queue Membership

Deactivate queue membership for a recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuemembershipRecipientIDDisablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueMembershipApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recipientID = "recipientID_example";  // string | Recipient ID, 32 alpha numeric

            try
            {
                // Disable Queue Membership
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDQueuemembershipRecipientIDDisablePost(accountID, recipientID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipRecipientIDDisablePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuemembershipRecipientIDDisablePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Queue Membership
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDQueuemembershipRecipientIDDisablePostWithHttpInfo(accountID, recipientID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipRecipientIDDisablePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recipientID** | **string** | Recipient ID, 32 alpha numeric |  |

### Return type

[**ServiceAPIResponse**](ServiceAPIResponse.md)

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

<a id="v1accountaccountidqueuemembershiprecipientidenablepost"></a>
# **V1AccountAccountIDQueuemembershipRecipientIDEnablePost**
> ServiceAPIResponse V1AccountAccountIDQueuemembershipRecipientIDEnablePost (string accountID, string recipientID, ServiceVOIPCallQueueEnableMembershipData reqBody)

Enable Queue Membership

Activate queue membership for a recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDQueuemembershipRecipientIDEnablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallQueueMembershipApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var recipientID = "recipientID_example";  // string | Recipient ID, 32 alpha numeric
            var reqBody = new ServiceVOIPCallQueueEnableMembershipData(); // ServiceVOIPCallQueueEnableMembershipData | payload fields

            try
            {
                // Enable Queue Membership
                ServiceAPIResponse result = apiInstance.V1AccountAccountIDQueuemembershipRecipientIDEnablePost(accountID, recipientID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipRecipientIDEnablePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDQueuemembershipRecipientIDEnablePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Queue Membership
    ApiResponse<ServiceAPIResponse> response = apiInstance.V1AccountAccountIDQueuemembershipRecipientIDEnablePostWithHttpInfo(accountID, recipientID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallQueueMembershipApi.V1AccountAccountIDQueuemembershipRecipientIDEnablePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **recipientID** | **string** | Recipient ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPCallQueueEnableMembershipData**](ServiceVOIPCallQueueEnableMembershipData.md) | payload fields |  |

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

