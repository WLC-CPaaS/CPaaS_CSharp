# Org.OpenAPITools.Api.MediaApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDMediaMediaIDFileGet**](MediaApi.md#v1accountaccountidmediamediaidfileget) | **GET** /v1/account/{accountID}/media/{mediaID}/file | Get Media File |
| [**V1AccountAccountIDMediaMediaIDFilePost**](MediaApi.md#v1accountaccountidmediamediaidfilepost) | **POST** /v1/account/{accountID}/media/{mediaID}/file | Add Media File |
| [**V1AccountAccountidMediaGet**](MediaApi.md#v1accountaccountidmediaget) | **GET** /v1/account/{accountid}/media | Get Media List |
| [**V1AccountAccountidMediaMediaidDelete**](MediaApi.md#v1accountaccountidmediamediaiddelete) | **DELETE** /v1/account/{accountid}/media/{mediaid} | Delete Media |
| [**V1AccountAccountidMediaMediaidGet**](MediaApi.md#v1accountaccountidmediamediaidget) | **GET** /v1/account/{accountid}/media/{mediaid} | Get Media Details |
| [**V1AccountAccountidMediaPost**](MediaApi.md#v1accountaccountidmediapost) | **POST** /v1/account/{accountid}/media | Create Media |

<a id="v1accountaccountidmediamediaidfileget"></a>
# **V1AccountAccountIDMediaMediaIDFileGet**
> System.IO.Stream V1AccountAccountIDMediaMediaIDFileGet (string accountID, string mediaID)

Get Media File

Gather data about the media objects in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMediaMediaIDFileGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var mediaID = "mediaID_example";  // string | Media ID, 32 alpha numeric

            try
            {
                // Get Media File
                System.IO.Stream result = apiInstance.V1AccountAccountIDMediaMediaIDFileGet(accountID, mediaID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountIDMediaMediaIDFileGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMediaMediaIDFileGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Media File
    ApiResponse<System.IO.Stream> response = apiInstance.V1AccountAccountIDMediaMediaIDFileGetWithHttpInfo(accountID, mediaID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountIDMediaMediaIDFileGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **mediaID** | **string** | Media ID, 32 alpha numeric |  |

### Return type

**System.IO.Stream**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, audio/mp3, audio/mpeg, audio/mpeg3, audio/x-wav, audio/wav, audio/ogg, video/x-flv, video/h264, video/mpeg, video/quicktime, video/mp4, video/webm


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidmediamediaidfilepost"></a>
# **V1AccountAccountIDMediaMediaIDFilePost**
> ServiceDocsMediaGetSingle V1AccountAccountIDMediaMediaIDFilePost (string accountID, string mediaID, System.IO.Stream file)

Add Media File

Include a media file that is connected to a media object in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDMediaMediaIDFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var mediaID = "mediaID_example";  // string | Media ID, 32 alpha numeric
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Media file

            try
            {
                // Add Media File
                ServiceDocsMediaGetSingle result = apiInstance.V1AccountAccountIDMediaMediaIDFilePost(accountID, mediaID, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountIDMediaMediaIDFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDMediaMediaIDFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Media File
    ApiResponse<ServiceDocsMediaGetSingle> response = apiInstance.V1AccountAccountIDMediaMediaIDFilePostWithHttpInfo(accountID, mediaID, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountIDMediaMediaIDFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **mediaID** | **string** | Media ID, 32 alpha numeric |  |
| **file** | **System.IO.Stream****System.IO.Stream** | Media file |  |

### Return type

[**ServiceDocsMediaGetSingle**](ServiceDocsMediaGetSingle.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1accountaccountidmediaget"></a>
# **V1AccountAccountidMediaGet**
> ServiceDocsMediaGetAll V1AccountAccountidMediaGet (string accountid, string? startKey = null, int? pageSize = null)

Get Media List

View all media files for an account in your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidMediaGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var startKey = "startKey_example";  // string? | start_key for pagination that was returned as next_start_key from your previous call (optional) 
            var pageSize = 56;  // int? | number of records to return, range 1 to 50 (optional) 

            try
            {
                // Get Media List
                ServiceDocsMediaGetAll result = apiInstance.V1AccountAccountidMediaGet(accountid, startKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidMediaGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Media List
    ApiResponse<ServiceDocsMediaGetAll> response = apiInstance.V1AccountAccountidMediaGetWithHttpInfo(accountid, startKey, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaGetWithHttpInfo: " + e.Message);
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

[**ServiceDocsMediaGetAll**](ServiceDocsMediaGetAll.md)

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

<a id="v1accountaccountidmediamediaiddelete"></a>
# **V1AccountAccountidMediaMediaidDelete**
> ServiceDocsMediaGetSingle V1AccountAccountidMediaMediaidDelete (string accountid, string mediaid)

Delete Media

Remove a media file that is no longer in use from an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidMediaMediaidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var mediaid = "mediaid_example";  // string | Device ID, 32 alpha numeric

            try
            {
                // Delete Media
                ServiceDocsMediaGetSingle result = apiInstance.V1AccountAccountidMediaMediaidDelete(accountid, mediaid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaMediaidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidMediaMediaidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Media
    ApiResponse<ServiceDocsMediaGetSingle> response = apiInstance.V1AccountAccountidMediaMediaidDeleteWithHttpInfo(accountid, mediaid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaMediaidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **mediaid** | **string** | Device ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMediaGetSingle**](ServiceDocsMediaGetSingle.md)

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

<a id="v1accountaccountidmediamediaidget"></a>
# **V1AccountAccountidMediaMediaidGet**
> ServiceDocsMediaGetSingle V1AccountAccountidMediaMediaidGet (string accountid, string mediaid)

Get Media Details

Permit users to view an account's specific media information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidMediaMediaidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var mediaid = "mediaid_example";  // string | Media ID, 32 alpha numeric

            try
            {
                // Get Media Details
                ServiceDocsMediaGetSingle result = apiInstance.V1AccountAccountidMediaMediaidGet(accountid, mediaid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaMediaidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidMediaMediaidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Media Details
    ApiResponse<ServiceDocsMediaGetSingle> response = apiInstance.V1AccountAccountidMediaMediaidGetWithHttpInfo(accountid, mediaid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaMediaidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **mediaid** | **string** | Media ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsMediaGetSingle**](ServiceDocsMediaGetSingle.md)

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

<a id="v1accountaccountidmediapost"></a>
# **V1AccountAccountidMediaPost**
> ServiceDocsMediaGetSingle V1AccountAccountidMediaPost (string accountid, ServiceVOIPMediaAddEditData media)

Create Media

Generate a media object to allow users to upload a media file in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountidMediaPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaApi(config);
            var accountid = "accountid_example";  // string | Account ID, 32 alpha numeric
            var media = new ServiceVOIPMediaAddEditData(); // ServiceVOIPMediaAddEditData | Media creation or update payload

            try
            {
                // Create Media
                ServiceDocsMediaGetSingle result = apiInstance.V1AccountAccountidMediaPost(accountid, media);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountidMediaPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Media
    ApiResponse<ServiceDocsMediaGetSingle> response = apiInstance.V1AccountAccountidMediaPostWithHttpInfo(accountid, media);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MediaApi.V1AccountAccountidMediaPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountid** | **string** | Account ID, 32 alpha numeric |  |
| **media** | [**ServiceVOIPMediaAddEditData**](ServiceVOIPMediaAddEditData.md) | Media creation or update payload |  |

### Return type

[**ServiceDocsMediaGetSingle**](ServiceDocsMediaGetSingle.md)

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

