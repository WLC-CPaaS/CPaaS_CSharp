# Org.OpenAPITools.Api.E911Api

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1E911Get**](E911Api.md#v1e911get) | **GET** /v1/e911 | Get E911 List |
| [**V1E911LocationLocationIDActivatePut**](E911Api.md#v1e911locationlocationidactivateput) | **PUT** /v1/e911/location/{locationID}/activate | Activate E911 Location |
| [**V1E911LocationLocationIDDelete**](E911Api.md#v1e911locationlocationiddelete) | **DELETE** /v1/e911/location/{locationID} | Delete E911 Location |
| [**V1E911LocationValidatePut**](E911Api.md#v1e911locationvalidateput) | **PUT** /v1/e911/location/validate | Validate a Location |
| [**V1E911PhoneNumberDelete**](E911Api.md#v1e911phonenumberdelete) | **DELETE** /v1/e911/{phoneNumber} | Delete E911 Phone Number |
| [**V1E911PhoneNumberLocationActiveGet**](E911Api.md#v1e911phonenumberlocationactiveget) | **GET** /v1/e911/{phoneNumber}/location/active | Get Actvie Location for a Phone Number |
| [**V1E911PhoneNumberLocationGet**](E911Api.md#v1e911phonenumberlocationget) | **GET** /v1/e911/{phoneNumber}/location | Get Location List for Phone Number |
| [**V1E911Post**](E911Api.md#v1e911post) | **POST** /v1/e911 | Create an E911 Location |

<a id="v1e911get"></a>
# **V1E911Get**
> ServiceDocsE911URIsApiOutput V1E911Get ()

Get E911 List

Obtain e911 URIs associated with the provided account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);

            try
            {
                // Get E911 List
                ServiceDocsE911URIsApiOutput result = apiInstance.V1E911Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get E911 List
    ApiResponse<ServiceDocsE911URIsApiOutput> response = apiInstance.V1E911GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ServiceDocsE911URIsApiOutput**](ServiceDocsE911URIsApiOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with e911 URIs |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911locationlocationidactivateput"></a>
# **V1E911LocationLocationIDActivatePut**
> ServiceDocsE911ActiveLocationOutput V1E911LocationLocationIDActivatePut (string locationID)

Activate E911 Location

Edit the provision location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911LocationLocationIDActivatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var locationID = "locationID_example";  // string | Location ID

            try
            {
                // Activate E911 Location
                ServiceDocsE911ActiveLocationOutput result = apiInstance.V1E911LocationLocationIDActivatePut(locationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911LocationLocationIDActivatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911LocationLocationIDActivatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate E911 Location
    ApiResponse<ServiceDocsE911ActiveLocationOutput> response = apiInstance.V1E911LocationLocationIDActivatePutWithHttpInfo(locationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911LocationLocationIDActivatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationID** | **string** | Location ID |  |

### Return type

[**ServiceDocsE911ActiveLocationOutput**](ServiceDocsE911ActiveLocationOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with location activate status |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911locationlocationiddelete"></a>
# **V1E911LocationLocationIDDelete**
> ServiceDocsE911RemoveLocationOutput V1E911LocationLocationIDDelete (string locationID)

Delete E911 Location

Remove the location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911LocationLocationIDDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var locationID = "locationID_example";  // string | Location ID

            try
            {
                // Delete E911 Location
                ServiceDocsE911RemoveLocationOutput result = apiInstance.V1E911LocationLocationIDDelete(locationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911LocationLocationIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911LocationLocationIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete E911 Location
    ApiResponse<ServiceDocsE911RemoveLocationOutput> response = apiInstance.V1E911LocationLocationIDDeleteWithHttpInfo(locationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911LocationLocationIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationID** | **string** | Location ID |  |

### Return type

[**ServiceDocsE911RemoveLocationOutput**](ServiceDocsE911RemoveLocationOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with location remove status |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911locationvalidateput"></a>
# **V1E911LocationValidatePut**
> ServiceDocsE911ValidateLocationOutput V1E911LocationValidatePut (ServiceE911ValidateLocationInput reqBody)

Validate a Location

Validate the location details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911LocationValidatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var reqBody = new ServiceE911ValidateLocationInput(); // ServiceE911ValidateLocationInput | location details

            try
            {
                // Validate a Location
                ServiceDocsE911ValidateLocationOutput result = apiInstance.V1E911LocationValidatePut(reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911LocationValidatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911LocationValidatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a Location
    ApiResponse<ServiceDocsE911ValidateLocationOutput> response = apiInstance.V1E911LocationValidatePutWithHttpInfo(reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911LocationValidatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reqBody** | [**ServiceE911ValidateLocationInput**](ServiceE911ValidateLocationInput.md) | location details |  |

### Return type

[**ServiceDocsE911ValidateLocationOutput**](ServiceDocsE911ValidateLocationOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with location details |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911phonenumberdelete"></a>
# **V1E911PhoneNumberDelete**
> ServiceDocsE911RemoveURIApiOutput V1E911PhoneNumberDelete (string phoneNumber)

Delete E911 Phone Number

Delete the e911 URI connected with the account URI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911PhoneNumberDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var phoneNumber = "phoneNumber_example";  // string | Phone Number

            try
            {
                // Delete E911 Phone Number
                ServiceDocsE911RemoveURIApiOutput result = apiInstance.V1E911PhoneNumberDelete(phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911PhoneNumberDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911PhoneNumberDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete E911 Phone Number
    ApiResponse<ServiceDocsE911RemoveURIApiOutput> response = apiInstance.V1E911PhoneNumberDeleteWithHttpInfo(phoneNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911PhoneNumberDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phoneNumber** | **string** | Phone Number |  |

### Return type

[**ServiceDocsE911RemoveURIApiOutput**](ServiceDocsE911RemoveURIApiOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911phonenumberlocationactiveget"></a>
# **V1E911PhoneNumberLocationActiveGet**
> ServiceDocsE911ActiveLocationURIApiOutput V1E911PhoneNumberLocationActiveGet (string phoneNumber)

Get Actvie Location for a Phone Number

Get the e911 location connected with the URI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911PhoneNumberLocationActiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var phoneNumber = "phoneNumber_example";  // string | Phone Number

            try
            {
                // Get Actvie Location for a Phone Number
                ServiceDocsE911ActiveLocationURIApiOutput result = apiInstance.V1E911PhoneNumberLocationActiveGet(phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911PhoneNumberLocationActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911PhoneNumberLocationActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Actvie Location for a Phone Number
    ApiResponse<ServiceDocsE911ActiveLocationURIApiOutput> response = apiInstance.V1E911PhoneNumberLocationActiveGetWithHttpInfo(phoneNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911PhoneNumberLocationActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phoneNumber** | **string** | Phone Number |  |

### Return type

[**ServiceDocsE911ActiveLocationURIApiOutput**](ServiceDocsE911ActiveLocationURIApiOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with e911 Active Location URI |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911phonenumberlocationget"></a>
# **V1E911PhoneNumberLocationGet**
> ServiceDocsE911LocationsURIApiOutput V1E911PhoneNumberLocationGet (string phoneNumber)

Get Location List for Phone Number

Access a list of the e911 locations associated with the provided URI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911PhoneNumberLocationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var phoneNumber = "phoneNumber_example";  // string | Phone Number

            try
            {
                // Get Location List for Phone Number
                ServiceDocsE911LocationsURIApiOutput result = apiInstance.V1E911PhoneNumberLocationGet(phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911PhoneNumberLocationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911PhoneNumberLocationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Location List for Phone Number
    ApiResponse<ServiceDocsE911LocationsURIApiOutput> response = apiInstance.V1E911PhoneNumberLocationGetWithHttpInfo(phoneNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911PhoneNumberLocationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phoneNumber** | **string** | Phone Number |  |

### Return type

[**ServiceDocsE911LocationsURIApiOutput**](ServiceDocsE911LocationsURIApiOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with e911 Locations URI |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1e911post"></a>
# **V1E911Post**
> ServiceDocsE911AddLocationOutput V1E911Post (ServiceE911AddLocationInput reqBody)

Create an E911 Location

Enter new location details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1E911PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new E911Api(config);
            var reqBody = new ServiceE911AddLocationInput(); // ServiceE911AddLocationInput | location details

            try
            {
                // Create an E911 Location
                ServiceDocsE911AddLocationOutput result = apiInstance.V1E911Post(reqBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling E911Api.V1E911Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1E911PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an E911 Location
    ApiResponse<ServiceDocsE911AddLocationOutput> response = apiInstance.V1E911PostWithHttpInfo(reqBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling E911Api.V1E911PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reqBody** | [**ServiceE911AddLocationInput**](ServiceE911AddLocationInput.md) | location details |  |

### Return type

[**ServiceDocsE911AddLocationOutput**](ServiceDocsE911AddLocationOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response with location details |  -  |
| **403** | Authorization failed or root account not allowed |  -  |
| **500** | Internal server error, including environment credential issues, HTTP request failures, or XML unmarshaling errors |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

