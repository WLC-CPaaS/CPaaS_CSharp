# Org.OpenAPITools.Api.PhoneNumberApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountidPhonenumberGet**](PhoneNumberApi.md#v1accountaccountidphonenumberget) | **GET** /v1/account/{accountid}/phonenumber | Get Assigned Numbers List |
| [**V1AccountPhonenumberAssignPost**](PhoneNumberApi.md#v1accountphonenumberassignpost) | **POST** /v1/account/phonenumber/assign | Assign Number |
| [**V1AccountPhonenumberDisconnectPost**](PhoneNumberApi.md#v1accountphonenumberdisconnectpost) | **POST** /v1/account/phonenumber/disconnect | Disconnect Number |
| [**V1AccountPhonenumberGet**](PhoneNumberApi.md#v1accountphonenumberget) | **GET** /v1/account/phonenumber | Get Unassigned Numbers List |
| [**V1AccountPhonenumberPost**](PhoneNumberApi.md#v1accountphonenumberpost) | **POST** /v1/account/phonenumber | Purchase Number |
| [**V1AccountPhonenumberUnassignPost**](PhoneNumberApi.md#v1accountphonenumberunassignpost) | **POST** /v1/account/phonenumber/unassign | Unassign Number |
| [**V1PhonenumberSearchGet**](PhoneNumberApi.md#v1phonenumbersearchget) | **GET** /v1/phonenumber/search | Search New Numbers |

<a id="v1accountaccountidphonenumberget"></a>
# **V1AccountAccountidPhonenumberGet**
> ServiceDocsAccountPhonenumberGetAll V1AccountAccountidPhonenumberGet (string accountid, string? startKey = null, int? pageSize = null)

Get Assigned Numbers List

Access all phone numbers assigned to a CPaaS account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidPhonenumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | Start key for pagination, obtained from previous responses (optional) 
            var pageSize = 56;  // int? | Number of records to return per page (range: 1 to 50) (optional) 

            try
            {
                // Get Assigned Numbers List
                ServiceDocsAccountPhonenumberGetAll result = apiInstance.V1AccountAccountidPhonenumberGet(accountid, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountAccountidPhonenumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidPhonenumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Assigned Numbers List
    ApiResponse<ServiceDocsAccountPhonenumberGetAll> response = apiInstance.V1AccountAccountidPhonenumberGetWithHttpInfo(accountid, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountAccountidPhonenumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **startKey** | **string?** | Start key for pagination, obtained from previous responses | [optional]  |
| **pageSize** | **int?** | Number of records to return per page (range: 1 to 50) | [optional]  |

### Return type

[**ServiceDocsAccountPhonenumberGetAll**](ServiceDocsAccountPhonenumberGetAll.md)

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

<a id="v1accountphonenumberassignpost"></a>
# **V1AccountPhonenumberAssignPost**
> ServiceAPIResponseStatusCodeOnly V1AccountPhonenumberAssignPost (ServiceDocsPhonenumberAssignPayload payload)

Assign Number

Assign a purchased phone number to an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPhonenumberAssignPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var payload = new ServiceDocsPhonenumberAssignPayload(); // ServiceDocsPhonenumberAssignPayload | assignment payload

            try
            {
                // Assign Number
                ServiceAPIResponseStatusCodeOnly result = apiInstance.V1AccountPhonenumberAssignPost(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberAssignPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPhonenumberAssignPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign Number
    ApiResponse<ServiceAPIResponseStatusCodeOnly> response = apiInstance.V1AccountPhonenumberAssignPostWithHttpInfo(payload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberAssignPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payload** | [**ServiceDocsPhonenumberAssignPayload**](ServiceDocsPhonenumberAssignPayload.md) | assignment payload |  |

### Return type

[**ServiceAPIResponseStatusCodeOnly**](ServiceAPIResponseStatusCodeOnly.md)

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

<a id="v1accountphonenumberdisconnectpost"></a>
# **V1AccountPhonenumberDisconnectPost**
> ServiceAPIResponseStatusCodeOnly V1AccountPhonenumberDisconnectPost (ServiceDocsPhonenumberUnassignPayload payload)

Disconnect Number

Disconnecting a phone number from a CPaaS account relinquishes ownership of the number back to the carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPhonenumberDisconnectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var payload = new ServiceDocsPhonenumberUnassignPayload(); // ServiceDocsPhonenumberUnassignPayload | disconnect payload

            try
            {
                // Disconnect Number
                ServiceAPIResponseStatusCodeOnly result = apiInstance.V1AccountPhonenumberDisconnectPost(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberDisconnectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPhonenumberDisconnectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disconnect Number
    ApiResponse<ServiceAPIResponseStatusCodeOnly> response = apiInstance.V1AccountPhonenumberDisconnectPostWithHttpInfo(payload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberDisconnectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payload** | [**ServiceDocsPhonenumberUnassignPayload**](ServiceDocsPhonenumberUnassignPayload.md) | disconnect payload |  |

### Return type

[**ServiceAPIResponseStatusCodeOnly**](ServiceAPIResponseStatusCodeOnly.md)

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

<a id="v1accountphonenumberget"></a>
# **V1AccountPhonenumberGet**
> ServiceDocsAccountPhonenumberGetAll V1AccountPhonenumberGet (string? startKey = null, int? pageSize = null)

Get Unassigned Numbers List

Obtain all phone numbers that have not been assigned to a CPaaS account within your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPhonenumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var startKey = "startKey_example";  // string? | Start key for pagination, obtained from previous responses (optional) 
            var pageSize = 56;  // int? | Number of records to return per page (range: 1 to 50) (optional) 

            try
            {
                // Get Unassigned Numbers List
                ServiceDocsAccountPhonenumberGetAll result = apiInstance.V1AccountPhonenumberGet(startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPhonenumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Unassigned Numbers List
    ApiResponse<ServiceDocsAccountPhonenumberGetAll> response = apiInstance.V1AccountPhonenumberGetWithHttpInfo(startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startKey** | **string?** | Start key for pagination, obtained from previous responses | [optional]  |
| **pageSize** | **int?** | Number of records to return per page (range: 1 to 50) | [optional]  |

### Return type

[**ServiceDocsAccountPhonenumberGetAll**](ServiceDocsAccountPhonenumberGetAll.md)

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

<a id="v1accountphonenumberpost"></a>
# **V1AccountPhonenumberPost**
> ServiceDocsOrderPhonenumber V1AccountPhonenumberPost (List<string> phonenumber)

Purchase Number

Purchase or activate a phone number for CPaaS accounts within your business.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPhonenumberPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var phonenumber = new List<string>(); // List<string> | phonenumber fields

            try
            {
                // Purchase Number
                ServiceDocsOrderPhonenumber result = apiInstance.V1AccountPhonenumberPost(phonenumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPhonenumberPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase Number
    ApiResponse<ServiceDocsOrderPhonenumber> response = apiInstance.V1AccountPhonenumberPostWithHttpInfo(phonenumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phonenumber** | [**List&lt;string&gt;**](string.md) | phonenumber fields |  |

### Return type

[**ServiceDocsOrderPhonenumber**](ServiceDocsOrderPhonenumber.md)

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

<a id="v1accountphonenumberunassignpost"></a>
# **V1AccountPhonenumberUnassignPost**
> ServiceAPIResponseStatusCodeOnly V1AccountPhonenumberUnassignPost (ServiceDocsPhonenumberUnassignPayload payload)

Unassign Number

Remove a phone number from an account and place it back on the list of unassigned phone numbers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountPhonenumberUnassignPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var payload = new ServiceDocsPhonenumberUnassignPayload(); // ServiceDocsPhonenumberUnassignPayload | unassign payload

            try
            {
                // Unassign Number
                ServiceAPIResponseStatusCodeOnly result = apiInstance.V1AccountPhonenumberUnassignPost(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberUnassignPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountPhonenumberUnassignPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unassign Number
    ApiResponse<ServiceAPIResponseStatusCodeOnly> response = apiInstance.V1AccountPhonenumberUnassignPostWithHttpInfo(payload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1AccountPhonenumberUnassignPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payload** | [**ServiceDocsPhonenumberUnassignPayload**](ServiceDocsPhonenumberUnassignPayload.md) | unassign payload |  |

### Return type

[**ServiceAPIResponseStatusCodeOnly**](ServiceAPIResponseStatusCodeOnly.md)

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

<a id="v1phonenumbersearchget"></a>
# **V1PhonenumberSearchGet**
> ServiceDocsPhonenumberSearchGetAll V1PhonenumberSearchGet (string areaCode, int? quantity = null)

Search New Numbers

Conduct a search for available phone numbers for purchase within an area code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1PhonenumberSearchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumberApi(config);
            var areaCode = "areaCode_example";  // string | Area code (exactly 3 numeric characters) example: 610 or 484
            var quantity = 100;  // int? | Number of records to return (range: 1 to 100, defaults to 100 if not provided) (optional)  (default to 100)

            try
            {
                // Search New Numbers
                ServiceDocsPhonenumberSearchGetAll result = apiInstance.V1PhonenumberSearchGet(areaCode, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.V1PhonenumberSearchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1PhonenumberSearchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search New Numbers
    ApiResponse<ServiceDocsPhonenumberSearchGetAll> response = apiInstance.V1PhonenumberSearchGetWithHttpInfo(areaCode, quantity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberApi.V1PhonenumberSearchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaCode** | **string** | Area code (exactly 3 numeric characters) example: 610 or 484 |  |
| **quantity** | **int?** | Number of records to return (range: 1 to 100, defaults to 100 if not provided) | [optional] [default to 100] |

### Return type

[**ServiceDocsPhonenumberSearchGetAll**](ServiceDocsPhonenumberSearchGetAll.md)

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

