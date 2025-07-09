# Org.OpenAPITools.Api.AccountApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountidChildrenGet**](AccountApi.md#v1accountaccountidchildrenget) | **GET** /v1/account/{accountid}/children | Get Sub Account List |
| [**V1AccountAccountidDelete**](AccountApi.md#v1accountaccountiddelete) | **DELETE** /v1/account/{accountid} | Delete Account |
| [**V1AccountAccountidDnsrecordGet**](AccountApi.md#v1accountaccountiddnsrecordget) | **GET** /v1/account/{accountid}/dnsrecord | Get Account DNS Record |
| [**V1AccountAccountidDnsrecordPost**](AccountApi.md#v1accountaccountiddnsrecordpost) | **POST** /v1/account/{accountid}/dnsrecord | Create Account DNS Record |
| [**V1AccountAccountidDnsrecordPut**](AccountApi.md#v1accountaccountiddnsrecordput) | **PUT** /v1/account/{accountid}/dnsrecord | Convert Account DNS Record |
| [**V1AccountAccountidGet**](AccountApi.md#v1accountaccountidget) | **GET** /v1/account/{accountid} | Get Account Details |
| [**V1AccountAccountidLimitGet**](AccountApi.md#v1accountaccountidlimitget) | **GET** /v1/account/{accountid}/limit | Get Account Limits |
| [**V1AccountAccountidLimitPut**](AccountApi.md#v1accountaccountidlimitput) | **PUT** /v1/account/{accountid}/limit | Set Account Limits |
| [**V1AccountAccountidPost**](AccountApi.md#v1accountaccountidpost) | **POST** /v1/account/{accountid} | Create Sub Account |
| [**V1AccountAccountidProvisioningdetailsGet**](AccountApi.md#v1accountaccountidprovisioningdetailsget) | **GET** /v1/account/{accountid}/provisioningdetails | Get Account Provisioning Details |
| [**V1AccountAccountidProvisioningdetailsResetpwPut**](AccountApi.md#v1accountaccountidprovisioningdetailsresetpwput) | **PUT** /v1/account/{accountid}/provisioningdetails/resetpw | Reset the provisioning details password. |
| [**V1AccountAccountidPut**](AccountApi.md#v1accountaccountidput) | **PUT** /v1/account/{accountid} | Update Account |
| [**V1AccountApikeyGet**](AccountApi.md#v1accountapikeyget) | **GET** /v1/account/apikey |  |
| [**V1AccountGet**](AccountApi.md#v1accountget) | **GET** /v1/account | Get Account List |
| [**V1AccountPost**](AccountApi.md#v1accountpost) | **POST** /v1/account | Create Account |

<a id="v1accountaccountidchildrenget"></a>
# **V1AccountAccountidChildrenGet**
> ServiceDocsAccountGetAll V1AccountAccountidChildrenGet (string accountid, string? startKey = null, int? pageSize = null)

Get Sub Account List

Conveniently access the list of children accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidChildrenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Sub Account List
                ServiceDocsAccountGetAll result = apiInstance.V1AccountAccountidChildrenGet(accountid, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidChildrenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidChildrenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Sub Account List
    ApiResponse<ServiceDocsAccountGetAll> response = apiInstance.V1AccountAccountidChildrenGetWithHttpInfo(accountid, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidChildrenGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsAccountGetAll**](ServiceDocsAccountGetAll.md)

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

<a id="v1accountaccountiddelete"></a>
# **V1AccountAccountidDelete**
> ServiceDocsAccountGetSingle V1AccountAccountidDelete (string accountid)

Delete Account

Delete an account within your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Delete Account
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidDelete(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Account
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidDeleteWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountiddnsrecordget"></a>
# **V1AccountAccountidDnsrecordGet**
> ServiceDocsAccountGetSingle V1AccountAccountidDnsrecordGet (string accountid)

Get Account DNS Record

Get the DNS record of an account from the Route 53 entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDnsrecordGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account DNS Record
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidDnsrecordGet(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDnsrecordGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account DNS Record
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidDnsrecordGetWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountiddnsrecordpost"></a>
# **V1AccountAccountidDnsrecordPost**
> ServiceDocsAccountGetSingle V1AccountAccountidDnsrecordPost (string accountid)

Create Account DNS Record

Create the DNS record of an account with the help realm in the Route 53 entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDnsrecordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Create Account DNS Record
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidDnsrecordPost(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDnsrecordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account DNS Record
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidDnsrecordPostWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountiddnsrecordput"></a>
# **V1AccountAccountidDnsrecordPut**
> ServiceDocsAccountGetSingle V1AccountAccountidDnsrecordPut (string accountid, ServiceUpdateRecordTypeForAccount dnsrecord)

Convert Account DNS Record

Toggle the realm DNS record between srv and cname.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidDnsrecordPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var dnsrecord = new ServiceUpdateRecordTypeForAccount(); // ServiceUpdateRecordTypeForAccount | record type fields with value SRV, CNAME

            try
            {
                // Convert Account DNS Record
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidDnsrecordPut(accountid, dnsrecord);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidDnsrecordPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Convert Account DNS Record
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidDnsrecordPutWithHttpInfo(accountid, dnsrecord);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidDnsrecordPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **dnsrecord** | [**ServiceUpdateRecordTypeForAccount**](ServiceUpdateRecordTypeForAccount.md) | record type fields with value SRV, CNAME |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountidget"></a>
# **V1AccountAccountidGet**
> ServiceDocsAccountGetSingle V1AccountAccountidGet (string accountid)

Get Account Details

This endpoint will not allow for modifying or making updates, it will only allow users to view/retrieve details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Details
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidGet(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Details
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidGetWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountidlimitget"></a>
# **V1AccountAccountidLimitGet**
> ServiceDocsAccountLimit V1AccountAccountidLimitGet (string accountid)

Get Account Limits

Check the maximum number of inbound, outbound, and two-way trunks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidLimitGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Limits
                ServiceDocsAccountLimit result = apiInstance.V1AccountAccountidLimitGet(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidLimitGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidLimitGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Limits
    ApiResponse<ServiceDocsAccountLimit> response = apiInstance.V1AccountAccountidLimitGetWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidLimitGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountLimit**](ServiceDocsAccountLimit.md)

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

<a id="v1accountaccountidlimitput"></a>
# **V1AccountAccountidLimitPut**
> ServiceDocsAccountLimit V1AccountAccountidLimitPut (string accountid, ServiceVOIPAccountLimit2 limit)

Set Account Limits

Apply parameters to restrict access to inbound, outbound, and two-way trunks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidLimitPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var limit = new ServiceVOIPAccountLimit2(); // ServiceVOIPAccountLimit2 | account fields

            try
            {
                // Set Account Limits
                ServiceDocsAccountLimit result = apiInstance.V1AccountAccountidLimitPut(accountid, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidLimitPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidLimitPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Account Limits
    ApiResponse<ServiceDocsAccountLimit> response = apiInstance.V1AccountAccountidLimitPutWithHttpInfo(accountid, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidLimitPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **limit** | [**ServiceVOIPAccountLimit2**](ServiceVOIPAccountLimit2.md) | account fields |  |

### Return type

[**ServiceDocsAccountLimit**](ServiceDocsAccountLimit.md)

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

<a id="v1accountaccountidpost"></a>
# **V1AccountAccountidPost**
> ServiceDocsAccountGetSingle V1AccountAccountidPost (string accountid, ServiceVOIPAccountAddData account)

Create Sub Account

Establish a sub account to enable an administrator within your organization to create accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var account = new ServiceVOIPAccountAddData(); // ServiceVOIPAccountAddData | account fields

            try
            {
                // Create Sub Account
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidPost(accountid, account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Sub Account
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidPostWithHttpInfo(accountid, account);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **account** | [**ServiceVOIPAccountAddData**](ServiceVOIPAccountAddData.md) | account fields |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountaccountidprovisioningdetailsget"></a>
# **V1AccountAccountidProvisioningdetailsGet**
> ServiceDocsAccountProvisioning V1AccountAccountidProvisioningdetailsGet (string accountid)

Get Account Provisioning Details

Get the provisioning details of an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidProvisioningdetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Account Provisioning Details
                ServiceDocsAccountProvisioning result = apiInstance.V1AccountAccountidProvisioningdetailsGet(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidProvisioningdetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidProvisioningdetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Provisioning Details
    ApiResponse<ServiceDocsAccountProvisioning> response = apiInstance.V1AccountAccountidProvisioningdetailsGetWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidProvisioningdetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountProvisioning**](ServiceDocsAccountProvisioning.md)

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

<a id="v1accountaccountidprovisioningdetailsresetpwput"></a>
# **V1AccountAccountidProvisioningdetailsResetpwPut**
> ServiceDocsAccountProvisioning V1AccountAccountidProvisioningdetailsResetpwPut (string accountid)

Reset the provisioning details password.

Reset the existing provisioning details password and set it to a new one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidProvisioningdetailsResetpwPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Reset the provisioning details password.
                ServiceDocsAccountProvisioning result = apiInstance.V1AccountAccountidProvisioningdetailsResetpwPut(accountid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidProvisioningdetailsResetpwPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidProvisioningdetailsResetpwPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset the provisioning details password.
    ApiResponse<ServiceDocsAccountProvisioning> response = apiInstance.V1AccountAccountidProvisioningdetailsResetpwPutWithHttpInfo(accountid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidProvisioningdetailsResetpwPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsAccountProvisioning**](ServiceDocsAccountProvisioning.md)

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

<a id="v1accountaccountidput"></a>
# **V1AccountAccountidPut**
> ServiceDocsAccountGetSingle V1AccountAccountidPut (string accountid, ServiceVOIPAccountEditData account)

Update Account

Modify pertinent account data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var account = new ServiceVOIPAccountEditData(); // ServiceVOIPAccountEditData | account fields

            try
            {
                // Update Account
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountAccountidPut(accountid, account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountAccountidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Account
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountAccountidPutWithHttpInfo(accountid, account);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountAccountidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **account** | [**ServiceVOIPAccountEditData**](ServiceVOIPAccountEditData.md) | account fields |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

<a id="v1accountapikeyget"></a>
# **V1AccountApikeyGet**
> ServiceDocsAccountAPIKey V1AccountApikeyGet ()



Authenticate an application or user request to get the client ID and client secret for a CPaaS account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountApikeyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);

            try
            {
                ServiceDocsAccountAPIKey result = apiInstance.V1AccountApikeyGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountApikeyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountApikeyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServiceDocsAccountAPIKey> response = apiInstance.V1AccountApikeyGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountApikeyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ServiceDocsAccountAPIKey**](ServiceDocsAccountAPIKey.md)

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

<a id="v1accountget"></a>
# **V1AccountGet**
> ServiceDocsAccountGetAll V1AccountGet (string? startKey = null, int? pageSize = null)

Get Account List

Retrieve a list of all CPaaS accounts that exist within your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Account List
                ServiceDocsAccountGetAll result = apiInstance.V1AccountGet(startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account List
    ApiResponse<ServiceDocsAccountGetAll> response = apiInstance.V1AccountGetWithHttpInfo(startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startKey** | **string?** | start_key for pagination that was returned as next_start_key from your previous call | [optional]  |
| **pageSize** | **int?** | number of records to return, range 1 to 50 | [optional]  |

### Return type

[**ServiceDocsAccountGetAll**](ServiceDocsAccountGetAll.md)

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

<a id="v1accountpost"></a>
# **V1AccountPost**
> ServiceDocsAccountGetSingle V1AccountPost (ServiceVOIPAccountAddData account)

Create Account

Create an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountApi(config);
            var account = new ServiceVOIPAccountAddData(); // ServiceVOIPAccountAddData | account fields

            try
            {
                // Create Account
                ServiceDocsAccountGetSingle result = apiInstance.V1AccountPost(account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.V1AccountPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account
    ApiResponse<ServiceDocsAccountGetSingle> response = apiInstance.V1AccountPostWithHttpInfo(account);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.V1AccountPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **account** | [**ServiceVOIPAccountAddData**](ServiceVOIPAccountAddData.md) | account fields |  |

### Return type

[**ServiceDocsAccountGetSingle**](ServiceDocsAccountGetSingle.md)

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

