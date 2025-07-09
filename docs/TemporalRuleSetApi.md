# Org.OpenAPITools.Api.TemporalRuleSetApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDTemporalrulesetGet**](TemporalRuleSetApi.md#v1accountaccountidtemporalrulesetget) | **GET** /v1/account/{accountID}/temporalruleset | Get Temporal Rule Set List |
| [**V1AccountAccountIDTemporalrulesetPost**](TemporalRuleSetApi.md#v1accountaccountidtemporalrulesetpost) | **POST** /v1/account/{accountID}/temporalruleset | Create Temporal Rule Set |
| [**V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDelete**](TemporalRuleSetApi.md#v1accountaccountidtemporalrulesettemporalrulesetiddelete) | **DELETE** /v1/account/{accountID}/temporalruleset/{temporalRuleSetID} | Delete Temporal Rule Set |
| [**V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGet**](TemporalRuleSetApi.md#v1accountaccountidtemporalrulesettemporalrulesetidget) | **GET** /v1/account/{accountID}/temporalruleset/{temporalRuleSetID} | Get Temporal Rule Set Details |
| [**V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPut**](TemporalRuleSetApi.md#v1accountaccountidtemporalrulesettemporalrulesetidput) | **PUT** /v1/account/{accountID}/temporalruleset/{temporalRuleSetID} | Update Temporal Rule Set |

<a id="v1accountaccountidtemporalrulesetget"></a>
# **V1AccountAccountIDTemporalrulesetGet**
> ServiceDocsTemporalRuleSetGetAll V1AccountAccountIDTemporalrulesetGet (string accountID, string? startKey = null, int? pageSize = null)

Get Temporal Rule Set List

Access the temporal rule set list in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulesetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleSetApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Temporal Rule Set List
                ServiceDocsTemporalRuleSetGetAll result = apiInstance.V1AccountAccountIDTemporalrulesetGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulesetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Temporal Rule Set List
    ApiResponse<ServiceDocsTemporalRuleSetGetAll> response = apiInstance.V1AccountAccountIDTemporalrulesetGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsTemporalRuleSetGetAll**](ServiceDocsTemporalRuleSetGetAll.md)

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

<a id="v1accountaccountidtemporalrulesetpost"></a>
# **V1AccountAccountIDTemporalrulesetPost**
> ServiceDocsTemporalRuleSetGetSingle V1AccountAccountIDTemporalrulesetPost (string accountID, ServiceVOIPTemporalRuleSetAddEditData temporalruleset)

Create Temporal Rule Set

Develop a new temporal rule set for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulesetPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleSetApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alphanumeric
            var temporalruleset = new ServiceVOIPTemporalRuleSetAddEditData(); // ServiceVOIPTemporalRuleSetAddEditData | payload fields

            try
            {
                // Create Temporal Rule Set
                ServiceDocsTemporalRuleSetGetSingle result = apiInstance.V1AccountAccountIDTemporalrulesetPost(accountID, temporalruleset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulesetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Temporal Rule Set
    ApiResponse<ServiceDocsTemporalRuleSetGetSingle> response = apiInstance.V1AccountAccountIDTemporalrulesetPostWithHttpInfo(accountID, temporalruleset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alphanumeric |  |
| **temporalruleset** | [**ServiceVOIPTemporalRuleSetAddEditData**](ServiceVOIPTemporalRuleSetAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsTemporalRuleSetGetSingle**](ServiceDocsTemporalRuleSetGetSingle.md)

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

<a id="v1accountaccountidtemporalrulesettemporalrulesetiddelete"></a>
# **V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDelete**
> ServiceDocsTemporalRuleSetGetSingle V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDelete (string accountID, string temporalRuleSetID)

Delete Temporal Rule Set

Delete the temporal rule set from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleSetApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleSetID = "temporalRuleSetID_example";  // string | temporal rule set ID, 32 alpha numeric

            try
            {
                // Delete Temporal Rule Set
                ServiceDocsTemporalRuleSetGetSingle result = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDelete(accountID, temporalRuleSetID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Temporal Rule Set
    ApiResponse<ServiceDocsTemporalRuleSetGetSingle> response = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDeleteWithHttpInfo(accountID, temporalRuleSetID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleSetID** | **string** | temporal rule set ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsTemporalRuleSetGetSingle**](ServiceDocsTemporalRuleSetGetSingle.md)

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

<a id="v1accountaccountidtemporalrulesettemporalrulesetidget"></a>
# **V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGet**
> ServiceDocsTemporalRuleSetGetSingle V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGet (string accountID, string temporalRuleSetID)

Get Temporal Rule Set Details

Acquire details about a temporal rule set in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleSetApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleSetID = "temporalRuleSetID_example";  // string | Temporal Ruleset ID, 32 alpha numeric

            try
            {
                // Get Temporal Rule Set Details
                ServiceDocsTemporalRuleSetGetSingle result = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGet(accountID, temporalRuleSetID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Temporal Rule Set Details
    ApiResponse<ServiceDocsTemporalRuleSetGetSingle> response = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGetWithHttpInfo(accountID, temporalRuleSetID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleSetID** | **string** | Temporal Ruleset ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsTemporalRuleSetGetSingle**](ServiceDocsTemporalRuleSetGetSingle.md)

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

<a id="v1accountaccountidtemporalrulesettemporalrulesetidput"></a>
# **V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPut**
> ServiceDocsTemporalRuleSetGetSingle V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPut (string accountID, string temporalRuleSetID, ServiceVOIPTemporalRuleSetAddEditData reqBody)

Update Temporal Rule Set

Efficiently adjust the temporal rule set in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemporalRuleSetApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var temporalRuleSetID = "temporalRuleSetID_example";  // string | Temporal Ruleset ID, 32 alpha numeric
            var reqBody = new ServiceVOIPTemporalRuleSetAddEditData(); // ServiceVOIPTemporalRuleSetAddEditData | payload fields

            try
            {
                // Update Temporal Rule Set
                ServiceDocsTemporalRuleSetGetSingle result = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPut(accountID, temporalRuleSetID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Temporal Rule Set
    ApiResponse<ServiceDocsTemporalRuleSetGetSingle> response = apiInstance.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPutWithHttpInfo(accountID, temporalRuleSetID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemporalRuleSetApi.V1AccountAccountIDTemporalrulesetTemporalRuleSetIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **temporalRuleSetID** | **string** | Temporal Ruleset ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPTemporalRuleSetAddEditData**](ServiceVOIPTemporalRuleSetAddEditData.md) | payload fields |  |

### Return type

[**ServiceDocsTemporalRuleSetGetSingle**](ServiceDocsTemporalRuleSetGetSingle.md)

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

