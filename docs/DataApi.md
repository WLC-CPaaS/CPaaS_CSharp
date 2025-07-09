# Org.OpenAPITools.Api.DataApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDCdrCdrIDGet**](DataApi.md#v1accountaccountidcdrcdridget) | **GET** /v1/account/{accountID}/cdr/{cdrID} | Get CDR Details |
| [**V1AccountAccountIDCdrGet**](DataApi.md#v1accountaccountidcdrget) | **GET** /v1/account/{accountID}/cdr | Get CDR List |
| [**V1DataCallDailySummaryGet**](DataApi.md#v1datacalldailysummaryget) | **GET** /v1/data/call_daily_summary | Get Call Daily Summary List |
| [**V1DataCallDetailGet**](DataApi.md#v1datacalldetailget) | **GET** /v1/data/call_detail | Get Call Detail List |
| [**V1DataCallMonthlySummaryGet**](DataApi.md#v1datacallmonthlysummaryget) | **GET** /v1/data/call_monthly_summary | Get Call Detail List |
| [**V1DataEndpointListGet**](DataApi.md#v1dataendpointlistget) | **GET** /v1/data/endpoint_list | Get Endpoint List |
| [**V1DataEventDailySummaryGet**](DataApi.md#v1dataeventdailysummaryget) | **GET** /v1/data/event_daily_summary | Get Event Daily Summary List |
| [**V1DataEventDetailGet**](DataApi.md#v1dataeventdetailget) | **GET** /v1/data/event_detail | Get Event Details |
| [**V1DataEventMonthlySummaryGet**](DataApi.md#v1dataeventmonthlysummaryget) | **GET** /v1/data/event_monthly_summary | Get Event Monthly Summary List |
| [**V1DataFeatureDailySummaryGet**](DataApi.md#v1datafeaturedailysummaryget) | **GET** /v1/data/feature_daily_summary | Get Feature Daily Summary List |
| [**V1DataFeatureMonthlySummaryGet**](DataApi.md#v1datafeaturemonthlysummaryget) | **GET** /v1/data/feature_monthly_summary | Get Feature Monthly Summary List |

<a id="v1accountaccountidcdrcdridget"></a>
# **V1AccountAccountIDCdrCdrIDGet**
> ServiceDocsCdrGetSingle V1AccountAccountIDCdrCdrIDGet (string accountID, string cdrID)

Get CDR Details

Retrieve the details of a single CDR record from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCdrCdrIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var cdrID = "cdrID_example";  // string | CDR ID, string

            try
            {
                // Get CDR Details
                ServiceDocsCdrGetSingle result = apiInstance.V1AccountAccountIDCdrCdrIDGet(accountID, cdrID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1AccountAccountIDCdrCdrIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCdrCdrIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CDR Details
    ApiResponse<ServiceDocsCdrGetSingle> response = apiInstance.V1AccountAccountIDCdrCdrIDGetWithHttpInfo(accountID, cdrID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1AccountAccountIDCdrCdrIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **cdrID** | **string** | CDR ID, string |  |

### Return type

[**ServiceDocsCdrGetSingle**](ServiceDocsCdrGetSingle.md)

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

<a id="v1accountaccountidcdrget"></a>
# **V1AccountAccountIDCdrGet**
> ServiceDocsCdrGetAll V1AccountAccountIDCdrGet (string accountID, string? pageSize = null, string? startKey = null, string? createdFrom = null, string? createdTo = null)

Get CDR List

Retrieve a list of CDRs in a specific account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDCdrGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var pageSize = "pageSize_example";  // string? | Page size (Maximum number of results to display per page) (optional) 
            var startKey = "startKey_example";  // string? | Start key (Starting offset for displaying results) (optional) 
            var createdFrom = "createdFrom_example";  // string? | For displaying records which are created on or after this timestamp (Supported timestamp formats: iso 8601, unix time in seconds or milliseconds or microseconds or nanoseconds) (optional) 
            var createdTo = "createdTo_example";  // string? | For displaying records which are created on or before this timestamp (Supported timestamp formats: iso 8601, unix time in seconds or milliseconds or microseconds or nanoseconds) (optional) 

            try
            {
                // Get CDR List
                ServiceDocsCdrGetAll result = apiInstance.V1AccountAccountIDCdrGet(accountID, pageSize, startKey, createdFrom, createdTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1AccountAccountIDCdrGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDCdrGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CDR List
    ApiResponse<ServiceDocsCdrGetAll> response = apiInstance.V1AccountAccountIDCdrGetWithHttpInfo(accountID, pageSize, startKey, createdFrom, createdTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1AccountAccountIDCdrGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **pageSize** | **string?** | Page size (Maximum number of results to display per page) | [optional]  |
| **startKey** | **string?** | Start key (Starting offset for displaying results) | [optional]  |
| **createdFrom** | **string?** | For displaying records which are created on or after this timestamp (Supported timestamp formats: iso 8601, unix time in seconds or milliseconds or microseconds or nanoseconds) | [optional]  |
| **createdTo** | **string?** | For displaying records which are created on or before this timestamp (Supported timestamp formats: iso 8601, unix time in seconds or milliseconds or microseconds or nanoseconds) | [optional]  |

### Return type

[**ServiceDocsCdrGetAll**](ServiceDocsCdrGetAll.md)

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

<a id="v1datacalldailysummaryget"></a>
# **V1DataCallDailySummaryGet**
> ServiceDocsCallDailySummary V1DataCallDailySummaryGet (string? accountId = null, string? callType = null, string? endDate = null, int? pageSize = null, string? startDate = null, string? startKey = null)

Get Call Daily Summary List

Retrieve a daily summary of calls, including the account ID that made or received a call, the call type, the month and year, the duration, and other relevant information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataCallDailySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountId = "accountId_example";  // string? |  (optional) 
            var callType = "callType_example";  // string? |  (optional) 
            var endDate = "endDate_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startDate = "startDate_example";  // string? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 

            try
            {
                // Get Call Daily Summary List
                ServiceDocsCallDailySummary result = apiInstance.V1DataCallDailySummaryGet(accountId, callType, endDate, pageSize, startDate, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataCallDailySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataCallDailySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Daily Summary List
    ApiResponse<ServiceDocsCallDailySummary> response = apiInstance.V1DataCallDailySummaryGetWithHttpInfo(accountId, callType, endDate, pageSize, startDate, startKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataCallDailySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** |  | [optional]  |
| **callType** | **string?** |  | [optional]  |
| **endDate** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startDate** | **string?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsCallDailySummary**](ServiceDocsCallDailySummary.md)

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

<a id="v1datacalldetailget"></a>
# **V1DataCallDetailGet**
> ServiceDocsCallDetail V1DataCallDetailGet (string? account = null, string? callType = null, string? calleeName = null, string? calleeNumber = null, string? callerName = null, string? callerNumber = null, string? endDate = null, int? pageSize = null, string? startDate = null, string? startKey = null)

Get Call Detail List

Retrieve specific details about a call (e.g., caller, recipient, date, time, duration, etc.).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataCallDetailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var account = "account_example";  // string? |  (optional) 
            var callType = "callType_example";  // string? |  (optional) 
            var calleeName = "calleeName_example";  // string? |  (optional) 
            var calleeNumber = "calleeNumber_example";  // string? |  (optional) 
            var callerName = "callerName_example";  // string? |  (optional) 
            var callerNumber = "callerNumber_example";  // string? |  (optional) 
            var endDate = "endDate_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startDate = "startDate_example";  // string? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 

            try
            {
                // Get Call Detail List
                ServiceDocsCallDetail result = apiInstance.V1DataCallDetailGet(account, callType, calleeName, calleeNumber, callerName, callerNumber, endDate, pageSize, startDate, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataCallDetailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataCallDetailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Detail List
    ApiResponse<ServiceDocsCallDetail> response = apiInstance.V1DataCallDetailGetWithHttpInfo(account, callType, calleeName, calleeNumber, callerName, callerNumber, endDate, pageSize, startDate, startKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataCallDetailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **account** | **string?** |  | [optional]  |
| **callType** | **string?** |  | [optional]  |
| **calleeName** | **string?** |  | [optional]  |
| **calleeNumber** | **string?** |  | [optional]  |
| **callerName** | **string?** |  | [optional]  |
| **callerNumber** | **string?** |  | [optional]  |
| **endDate** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startDate** | **string?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsCallDetail**](ServiceDocsCallDetail.md)

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

<a id="v1datacallmonthlysummaryget"></a>
# **V1DataCallMonthlySummaryGet**
> ServiceDocsCallMonthlySummary V1DataCallMonthlySummaryGet (string? account = null, string? callType = null, int? endMonth = null, int? endYear = null, int? pageSize = null, string? startKey = null, int? startMonth = null, int? startYear = null)

Get Call Detail List

Retrieve a monthly summary of calls, including which accounts made or received calls, the call type, and other relevant information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataCallMonthlySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var account = "account_example";  // string? |  (optional) 
            var callType = "callType_example";  // string? |  (optional) 
            var endMonth = 56;  // int? |  (optional) 
            var endYear = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var startMonth = 56;  // int? |  (optional) 
            var startYear = 56;  // int? |  (optional) 

            try
            {
                // Get Call Detail List
                ServiceDocsCallMonthlySummary result = apiInstance.V1DataCallMonthlySummaryGet(account, callType, endMonth, endYear, pageSize, startKey, startMonth, startYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataCallMonthlySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataCallMonthlySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Detail List
    ApiResponse<ServiceDocsCallMonthlySummary> response = apiInstance.V1DataCallMonthlySummaryGetWithHttpInfo(account, callType, endMonth, endYear, pageSize, startKey, startMonth, startYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataCallMonthlySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **account** | **string?** |  | [optional]  |
| **callType** | **string?** |  | [optional]  |
| **endMonth** | **int?** |  | [optional]  |
| **endYear** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **startMonth** | **int?** |  | [optional]  |
| **startYear** | **int?** |  | [optional]  |

### Return type

[**ServiceDocsCallMonthlySummary**](ServiceDocsCallMonthlySummary.md)

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

<a id="v1dataendpointlistget"></a>
# **V1DataEndpointListGet**
> ServiceDocsEndpointList V1DataEndpointListGet (string? endpointName = null, string? featureName = null, int? pageSize = null, string? startKey = null, string? transactionType = null, string? version = null)

Get Endpoint List

Access the endpoint list for each CPaaS API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataEndpointListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var endpointName = "endpointName_example";  // string? |  (optional) 
            var featureName = "featureName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var transactionType = "transactionType_example";  // string? |  (optional) 
            var version = "version_example";  // string? |  (optional) 

            try
            {
                // Get Endpoint List
                ServiceDocsEndpointList result = apiInstance.V1DataEndpointListGet(endpointName, featureName, pageSize, startKey, transactionType, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataEndpointListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataEndpointListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Endpoint List
    ApiResponse<ServiceDocsEndpointList> response = apiInstance.V1DataEndpointListGetWithHttpInfo(endpointName, featureName, pageSize, startKey, transactionType, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataEndpointListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endpointName** | **string?** |  | [optional]  |
| **featureName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **transactionType** | **string?** |  | [optional]  |
| **version** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsEndpointList**](ServiceDocsEndpointList.md)

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

<a id="v1dataeventdailysummaryget"></a>
# **V1DataEventDailySummaryGet**
> ServiceDocsEventDailySummary V1DataEventDailySummaryGet (string? accountId = null, string? component = null, string? endDate = null, int? pageSize = null, string? startDate = null, string? startKey = null)

Get Event Daily Summary List

Obtain a daily summary of events in a CPaaS account (e.g., setting/resetting the presence status for a user or extension).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataEventDailySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountId = "accountId_example";  // string? |  (optional) 
            var component = "component_example";  // string? |  (optional) 
            var endDate = "endDate_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startDate = "startDate_example";  // string? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 

            try
            {
                // Get Event Daily Summary List
                ServiceDocsEventDailySummary result = apiInstance.V1DataEventDailySummaryGet(accountId, component, endDate, pageSize, startDate, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataEventDailySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataEventDailySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Event Daily Summary List
    ApiResponse<ServiceDocsEventDailySummary> response = apiInstance.V1DataEventDailySummaryGetWithHttpInfo(accountId, component, endDate, pageSize, startDate, startKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataEventDailySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** |  | [optional]  |
| **component** | **string?** |  | [optional]  |
| **endDate** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startDate** | **string?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsEventDailySummary**](ServiceDocsEventDailySummary.md)

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

<a id="v1dataeventdetailget"></a>
# **V1DataEventDetailGet**
> ServiceDocsEventDetail V1DataEventDetailGet (string? accountId = null, string? component = null, string? endDateTime = null, string? eventName = null, string? execStatus = null, int? pageSize = null, string? startDateTime = null, string? startKey = null, string? username = null)

Get Event Details

Obtain specific details about an event (e.g., an E911 notification, a deleted account, or a created user).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataEventDetailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountId = "accountId_example";  // string? |  (optional) 
            var component = "component_example";  // string? |  (optional) 
            var endDateTime = "endDateTime_example";  // string? |  (optional) 
            var eventName = "eventName_example";  // string? |  (optional) 
            var execStatus = "execStatus_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startDateTime = "startDateTime_example";  // string? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var username = "username_example";  // string? |  (optional) 

            try
            {
                // Get Event Details
                ServiceDocsEventDetail result = apiInstance.V1DataEventDetailGet(accountId, component, endDateTime, eventName, execStatus, pageSize, startDateTime, startKey, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataEventDetailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataEventDetailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Event Details
    ApiResponse<ServiceDocsEventDetail> response = apiInstance.V1DataEventDetailGetWithHttpInfo(accountId, component, endDateTime, eventName, execStatus, pageSize, startDateTime, startKey, username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataEventDetailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** |  | [optional]  |
| **component** | **string?** |  | [optional]  |
| **endDateTime** | **string?** |  | [optional]  |
| **eventName** | **string?** |  | [optional]  |
| **execStatus** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startDateTime** | **string?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **username** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsEventDetail**](ServiceDocsEventDetail.md)

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

<a id="v1dataeventmonthlysummaryget"></a>
# **V1DataEventMonthlySummaryGet**
> ServiceDocsEventMonthlySummary V1DataEventMonthlySummaryGet (string? accountId = null, string? component = null, int? endMonth = null, int? endYear = null, int? pageSize = null, string? startKey = null, int? startMonth = null, int? startYear = null)

Get Event Monthly Summary List

Obtain a monthly summary of events in a CPaaS account (e.g., adding media files or assigning phone numbers).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataEventMonthlySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var accountId = "accountId_example";  // string? |  (optional) 
            var component = "component_example";  // string? |  (optional) 
            var endMonth = 56;  // int? |  (optional) 
            var endYear = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var startMonth = 56;  // int? |  (optional) 
            var startYear = 56;  // int? |  (optional) 

            try
            {
                // Get Event Monthly Summary List
                ServiceDocsEventMonthlySummary result = apiInstance.V1DataEventMonthlySummaryGet(accountId, component, endMonth, endYear, pageSize, startKey, startMonth, startYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataEventMonthlySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataEventMonthlySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Event Monthly Summary List
    ApiResponse<ServiceDocsEventMonthlySummary> response = apiInstance.V1DataEventMonthlySummaryGetWithHttpInfo(accountId, component, endMonth, endYear, pageSize, startKey, startMonth, startYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataEventMonthlySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** |  | [optional]  |
| **component** | **string?** |  | [optional]  |
| **endMonth** | **int?** |  | [optional]  |
| **endYear** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **startMonth** | **int?** |  | [optional]  |
| **startYear** | **int?** |  | [optional]  |

### Return type

[**ServiceDocsEventMonthlySummary**](ServiceDocsEventMonthlySummary.md)

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

<a id="v1datafeaturedailysummaryget"></a>
# **V1DataFeatureDailySummaryGet**
> ServiceDocsFeatureDailySummary V1DataFeatureDailySummaryGet (string? endDate = null, string? featureName = null, int? pageSize = null, string? startDate = null, string? startKey = null)

Get Feature Daily Summary List

Retrieve a daily summary about a feature, including usage, which accounts execute the steps, and other relevant information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataFeatureDailySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var endDate = "endDate_example";  // string? |  (optional) 
            var featureName = "featureName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startDate = "startDate_example";  // string? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 

            try
            {
                // Get Feature Daily Summary List
                ServiceDocsFeatureDailySummary result = apiInstance.V1DataFeatureDailySummaryGet(endDate, featureName, pageSize, startDate, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataFeatureDailySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataFeatureDailySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Feature Daily Summary List
    ApiResponse<ServiceDocsFeatureDailySummary> response = apiInstance.V1DataFeatureDailySummaryGetWithHttpInfo(endDate, featureName, pageSize, startDate, startKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataFeatureDailySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endDate** | **string?** |  | [optional]  |
| **featureName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startDate** | **string?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |

### Return type

[**ServiceDocsFeatureDailySummary**](ServiceDocsFeatureDailySummary.md)

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

<a id="v1datafeaturemonthlysummaryget"></a>
# **V1DataFeatureMonthlySummaryGet**
> ServiceDocsFeatureMonthlySummary V1DataFeatureMonthlySummaryGet (int? endMonth = null, int? endYear = null, string? featureName = null, int? pageSize = null, string? startKey = null, int? startMonth = null, int? startYear = null)

Get Feature Monthly Summary List

Retrieve a monthly summary about a feature’s usage, new users, updates, and other relevant information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1DataFeatureMonthlySummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataApi(config);
            var endMonth = 56;  // int? |  (optional) 
            var endYear = 56;  // int? |  (optional) 
            var featureName = "featureName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var startMonth = 56;  // int? |  (optional) 
            var startYear = 56;  // int? |  (optional) 

            try
            {
                // Get Feature Monthly Summary List
                ServiceDocsFeatureMonthlySummary result = apiInstance.V1DataFeatureMonthlySummaryGet(endMonth, endYear, featureName, pageSize, startKey, startMonth, startYear);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.V1DataFeatureMonthlySummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataFeatureMonthlySummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Feature Monthly Summary List
    ApiResponse<ServiceDocsFeatureMonthlySummary> response = apiInstance.V1DataFeatureMonthlySummaryGetWithHttpInfo(endMonth, endYear, featureName, pageSize, startKey, startMonth, startYear);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.V1DataFeatureMonthlySummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **endMonth** | **int?** |  | [optional]  |
| **endYear** | **int?** |  | [optional]  |
| **featureName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **startMonth** | **int?** |  | [optional]  |
| **startYear** | **int?** |  | [optional]  |

### Return type

[**ServiceDocsFeatureMonthlySummary**](ServiceDocsFeatureMonthlySummary.md)

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

