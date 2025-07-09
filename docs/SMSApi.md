# Org.OpenAPITools.Api.SMSApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1SmsAccountAccountIDCampaignCampaignIDImportGet**](SMSApi.md#v1smsaccountaccountidcampaigncampaignidimportget) | **GET** /v1/sms/account/{accountID}/campaign/{campaignID}/import |  |
| [**V1SmsAccountAccountIDCampaignCampaignIDImportPost**](SMSApi.md#v1smsaccountaccountidcampaigncampaignidimportpost) | **POST** /v1/sms/account/{accountID}/campaign/{campaignID}/import |  |
| [**V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGet**](SMSApi.md#v1smsaccountaccountidcampaigncampaignidphonenumberget) | **GET** /v1/sms/account/{accountID}/campaign/{campaignID}/phonenumber |  |
| [**V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPut**](SMSApi.md#v1smsaccountaccountidcampaigncampaignidphonenumberput) | **PUT** /v1/sms/account/{accountID}/campaign/{campaignID}/phonenumber |  |
| [**V1SmsAccountAccountIDCampaignImportGet**](SMSApi.md#v1smsaccountaccountidcampaignimportget) | **GET** /v1/sms/account/{accountID}/campaign/import |  |

<a id="v1smsaccountaccountidcampaigncampaignidimportget"></a>
# **V1SmsAccountAccountIDCampaignCampaignIDImportGet**
> ServiceDocsCampaignImportOutput V1SmsAccountAccountIDCampaignCampaignIDImportGet (string accountID, string campaignID)



Get details about a single imported campaign in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SmsAccountAccountIDCampaignCampaignIDImportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SMSApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var campaignID = "campaignID_example";  // string | Campaign ID

            try
            {
                ServiceDocsCampaignImportOutput result = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDImportGet(accountID, campaignID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDImportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SmsAccountAccountIDCampaignCampaignIDImportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsCampaignImportOutput> response = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDImportGetWithHttpInfo(accountID, campaignID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDImportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **campaignID** | **string** | Campaign ID |  |

### Return type

[**ServiceDocsCampaignImportOutput**](ServiceDocsCampaignImportOutput.md)

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

<a id="v1smsaccountaccountidcampaigncampaignidimportpost"></a>
# **V1SmsAccountAccountIDCampaignCampaignIDImportPost**
> ServiceDocsCampaignImportOutput V1SmsAccountAccountIDCampaignCampaignIDImportPost (string accountID, string campaignID)



Import campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SmsAccountAccountIDCampaignCampaignIDImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SMSApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var campaignID = "campaignID_example";  // string | Campaign ID

            try
            {
                ServiceDocsCampaignImportOutput result = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDImportPost(accountID, campaignID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SmsAccountAccountIDCampaignCampaignIDImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsCampaignImportOutput> response = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDImportPostWithHttpInfo(accountID, campaignID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **campaignID** | **string** | Campaign ID |  |

### Return type

[**ServiceDocsCampaignImportOutput**](ServiceDocsCampaignImportOutput.md)

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

<a id="v1smsaccountaccountidcampaigncampaignidphonenumberget"></a>
# **V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGet**
> ServiceDocsCampaignPhoneNumberOutput V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGet (string accountID, string campaignID, decimal? pageNum = null, decimal? pageSize = null)



Get telephone numbers associated with a campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SMSApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var campaignID = "campaignID_example";  // string | Campaign ID
            var pageNum = 8.14D;  // decimal? | Page number (optional) 
            var pageSize = 8.14D;  // decimal? | Page size (optional) 

            try
            {
                ServiceDocsCampaignPhoneNumberOutput result = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGet(accountID, campaignID, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsCampaignPhoneNumberOutput> response = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGetWithHttpInfo(accountID, campaignID, pageNum, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **campaignID** | **string** | Campaign ID |  |
| **pageNum** | **decimal?** | Page number | [optional]  |
| **pageSize** | **decimal?** | Page size | [optional]  |

### Return type

[**ServiceDocsCampaignPhoneNumberOutput**](ServiceDocsCampaignPhoneNumberOutput.md)

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

<a id="v1smsaccountaccountidcampaigncampaignidphonenumberput"></a>
# **V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPut**
> ServiceDocsCampaignTagDetagPhonenumbersOutput V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPut (string accountID, string campaignID, ServiceCampaignTagDetagPhonenumbers reqBody)



Associate or dissociate telephone numbers with a campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SMSApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var campaignID = "campaignID_example";  // string | Campaign ID, 32 alpha numeric
            var reqBody = new ServiceCampaignTagDetagPhonenumbers(); // ServiceCampaignTagDetagPhonenumbers | payload fields

            try
            {
                ServiceDocsCampaignTagDetagPhonenumbersOutput result = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPut(accountID, campaignID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsCampaignTagDetagPhonenumbersOutput> response = apiInstance.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPutWithHttpInfo(accountID, campaignID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignCampaignIDPhonenumberPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **campaignID** | **string** | Campaign ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceCampaignTagDetagPhonenumbers**](ServiceCampaignTagDetagPhonenumbers.md) | payload fields |  |

### Return type

[**ServiceDocsCampaignTagDetagPhonenumbersOutput**](ServiceDocsCampaignTagDetagPhonenumbersOutput.md)

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

<a id="v1smsaccountaccountidcampaignimportget"></a>
# **V1SmsAccountAccountIDCampaignImportGet**
> ServiceDocsCampaignImportedGetAllOutput V1SmsAccountAccountIDCampaignImportGet (string accountID, decimal? pageNum = null, decimal? pageSize = null)



Get a list of all imported campaigns in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SmsAccountAccountIDCampaignImportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SMSApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var pageNum = 8.14D;  // decimal? | Page number (optional) 
            var pageSize = 8.14D;  // decimal? | Page size (optional) 

            try
            {
                ServiceDocsCampaignImportedGetAllOutput result = apiInstance.V1SmsAccountAccountIDCampaignImportGet(accountID, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignImportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SmsAccountAccountIDCampaignImportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsCampaignImportedGetAllOutput> response = apiInstance.V1SmsAccountAccountIDCampaignImportGetWithHttpInfo(accountID, pageNum, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.V1SmsAccountAccountIDCampaignImportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **pageNum** | **decimal?** | Page number | [optional]  |
| **pageSize** | **decimal?** | Page size | [optional]  |

### Return type

[**ServiceDocsCampaignImportedGetAllOutput**](ServiceDocsCampaignImportedGetAllOutput.md)

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

