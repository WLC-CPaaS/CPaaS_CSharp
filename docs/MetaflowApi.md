# Org.OpenAPITools.Api.MetaflowApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDDeviceDeviceIDMetaflowDelete**](MetaflowApi.md#v1accountaccountiddevicedeviceidmetaflowdelete) | **DELETE** /v1/account/{accountID}/device/{deviceID}/metaflow | Delete Device Metaflow |
| [**V1AccountAccountIDDeviceDeviceIDMetaflowGet**](MetaflowApi.md#v1accountaccountiddevicedeviceidmetaflowget) | **GET** /v1/account/{accountID}/device/{deviceID}/metaflow | Get Device Metaflow List |
| [**V1AccountAccountIDDeviceDeviceIDMetaflowPost**](MetaflowApi.md#v1accountaccountiddevicedeviceidmetaflowpost) | **POST** /v1/account/{accountID}/device/{deviceID}/metaflow | Create Device Metaflow |
| [**V1AccountAccountIDMetaflowDelete**](MetaflowApi.md#v1accountaccountidmetaflowdelete) | **DELETE** /v1/account/{accountID}/metaflow | Delete Account Metaflow |
| [**V1AccountAccountIDMetaflowGet**](MetaflowApi.md#v1accountaccountidmetaflowget) | **GET** /v1/account/{accountID}/metaflow | Get Account Metaflow List |
| [**V1AccountAccountIDMetaflowPost**](MetaflowApi.md#v1accountaccountidmetaflowpost) | **POST** /v1/account/{accountID}/metaflow | Create Account Metaflow |
| [**V1AccountAccountIDUserUserIDMetaflowDelete**](MetaflowApi.md#v1accountaccountiduseruseridmetaflowdelete) | **DELETE** /v1/account/{accountID}/user/{userID}/metaflow | Delete User Metaflow |
| [**V1AccountAccountIDUserUserIDMetaflowGet**](MetaflowApi.md#v1accountaccountiduseruseridmetaflowget) | **GET** /v1/account/{accountID}/user/{userID}/metaflow | Get User Metaflow List |
| [**V1AccountAccountIDUserUserIDMetaflowPost**](MetaflowApi.md#v1accountaccountiduseruseridmetaflowpost) | **POST** /v1/account/{accountID}/user/{userID}/metaflow | Create User Metaflow |

<a id="v1accountaccountiddevicedeviceidmetaflowdelete"></a>
# **V1AccountAccountIDDeviceDeviceIDMetaflowDelete**
> ServiceDocsMetaflowGet V1AccountAccountIDDeviceDeviceIDMetaflowDelete (string accountID, string deviceID)

Delete Device Metaflow

Delete all metaflows associated with a device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDDeviceDeviceIDMetaflowDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var deviceID = "deviceID_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Delete Device Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowDelete(accountID, deviceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDDeviceDeviceIDMetaflowDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Device Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowDeleteWithHttpInfo(accountID, deviceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **deviceID** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountiddevicedeviceidmetaflowget"></a>
# **V1AccountAccountIDDeviceDeviceIDMetaflowGet**
> ServiceDocsMetaflowGet V1AccountAccountIDDeviceDeviceIDMetaflowGet (string accountID, string deviceID)

Get Device Metaflow List

Get the list of metaflows for a device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDDeviceDeviceIDMetaflowGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var deviceID = "deviceID_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Get Device Metaflow List
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowGet(accountID, deviceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDDeviceDeviceIDMetaflowGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Device Metaflow List
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowGetWithHttpInfo(accountID, deviceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **deviceID** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountiddevicedeviceidmetaflowpost"></a>
# **V1AccountAccountIDDeviceDeviceIDMetaflowPost**
> ServiceDocsMetaflowGet V1AccountAccountIDDeviceDeviceIDMetaflowPost (string accountID, string deviceID, ServiceVOIPMetaflowAddData reqBody)

Create Device Metaflow

Create a metaflow or multiple metaflows for a device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDDeviceDeviceIDMetaflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var deviceID = "deviceID_example";  // string | Device ID, 32 alpha numeric
            var reqBody = new ServiceVOIPMetaflowAddData(); // ServiceVOIPMetaflowAddData | payload fields

            try
            {
                // Create Device Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowPost(accountID, deviceID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDDeviceDeviceIDMetaflowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Device Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDDeviceDeviceIDMetaflowPostWithHttpInfo(accountID, deviceID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDDeviceDeviceIDMetaflowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **deviceID** | **string** | Device ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPMetaflowAddData**](ServiceVOIPMetaflowAddData.md) | payload fields |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountidmetaflowdelete"></a>
# **V1AccountAccountIDMetaflowDelete**
> ServiceDocsMetaflowGet V1AccountAccountIDMetaflowDelete (string accountID)

Delete Account Metaflow

Remove all metaflows from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMetaflowDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Delete Account Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDMetaflowDelete(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMetaflowDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Account Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDMetaflowDeleteWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountidmetaflowget"></a>
# **V1AccountAccountIDMetaflowGet**
> ServiceDocsMetaflowGet V1AccountAccountIDMetaflowGet (string accountID)

Get Account Metaflow List

Get an account's metaflow list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMetaflowGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Metaflow List
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDMetaflowGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMetaflowGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Metaflow List
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDMetaflowGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountidmetaflowpost"></a>
# **V1AccountAccountIDMetaflowPost**
> ServiceDocsMetaflowGet V1AccountAccountIDMetaflowPost (string accountID, ServiceVOIPMetaflowAddData metaflow)

Create Account Metaflow

Generate a metaflow for an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMetaflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID
            var metaflow = new ServiceVOIPMetaflowAddData(); // ServiceVOIPMetaflowAddData | Metaflow fields

            try
            {
                // Create Account Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDMetaflowPost(accountID, metaflow);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMetaflowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDMetaflowPostWithHttpInfo(accountID, metaflow);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDMetaflowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID |  |
| **metaflow** | [**ServiceVOIPMetaflowAddData**](ServiceVOIPMetaflowAddData.md) | Metaflow fields |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountiduseruseridmetaflowdelete"></a>
# **V1AccountAccountIDUserUserIDMetaflowDelete**
> ServiceDocsMetaflowGet V1AccountAccountIDUserUserIDMetaflowDelete (string accountID, string userID)

Delete User Metaflow

Delete all metaflows associated with a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDMetaflowDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | user ID, 32 alpha numeric

            try
            {
                // Delete User Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDUserUserIDMetaflowDelete(accountID, userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDMetaflowDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDUserUserIDMetaflowDeleteWithHttpInfo(accountID, userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **userID** | **string** | user ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountiduseruseridmetaflowget"></a>
# **V1AccountAccountIDUserUserIDMetaflowGet**
> ServiceDocsMetaflowGet V1AccountAccountIDUserUserIDMetaflowGet (string accountID, string userID)

Get User Metaflow List

Get the list of metaflows for a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDMetaflowGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | user ID, 32 alpha numeric

            try
            {
                // Get User Metaflow List
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDUserUserIDMetaflowGet(accountID, userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDMetaflowGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Metaflow List
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDUserUserIDMetaflowGetWithHttpInfo(accountID, userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **userID** | **string** | user ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

<a id="v1accountaccountiduseruseridmetaflowpost"></a>
# **V1AccountAccountIDUserUserIDMetaflowPost**
> ServiceDocsMetaflowGet V1AccountAccountIDUserUserIDMetaflowPost (string accountID, string userID, ServiceVOIPMetaflowAddData reqBody)

Create User Metaflow

Add a metaflow or multiple metaflows for a user in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDUserUserIDMetaflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaflowApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var userID = "userID_example";  // string | user ID, 32 alpha numeric
            var reqBody = new ServiceVOIPMetaflowAddData(); // ServiceVOIPMetaflowAddData | payload fields

            try
            {
                // Create User Metaflow
                ServiceDocsMetaflowGet result = apiInstance.V1AccountAccountIDUserUserIDMetaflowPost(accountID, userID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDUserUserIDMetaflowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create User Metaflow
    ApiResponse<ServiceDocsMetaflowGet> response = apiInstance.V1AccountAccountIDUserUserIDMetaflowPostWithHttpInfo(accountID, userID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetaflowApi.V1AccountAccountIDUserUserIDMetaflowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **userID** | **string** | user ID, 32 alpha numeric |  |
| **reqBody** | [**ServiceVOIPMetaflowAddData**](ServiceVOIPMetaflowAddData.md) | payload fields |  |

### Return type

[**ServiceDocsMetaflowGet**](ServiceDocsMetaflowGet.md)

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

