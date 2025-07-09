# Org.OpenAPITools.Api.CallParkApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDParkedcallGet**](CallParkApi.md#v1accountaccountidparkedcallget) | **GET** /v1/account/{accountID}/parkedcall | Get Call Park List |

<a id="v1accountaccountidparkedcallget"></a>
# **V1AccountAccountIDParkedcallGet**
> ServiceDocsCallparkGet V1AccountAccountIDParkedcallGet (string accountID)

Get Call Park List

Retrieve a list of calls parked on hold in a numbered slot.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDParkedcallGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallParkApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric

            try
            {
                // Get Call Park List
                ServiceDocsCallparkGet result = apiInstance.V1AccountAccountIDParkedcallGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallParkApi.V1AccountAccountIDParkedcallGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDParkedcallGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Park List
    ApiResponse<ServiceDocsCallparkGet> response = apiInstance.V1AccountAccountIDParkedcallGetWithHttpInfo(accountID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallParkApi.V1AccountAccountIDParkedcallGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |

### Return type

[**ServiceDocsCallparkGet**](ServiceDocsCallparkGet.md)

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

