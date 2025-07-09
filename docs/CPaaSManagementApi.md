# Org.OpenAPITools.Api.CPaaSManagementApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1MgmtUserGet**](CPaaSManagementApi.md#v1mgmtuserget) | **GET** /v1/mgmt/user | Get All CPaaS Users |
| [**V1MgmtUserPost**](CPaaSManagementApi.md#v1mgmtuserpost) | **POST** /v1/mgmt/user | Invite CPaaS User |
| [**V1MgmtUserUserIDDelete**](CPaaSManagementApi.md#v1mgmtuseruseriddelete) | **DELETE** /v1/mgmt/user/{userID} | Delete CPaaS User |
| [**V1MgmtUserUserIDGet**](CPaaSManagementApi.md#v1mgmtuseruseridget) | **GET** /v1/mgmt/user/{userID} | Get CPaaS User Details |
| [**V1MgmtUserUserIDPut**](CPaaSManagementApi.md#v1mgmtuseruseridput) | **PUT** /v1/mgmt/user/{userID} | Update CPaaS User Role |

<a id="v1mgmtuserget"></a>
# **V1MgmtUserGet**
> ServiceDocsAdminUserGetAll V1MgmtUserGet (int? pageSize = null, string? startKey = null, string? sort = null, string? email = null, string? role = null, string? firstName = null, string? lastName = null)

Get All CPaaS Users

Retrieve a list of all CPaaS users in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1MgmtUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CPaaSManagementApi(config);
            var pageSize = 56;  // int? | number of records to return, range 1 to 100 (optional) 
            var startKey = "startKey_example";  // string? | unique to fetch next records (optional) 
            var sort = "sort_example";  // string? | sorting the records by email(default)/role/first_name/last_name, _A is for ascending and _D is for descending, eg: sort=role_A,email_D (optional) 
            var email = "email_example";  // string? | Email (optional) 
            var role = "role_example";  // string? | User Role (optional) 
            var firstName = "firstName_example";  // string? | First Name (optional) 
            var lastName = "lastName_example";  // string? | Last Name (optional) 

            try
            {
                // Get All CPaaS Users
                ServiceDocsAdminUserGetAll result = apiInstance.V1MgmtUserGet(pageSize, startKey, sort, email, role, firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1MgmtUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All CPaaS Users
    ApiResponse<ServiceDocsAdminUserGetAll> response = apiInstance.V1MgmtUserGetWithHttpInfo(pageSize, startKey, sort, email, role, firstName, lastName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** | number of records to return, range 1 to 100 | [optional]  |
| **startKey** | **string?** | unique to fetch next records | [optional]  |
| **sort** | **string?** | sorting the records by email(default)/role/first_name/last_name, _A is for ascending and _D is for descending, eg: sort&#x3D;role_A,email_D | [optional]  |
| **email** | **string?** | Email | [optional]  |
| **role** | **string?** | User Role | [optional]  |
| **firstName** | **string?** | First Name | [optional]  |
| **lastName** | **string?** | Last Name | [optional]  |

### Return type

[**ServiceDocsAdminUserGetAll**](ServiceDocsAdminUserGetAll.md)

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

<a id="v1mgmtuserpost"></a>
# **V1MgmtUserPost**
> ServiceDocsAdminUserGetSingle V1MgmtUserPost (ServiceAdminUserAddData reqBody)

Invite CPaaS User

Link a new CPaaS user to an existing client account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1MgmtUserPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CPaaSManagementApi(config);
            var reqBody = new ServiceAdminUserAddData(); // ServiceAdminUserAddData | payload fields

            try
            {
                // Invite CPaaS User
                ServiceDocsAdminUserGetSingle result = apiInstance.V1MgmtUserPost(reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1MgmtUserPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite CPaaS User
    ApiResponse<ServiceDocsAdminUserGetSingle> response = apiInstance.V1MgmtUserPostWithHttpInfo(reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reqBody** | [**ServiceAdminUserAddData**](ServiceAdminUserAddData.md) | payload fields |  |

### Return type

[**ServiceDocsAdminUserGetSingle**](ServiceDocsAdminUserGetSingle.md)

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

<a id="v1mgmtuseruseriddelete"></a>
# **V1MgmtUserUserIDDelete**
> ServiceDocsAdminUserDelete V1MgmtUserUserIDDelete (string userID)

Delete CPaaS User

Delete a CPaaS user from the associated account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1MgmtUserUserIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CPaaSManagementApi(config);
            var userID = "userID_example";  // string | User ID, numeric

            try
            {
                // Delete CPaaS User
                ServiceDocsAdminUserDelete result = apiInstance.V1MgmtUserUserIDDelete(userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1MgmtUserUserIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete CPaaS User
    ApiResponse<ServiceDocsAdminUserDelete> response = apiInstance.V1MgmtUserUserIDDeleteWithHttpInfo(userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userID** | **string** | User ID, numeric |  |

### Return type

[**ServiceDocsAdminUserDelete**](ServiceDocsAdminUserDelete.md)

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

<a id="v1mgmtuseruseridget"></a>
# **V1MgmtUserUserIDGet**
> ServiceDocsAdminUserGetSingle V1MgmtUserUserIDGet (string userID)

Get CPaaS User Details

View details about each CPaaS user in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1MgmtUserUserIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CPaaSManagementApi(config);
            var userID = "userID_example";  // string | User ID, numeric

            try
            {
                // Get CPaaS User Details
                ServiceDocsAdminUserGetSingle result = apiInstance.V1MgmtUserUserIDGet(userID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1MgmtUserUserIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CPaaS User Details
    ApiResponse<ServiceDocsAdminUserGetSingle> response = apiInstance.V1MgmtUserUserIDGetWithHttpInfo(userID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userID** | **string** | User ID, numeric |  |

### Return type

[**ServiceDocsAdminUserGetSingle**](ServiceDocsAdminUserGetSingle.md)

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

<a id="v1mgmtuseruseridput"></a>
# **V1MgmtUserUserIDPut**
> ServiceDocsAdminUserGetSingle V1MgmtUserUserIDPut (string userID, ServiceAdminUserEditData reqBody)

Update CPaaS User Role

Update a CPaaS user's role within a client's account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1MgmtUserUserIDPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CPaaSManagementApi(config);
            var userID = "userID_example";  // string | User ID, numeric
            var reqBody = new ServiceAdminUserEditData(); // ServiceAdminUserEditData | payload fields

            try
            {
                // Update CPaaS User Role
                ServiceDocsAdminUserGetSingle result = apiInstance.V1MgmtUserUserIDPut(userID, reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1MgmtUserUserIDPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update CPaaS User Role
    ApiResponse<ServiceDocsAdminUserGetSingle> response = apiInstance.V1MgmtUserUserIDPutWithHttpInfo(userID, reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CPaaSManagementApi.V1MgmtUserUserIDPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userID** | **string** | User ID, numeric |  |
| **reqBody** | [**ServiceAdminUserEditData**](ServiceAdminUserEditData.md) | payload fields |  |

### Return type

[**ServiceDocsAdminUserGetSingle**](ServiceDocsAdminUserGetSingle.md)

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

