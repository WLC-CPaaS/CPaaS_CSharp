# Org.OpenAPITools.Api.TemporalRuleApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDTemporalruleGet**](TemporalRuleApi.md#v1accountaccountidtemporalruleget) | **GET** /v1/account/{accountID}/temporalrule | Get Temporal Rule List |
| [**V1AccountAccountIDTemporalrulePost**](TemporalRuleApi.md#v1accountaccountidtemporalrulepost) | **POST** /v1/account/{accountID}/temporalrule | Create Temporal Rule |
| [**V1AccountAccountIDTemporalruleTemporalRuleIDDelete**](TemporalRuleApi.md#v1accountaccountidtemporalruletemporalruleiddelete) | **DELETE** /v1/account/{accountID}/temporalrule/{temporalRuleID} | Delete Temporal Rule |
| [**V1AccountAccountIDTemporalruleTemporalRuleIDGet**](TemporalRuleApi.md#v1accountaccountidtemporalruletemporalruleidget) | **GET** /v1/account/{accountID}/temporalrule/{temporalRuleID} | Get Temporal Rule Details |
| [**V1AccountAccountIDTemporalruleTemporalRuleIDPut**](TemporalRuleApi.md#v1accountaccountidtemporalruletemporalruleidput) | **PUT** /v1/account/{accountID}/temporalrule/{temporalRuleID} | Update Temporal Rule |

<a id="v1accountaccountidtemporalruleget"></a>
# **V1AccountAccountIDTemporalruleGet**
> ServiceDocsTemporalRuleGetAll V1AccountAccountIDTemporalruleGet (string accountID, string? startKey = null, int? pageSize = null)

Get Temporal Rule List

Access all temporal rules for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalruleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Temporal Rule List
                ServiceDocsTemporalRuleGetAll result = apiInstance.V1AccountAccountIDTemporalruleGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalruleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Temporal Rule List
    ApiResponse<ServiceDocsTemporalRuleGetAll> response = apiInstance.V1AccountAccountIDTemporalruleGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsTemporalRuleGetAll**](ServiceDocsTemporalRuleGetAll.md)

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

<a id="v1accountaccountidtemporalrulepost"></a>
# **V1AccountAccountIDTemporalrulePost**
> ServiceDocsTemporalRuleGetSingle V1AccountAccountIDTemporalrulePost (string accountID, ServiceVOIPTemporalRuleAddEdit2 temporalrule)

Create Temporal Rule

Create temporal rules for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alphanumeric
            var temporalrule = new ServiceVOIPTemporalRuleAddEdit2(); // ServiceVOIPTemporalRuleAddEdit2 | payload fields

            try
            {
                // Create Temporal Rule
                ServiceDocsTemporalRuleGetSingle result = apiInstance.V1AccountAccountIDTemporalrulePost(accountID, temporalrule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalrulePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Temporal Rule
    ApiResponse<ServiceDocsTemporalRuleGetSingle> response = apiInstance.V1AccountAccountIDTemporalrulePostWithHttpInfo(accountID, temporalrule);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalrulePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alphanumeric |  |
| **temporalrule** | [**ServiceVOIPTemporalRuleAddEdit2**](ServiceVOIPTemporalRuleAddEdit2.md) | payload fields |  |

### Return type

[**ServiceDocsTemporalRuleGetSingle**](ServiceDocsTemporalRuleGetSingle.md)

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

<a id="v1accountaccountidtemporalruletemporalruleiddelete"></a>
# **V1AccountAccountIDTemporalruleTemporalRuleIDDelete**
> ServiceDocsTemporalRuleGetSingle V1AccountAccountIDTemporalruleTemporalRuleIDDelete (string accountID, string temporalRuleID)

Delete Temporal Rule

Remove a temporal rule from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalruleTemporalRuleIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleID = "temporalRuleID_example";  // string | temporal rule ID, 32 alpha numeric

            try
            {
                // Delete Temporal Rule
                ServiceDocsTemporalRuleGetSingle result = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDDelete(accountID, temporalRuleID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalruleTemporalRuleIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Temporal Rule
    ApiResponse<ServiceDocsTemporalRuleGetSingle> response = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDDeleteWithHttpInfo(accountID, temporalRuleID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleID** | **string** | temporal rule ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsTemporalRuleGetSingle**](ServiceDocsTemporalRuleGetSingle.md)

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

<a id="v1accountaccountidtemporalruletemporalruleidget"></a>
# **V1AccountAccountIDTemporalruleTemporalRuleIDGet**
> ServiceDocsTemporalRuleGetSingle V1AccountAccountIDTemporalruleTemporalRuleIDGet (string accountID, string temporalRuleID)

Get Temporal Rule Details

View details about individual time rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalruleTemporalRuleIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleID = "temporalRuleID_example";  // string | Temporal Rule ID, 32 alpha numeric

            try
            {
                // Get Temporal Rule Details
                ServiceDocsTemporalRuleGetSingle result = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDGet(accountID, temporalRuleID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalruleTemporalRuleIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Temporal Rule Details
    ApiResponse<ServiceDocsTemporalRuleGetSingle> response = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDGetWithHttpInfo(accountID, temporalRuleID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleID** | **string** | Temporal Rule ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsTemporalRuleGetSingle**](ServiceDocsTemporalRuleGetSingle.md)

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

<a id="v1accountaccountidtemporalruletemporalruleidput"></a>
# **V1AccountAccountIDTemporalruleTemporalRuleIDPut**
> ServiceDocsTemporalRuleGetSingle V1AccountAccountIDTemporalruleTemporalRuleIDPut (string accountID, string temporalRuleID, ServiceVOIPTemporalRuleAddEdit2 reqBody)

Update Temporal Rule

Edit the existing temporal rules in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalruleTemporalRuleIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleID = "temporalRuleID_example";  // string | Temporal Rule ID, 32 alpha numeric
            var reqBody = new ServiceVOIPTemporalRuleAddEdit2(); // ServiceVOIPTemporalRuleAddEdit2 | payload fields

            try
            {
                // Update Temporal Rule
                ServiceDocsTemporalRuleGetSingle result = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDPut(accountID, temporalRuleID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalruleTemporalRuleIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Temporal Rule
    ApiResponse<ServiceDocsTemporalRuleGetSingle> response = apiInstance.V1AccountAccountIDTemporalruleTemporalRuleIDPutWithHttpInfo(accountID, temporalRuleID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleApi.V1AccountAccountIDTemporalruleTemporalRuleIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleID** | **string** | Temporal Rule ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPTemporalRuleAddEdit2**](ServiceVOIPTemporalRuleAddEdit2.md) | payload fields |  |

### Return type

[**ServiceDocsTemporalRuleGetSingle**](ServiceDocsTemporalRuleGetSingle.md)

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

