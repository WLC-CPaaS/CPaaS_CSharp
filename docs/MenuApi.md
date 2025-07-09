# Org.OpenAPITools.Api.MenuApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDMenuGet**](MenuApi.md#v1accountaccountidmenuget) | **GET** /v1/account/{accountID}/menu | Get Menu List |
| [**V1AccountAccountIDMenuMenuIDDelete**](MenuApi.md#v1accountaccountidmenumenuiddelete) | **DELETE** /v1/account/{accountID}/menu/{menuID} | Delete Menu |
| [**V1AccountAccountIDMenuMenuIDGet**](MenuApi.md#v1accountaccountidmenumenuidget) | **GET** /v1/account/{accountID}/menu/{menuID} | Get Menu Details |
| [**V1AccountAccountIDMenuMenuIDPut**](MenuApi.md#v1accountaccountidmenumenuidput) | **PUT** /v1/account/{accountID}/menu/{menuID} | Update Menu |
| [**V1AccountAccountIDMenuPost**](MenuApi.md#v1accountaccountidmenupost) | **POST** /v1/account/{accountID}/menu | Create Menu |

<a id="v1accountaccountidmenuget"></a>
# **V1AccountAccountIDMenuGet**
> MenuOutputList V1AccountAccountIDMenuGet (string accountID, string? startKey = null, int? pageSize = null)

Get Menu List

Users can access data about all menus in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMenuGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Menu List
                MenuOutputList result = apiInstance.V1AccountAccountIDMenuGet(accountID, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMenuGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Menu List
    ApiResponse<MenuOutputList> response = apiInstance.V1AccountAccountIDMenuGetWithHttpInfo(accountID, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuGetWithHttpInfo: " + e.Message);
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

[**MenuOutputList**](MenuOutputList.md)

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

<a id="v1accountaccountidmenumenuiddelete"></a>
# **V1AccountAccountIDMenuMenuIDDelete**
> MenuOutputDetail V1AccountAccountIDMenuMenuIDDelete (string accountID, string menuID)

Delete Menu

Delete a menu from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMenuMenuIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var menuID = "menuID_example";  // string | Menu ID, 32 alpha numeric

            try
            {
                // Delete Menu
                MenuOutputDetail result = apiInstance.V1AccountAccountIDMenuMenuIDDelete(accountID, menuID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMenuMenuIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Menu
    ApiResponse<MenuOutputDetail> response = apiInstance.V1AccountAccountIDMenuMenuIDDeleteWithHttpInfo(accountID, menuID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **menuID** | **string** | Menu ID, 32 alpha numeric |  |

### Return type

[**MenuOutputDetail**](MenuOutputDetail.md)

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

<a id="v1accountaccountidmenumenuidget"></a>
# **V1AccountAccountIDMenuMenuIDGet**
> MenuOutputDetail V1AccountAccountIDMenuMenuIDGet (string accountID, string menuID)

Get Menu Details

Get details about a menu in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMenuMenuIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var menuID = "menuID_example";  // string | Menu ID, 32 alpha numeric

            try
            {
                // Get Menu Details
                MenuOutputDetail result = apiInstance.V1AccountAccountIDMenuMenuIDGet(accountID, menuID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMenuMenuIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Menu Details
    ApiResponse<MenuOutputDetail> response = apiInstance.V1AccountAccountIDMenuMenuIDGetWithHttpInfo(accountID, menuID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **menuID** | **string** | Menu ID, 32 alpha numeric |  |

### Return type

[**MenuOutputDetail**](MenuOutputDetail.md)

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

<a id="v1accountaccountidmenumenuidput"></a>
# **V1AccountAccountIDMenuMenuIDPut**
> MenuOutputDetail V1AccountAccountIDMenuMenuIDPut (string accountID, string menuID, MenuInputData reqBody)

Update Menu

Edit an account menu.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMenuMenuIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var menuID = "menuID_example";  // string | Menu ID, 32 alpha numeric
            var reqBody = new MenuInputData(); // MenuInputData | payload fields

            try
            {
                // Update Menu
                MenuOutputDetail result = apiInstance.V1AccountAccountIDMenuMenuIDPut(accountID, menuID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMenuMenuIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Menu
    ApiResponse<MenuOutputDetail> response = apiInstance.V1AccountAccountIDMenuMenuIDPutWithHttpInfo(accountID, menuID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuMenuIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **menuID** | **string** | Menu ID, 32 alpha numeric |  |
| **reqBody** | [**MenuInputData**](MenuInputData.md) | payload fields |  |

### Return type

[**MenuOutputDetail**](MenuOutputDetail.md)

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

<a id="v1accountaccountidmenupost"></a>
# **V1AccountAccountIDMenuPost**
> MenuOutputDetail V1AccountAccountIDMenuPost (string accountID, MenuInputData menu)

Create Menu

Create a new menu for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMenuPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alphanumeric
            var menu = new MenuInputData(); // MenuInputData | Menu data

            try
            {
                // Create Menu
                MenuOutputDetail result = apiInstance.V1AccountAccountIDMenuPost(accountID, menu);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMenuPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Menu
    ApiResponse<MenuOutputDetail> response = apiInstance.V1AccountAccountIDMenuPostWithHttpInfo(accountID, menu);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MenuApi.V1AccountAccountIDMenuPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alphanumeric |  |
| **menu** | [**MenuInputData**](MenuInputData.md) | Menu data |  |

### Return type

[**MenuOutputDetail**](MenuOutputDetail.md)

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

