# Org.OpenAPITools.Api.VoIPUserApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountidUserGet**](VoIPUserApi.md#v1accountaccountiduserget) | **GET** /v1/account/{accountid}/user | Get User List |
| [**V1AccountAccountidUserPost**](VoIPUserApi.md#v1accountaccountiduserpost) | **POST** /v1/account/{accountid}/user | Create User |
| [**V1AccountAccountidUserUseridDelete**](VoIPUserApi.md#v1accountaccountiduseruseriddelete) | **DELETE** /v1/account/{accountid}/user/{userid} | Delete User |
| [**V1AccountAccountidUserUseridGet**](VoIPUserApi.md#v1accountaccountiduseruseridget) | **GET** /v1/account/{accountid}/user/{userid} | Get User Details |
| [**V1AccountAccountidUserUseridPut**](VoIPUserApi.md#v1accountaccountiduseruseridput) | **PUT** /v1/account/{accountid}/user/{userid} | Update User |
| [**V1AccountAccountidUserUseridUserauthPost**](VoIPUserApi.md#v1accountaccountiduseruseriduserauthpost) | **POST** /v1/account/{accountid}/user/{userid}/userauth | Impersonate a User |

<a id="v1accountaccountiduserget"></a>
# **V1AccountAccountidUserGet**
> ServiceDocsUserGetAll V1AccountAccountidUserGet (string accountid, string? startKey = null, int? pageSize = null)

Get User List

Get a list of all VoIP users that includes first and last names, email addresses, extensions, and account statuses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get User List
                ServiceDocsUserGetAll result = apiInstance.V1AccountAccountidUserGet(accountid, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User List
    ApiResponse<ServiceDocsUserGetAll> response = apiInstance.V1AccountAccountidUserGetWithHttpInfo(accountid, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsUserGetAll**](ServiceDocsUserGetAll.md)

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

<a id="v1accountaccountiduserpost"></a>
# **V1AccountAccountidUserPost**
> ServiceDocsUserGetSingle V1AccountAccountidUserPost (string accountid, ServiceVOIPUserAdd2 user)

Create User

Add new users to the account. When a user is added, the system generates their unique 32 alpha numeric ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var user = new ServiceVOIPUserAdd2(); // ServiceVOIPUserAdd2 | user fields

            try
            {
                // Create User
                ServiceDocsUserGetSingle result = apiInstance.V1AccountAccountidUserPost(accountid, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create User
    ApiResponse<ServiceDocsUserGetSingle> response = apiInstance.V1AccountAccountidUserPostWithHttpInfo(accountid, user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **user** | [**ServiceVOIPUserAdd2**](ServiceVOIPUserAdd2.md) | user fields |  |

### Return type

[**ServiceDocsUserGetSingle**](ServiceDocsUserGetSingle.md)

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

<a id="v1accountaccountiduseruseriddelete"></a>
# **V1AccountAccountidUserUseridDelete**
> ServiceDocsUserGetSingle V1AccountAccountidUserUseridDelete (string accountid, string userid)

Delete User

Delete VoIP user access to maintain the security of your accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserUseridDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var userid = "userid_example";  // string | User ID, 32 alpha numeric

            try
            {
                // Delete User
                ServiceDocsUserGetSingle result = apiInstance.V1AccountAccountidUserUseridDelete(accountid, userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserUseridDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User
    ApiResponse<ServiceDocsUserGetSingle> response = apiInstance.V1AccountAccountidUserUseridDeleteWithHttpInfo(accountid, userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **userid** | **string** | User ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsUserGetSingle**](ServiceDocsUserGetSingle.md)

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

<a id="v1accountaccountiduseruseridget"></a>
# **V1AccountAccountidUserUseridGet**
> ServiceDocsUserGetSingle V1AccountAccountidUserUseridGet (string accountid, string userid)

Get User Details

View specific user details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserUseridGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var userid = "userid_example";  // string | User ID, 32 alpha numeric

            try
            {
                // Get User Details
                ServiceDocsUserGetSingle result = apiInstance.V1AccountAccountidUserUseridGet(accountid, userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserUseridGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Details
    ApiResponse<ServiceDocsUserGetSingle> response = apiInstance.V1AccountAccountidUserUseridGetWithHttpInfo(accountid, userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **userid** | **string** | User ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsUserGetSingle**](ServiceDocsUserGetSingle.md)

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

<a id="v1accountaccountiduseruseridput"></a>
# **V1AccountAccountidUserUseridPut**
> ServiceDocsUserGetSingle V1AccountAccountidUserUseridPut (string accountid, string userid, ServiceVOIPUserAdd2 user)

Update User

Keep user information current. Modify the first and last name, extension, and other pertinent information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserUseridPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var userid = "userid_example";  // string | User ID, 32 alpha numeric
            var user = new ServiceVOIPUserAdd2(); // ServiceVOIPUserAdd2 | user fields

            try
            {
                // Update User
                ServiceDocsUserGetSingle result = apiInstance.V1AccountAccountidUserUseridPut(accountid, userid, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserUseridPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User
    ApiResponse<ServiceDocsUserGetSingle> response = apiInstance.V1AccountAccountidUserUseridPutWithHttpInfo(accountid, userid, user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **userid** | **string** | User ID, 32 alpha numeric |  |
| **user** | [**ServiceVOIPUserAdd2**](ServiceVOIPUserAdd2.md) | user fields |  |

### Return type

[**ServiceDocsUserGetSingle**](ServiceDocsUserGetSingle.md)

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

<a id="v1accountaccountiduseruseriduserauthpost"></a>
# **V1AccountAccountidUserUseridUserauthPost**
> ServiceDocsImpersonateUserGetSingle V1AccountAccountidUserUseridUserauthPost (string accountid, string userid, ServiceVOIPImpersonateUser user)

Impersonate a User

Retrieve a token for making presence calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidUserUseridUserauthPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoIPUserApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var userid = "userid_example";  // string | User ID, 32 alpha numeric
            var user = new ServiceVOIPImpersonateUser(); // ServiceVOIPImpersonateUser | Payload for impersonate a user

            try
            {
                // Impersonate a User
                ServiceDocsImpersonateUserGetSingle result = apiInstance.V1AccountAccountidUserUseridUserauthPost(accountid, userid, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridUserauthPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidUserUseridUserauthPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Impersonate a User
    ApiResponse<ServiceDocsImpersonateUserGetSingle> response = apiInstance.V1AccountAccountidUserUseridUserauthPostWithHttpInfo(accountid, userid, user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoIPUserApi.V1AccountAccountidUserUseridUserauthPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **userid** | **string** | User ID, 32 alpha numeric |  |
| **user** | [**ServiceVOIPImpersonateUser**](ServiceVOIPImpersonateUser.md) | Payload for impersonate a user |  |

### Return type

[**ServiceDocsImpersonateUserGetSingle**](ServiceDocsImpersonateUserGetSingle.md)

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

