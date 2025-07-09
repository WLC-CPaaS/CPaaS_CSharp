# Org.OpenAPITools.Api.DeviceApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountidDeviceDeviceidDelete**](DeviceApi.md#v1accountaccountiddevicedeviceiddelete) | **DELETE** /v1/account/{accountid}/device/{deviceid} | Delete Device |
| [**V1AccountAccountidDeviceDeviceidGet**](DeviceApi.md#v1accountaccountiddevicedeviceidget) | **GET** /v1/account/{accountid}/device/{deviceid} | Get Device Details |
| [**V1AccountAccountidDeviceDeviceidPut**](DeviceApi.md#v1accountaccountiddevicedeviceidput) | **PUT** /v1/account/{accountid}/device/{deviceid} | Update Device |
| [**V1AccountAccountidDeviceDeviceidRebootPost**](DeviceApi.md#v1accountaccountiddevicedeviceidrebootpost) | **POST** /v1/account/{accountid}/device/{deviceid}/reboot | Reboot Device |
| [**V1AccountAccountidDeviceGet**](DeviceApi.md#v1accountaccountiddeviceget) | **GET** /v1/account/{accountid}/device | Get Device List |
| [**V1AccountAccountidDevicePost**](DeviceApi.md#v1accountaccountiddevicepost) | **POST** /v1/account/{accountid}/device | Create Device |
| [**V1AccountAccountidDeviceStatusGet**](DeviceApi.md#v1accountaccountiddevicestatusget) | **GET** /v1/account/{accountid}/device/status | Get Device Status |

<a id="v1accountaccountiddevicedeviceiddelete"></a>
# **V1AccountAccountidDeviceDeviceidDelete**
> ServiceDocsDeviceGetSingle V1AccountAccountidDeviceDeviceidDelete (string accountid, string deviceid)

Delete Device

Remove one device from a CPaaS account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceDeviceidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var deviceid = "deviceid_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Delete Device
                ServiceDocsDeviceGetSingle result = apiInstance.V1AccountAccountidDeviceDeviceidDelete(accountid, deviceid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceDeviceidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Device
    ApiResponse<ServiceDocsDeviceGetSingle> response = apiInstance.V1AccountAccountidDeviceDeviceidDeleteWithHttpInfo(accountid, deviceid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **deviceid** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsDeviceGetSingle**](ServiceDocsDeviceGetSingle.md)

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

<a id="v1accountaccountiddevicedeviceidget"></a>
# **V1AccountAccountidDeviceDeviceidGet**
> ServiceDocsDeviceGetSingle V1AccountAccountidDeviceDeviceidGet (string accountid, string deviceid)

Get Device Details

Permit a user to view specific device details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceDeviceidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var deviceid = "deviceid_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Get Device Details
                ServiceDocsDeviceGetSingle result = apiInstance.V1AccountAccountidDeviceDeviceidGet(accountid, deviceid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceDeviceidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Device Details
    ApiResponse<ServiceDocsDeviceGetSingle> response = apiInstance.V1AccountAccountidDeviceDeviceidGetWithHttpInfo(accountid, deviceid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **deviceid** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsDeviceGetSingle**](ServiceDocsDeviceGetSingle.md)

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

<a id="v1accountaccountiddevicedeviceidput"></a>
# **V1AccountAccountidDeviceDeviceidPut**
> ServiceDocsDeviceGetSingle V1AccountAccountidDeviceDeviceidPut (string accountid, string deviceid, ServiceVOIPDeviceAddEdit2 device)

Update Device

Edit specifics about the device, such as the device type, name, and owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceDeviceidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var deviceid = "deviceid_example";  // string | Device ID, 32 alpha numeric
            var device = new ServiceVOIPDeviceAddEdit2(); // ServiceVOIPDeviceAddEdit2 | device fields

            try
            {
                // Update Device
                ServiceDocsDeviceGetSingle result = apiInstance.V1AccountAccountidDeviceDeviceidPut(accountid, deviceid, device);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceDeviceidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Device
    ApiResponse<ServiceDocsDeviceGetSingle> response = apiInstance.V1AccountAccountidDeviceDeviceidPutWithHttpInfo(accountid, deviceid, device);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **deviceid** | **string** | Device ID, 32 alpha numeric |  |
| **device** | [**ServiceVOIPDeviceAddEdit2**](ServiceVOIPDeviceAddEdit2.md) | device fields |  |

### Return type

[**ServiceDocsDeviceGetSingle**](ServiceDocsDeviceGetSingle.md)

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

<a id="v1accountaccountiddevicedeviceidrebootpost"></a>
# **V1AccountAccountidDeviceDeviceidRebootPost**
> ServiceDocsDeviceReboot V1AccountAccountidDeviceDeviceidRebootPost (string accountid, string deviceid)

Reboot Device

Reboot a device in an account to mitigate malware and improve device performance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceDeviceidRebootPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var deviceid = "deviceid_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Reboot Device
                ServiceDocsDeviceReboot result = apiInstance.V1AccountAccountidDeviceDeviceidRebootPost(accountid, deviceid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidRebootPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceDeviceidRebootPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reboot Device
    ApiResponse<ServiceDocsDeviceReboot> response = apiInstance.V1AccountAccountidDeviceDeviceidRebootPostWithHttpInfo(accountid, deviceid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceDeviceidRebootPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **deviceid** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsDeviceReboot**](ServiceDocsDeviceReboot.md)

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

<a id="v1accountaccountiddeviceget"></a>
# **V1AccountAccountidDeviceGet**
> ServiceDocsDeviceGetAll V1AccountAccountidDeviceGet (string accountid, string? startKey = null, int? pageSize = null)

Get Device List

Obtain a list of all devices associated with an account such as fax machines, cell phones, and soft phones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Device List
                ServiceDocsDeviceGetAll result = apiInstance.V1AccountAccountidDeviceGet(accountid, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Device List
    ApiResponse<ServiceDocsDeviceGetAll> response = apiInstance.V1AccountAccountidDeviceGetWithHttpInfo(accountid, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **startKey** | **string?** | start_key for pagination that was returned as next_start_key from your previous call | [optional]  |
| **pageSize** | **int?** | number of records to return, range 1 to 50 | [optional]  |

### Return type

[**ServiceDocsDeviceGetAll**](ServiceDocsDeviceGetAll.md)

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

<a id="v1accountaccountiddevicepost"></a>
# **V1AccountAccountidDevicePost**
> ServiceDocsDeviceGetSingle V1AccountAccountidDevicePost (string accountid, ServiceVOIPDeviceAddEdit2 device)

Create Device

Connect a new device to an account to enhance communication methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDevicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var device = new ServiceVOIPDeviceAddEdit2(); // ServiceVOIPDeviceAddEdit2 | device fields

            try
            {
                // Create Device
                ServiceDocsDeviceGetSingle result = apiInstance.V1AccountAccountidDevicePost(accountid, device);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDevicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDevicePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Device
    ApiResponse<ServiceDocsDeviceGetSingle> response = apiInstance.V1AccountAccountidDevicePostWithHttpInfo(accountid, device);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDevicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **device** | [**ServiceVOIPDeviceAddEdit2**](ServiceVOIPDeviceAddEdit2.md) | device fields |  |

### Return type

[**ServiceDocsDeviceGetSingle**](ServiceDocsDeviceGetSingle.md)

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

<a id="v1accountaccountiddevicestatusget"></a>
# **V1AccountAccountidDeviceStatusGet**
> ServiceDocsDeviceStatus V1AccountAccountidDeviceStatusGet (string accountid)

Get Device Status

Retrieve a device’s status (e.g., registered or not registered) in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeviceStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Device Status
                ServiceDocsDeviceStatus result = apiInstance.V1AccountAccountidDeviceStatusGet(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeviceStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Device Status
    ApiResponse<ServiceDocsDeviceStatus> response = apiInstance.V1AccountAccountidDeviceStatusGetWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.V1AccountAccountidDeviceStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsDeviceStatus**](ServiceDocsDeviceStatus.md)

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

