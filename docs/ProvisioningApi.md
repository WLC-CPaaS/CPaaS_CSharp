# Org.OpenAPITools.Api.ProvisioningApi

All URIs are relative to *http://api.beta.cpaaslabs.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1AccountAccountIDProvisionFilenameGet**](ProvisioningApi.md#v1accountaccountidprovisionfilenameget) | **GET** /v1/account/{accountID}/provision/{filename} | Get Config File Details |
| [**V1ApBrandBrandFamilyFamilyGet**](ProvisioningApi.md#v1apbrandbrandfamilyfamilyget) | **GET** /v1/ap/brand/{brand}/family/{family} | Get Family Details |
| [**V1ApBrandBrandFamilyFamilyModelGet**](ProvisioningApi.md#v1apbrandbrandfamilyfamilymodelget) | **GET** /v1/ap/brand/{brand}/family/{family}/model | Get Model List |
| [**V1ApBrandBrandFamilyFamilyModelModelGet**](ProvisioningApi.md#v1apbrandbrandfamilyfamilymodelmodelget) | **GET** /v1/ap/brand/{brand}/family/{family}/model/{model} | Get Model Details |
| [**V1ApBrandBrandFamilyFamilyModelModelTemplateGet**](ProvisioningApi.md#v1apbrandbrandfamilyfamilymodelmodeltemplateget) | **GET** /v1/ap/brand/{brand}/family/{family}/model/{model}/template | Get Template List |
| [**V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGet**](ProvisioningApi.md#v1apbrandbrandfamilyfamilymodelmodeltemplatetemplateget) | **GET** /v1/ap/brand/{brand}/family/{family}/model/{model}/template/{template} | Get Template Details |
| [**V1ApBrandBrandFamilyGet**](ProvisioningApi.md#v1apbrandbrandfamilyget) | **GET** /v1/ap/brand/{brand}/family | Get Family List |
| [**V1ApBrandBrandGet**](ProvisioningApi.md#v1apbrandbrandget) | **GET** /v1/ap/brand/{brand} | Get Brand Details |
| [**V1ApBrandGet**](ProvisioningApi.md#v1apbrandget) | **GET** /v1/ap/brand | Get Brand List |
| [**V1ApConfigfileGeneratePost**](ProvisioningApi.md#v1apconfigfilegeneratepost) | **POST** /v1/ap/configfile/generate | Generate Config File |

<a id="v1accountaccountidprovisionfilenameget"></a>
# **V1AccountAccountIDProvisionFilenameGet**
> System.IO.Stream V1AccountAccountIDProvisionFilenameGet (string accountID, string filename)

Get Config File Details

Retrieve the configuration details (e.g., settings and parameters) for a device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1AccountAccountIDProvisionFilenameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            var apiInstance = new ProvisioningApi(config);
            var accountID = "accountID_example";  // string | Account ID, 32 alpha numeric
            var filename = "filename_example";  // string | Name of config file

            try
            {
                // Get Config File Details
                System.IO.Stream result = apiInstance.V1AccountAccountIDProvisionFilenameGet(accountID, filename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1AccountAccountIDProvisionFilenameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1AccountAccountIDProvisionFilenameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Config File Details
    ApiResponse<System.IO.Stream> response = apiInstance.V1AccountAccountIDProvisionFilenameGetWithHttpInfo(accountID, filename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1AccountAccountIDProvisionFilenameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountID** | **string** | Account ID, 32 alpha numeric |  |
| **filename** | **string** | Name of config file |  |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyfamilyget"></a>
# **V1ApBrandBrandFamilyFamilyGet**
> ProvisioningDocsDocsFamilyOutputSingle V1ApBrandBrandFamilyFamilyGet (string brand, string family)

Get Family Details

Retrieve a family's details by the randomly generated ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyFamilyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var family = "family_example";  // string | family

            try
            {
                // Get Family Details
                ProvisioningDocsDocsFamilyOutputSingle result = apiInstance.V1ApBrandBrandFamilyFamilyGet(brand, family);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyFamilyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Family Details
    ApiResponse<ProvisioningDocsDocsFamilyOutputSingle> response = apiInstance.V1ApBrandBrandFamilyFamilyGetWithHttpInfo(brand, family);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **family** | **string** | family |  |

### Return type

[**ProvisioningDocsDocsFamilyOutputSingle**](ProvisioningDocsDocsFamilyOutputSingle.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyfamilymodelget"></a>
# **V1ApBrandBrandFamilyFamilyModelGet**
> ProvisioningDocsDocsModelOutput V1ApBrandBrandFamilyFamilyModelGet (string brand, string family, string? modelName = null, int? pageSize = null, string? startKey = null, string? status = null)

Get Model List

Retrieve a list of all models within a family for a brand (e.g., Yealink and Polycom).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyFamilyModelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var family = "family_example";  // string | family
            var modelName = "modelName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var status = "active";  // string? |  (optional) 

            try
            {
                // Get Model List
                ProvisioningDocsDocsModelOutput result = apiInstance.V1ApBrandBrandFamilyFamilyModelGet(brand, family, modelName, pageSize, startKey, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyFamilyModelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Model List
    ApiResponse<ProvisioningDocsDocsModelOutput> response = apiInstance.V1ApBrandBrandFamilyFamilyModelGetWithHttpInfo(brand, family, modelName, pageSize, startKey, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **family** | **string** | family |  |
| **modelName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **status** | **string?** |  | [optional]  |

### Return type

[**ProvisioningDocsDocsModelOutput**](ProvisioningDocsDocsModelOutput.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyfamilymodelmodelget"></a>
# **V1ApBrandBrandFamilyFamilyModelModelGet**
> ProvisioningDocsDocsModelOutputSingle V1ApBrandBrandFamilyFamilyModelModelGet (string brand, string family, string model)

Get Model Details

Retrieve a model's details by the randomly generated ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyFamilyModelModelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var family = "family_example";  // string | family
            var model = "model_example";  // string | model

            try
            {
                // Get Model Details
                ProvisioningDocsDocsModelOutputSingle result = apiInstance.V1ApBrandBrandFamilyFamilyModelModelGet(brand, family, model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyFamilyModelModelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Model Details
    ApiResponse<ProvisioningDocsDocsModelOutputSingle> response = apiInstance.V1ApBrandBrandFamilyFamilyModelModelGetWithHttpInfo(brand, family, model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **family** | **string** | family |  |
| **model** | **string** | model |  |

### Return type

[**ProvisioningDocsDocsModelOutputSingle**](ProvisioningDocsDocsModelOutputSingle.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyfamilymodelmodeltemplateget"></a>
# **V1ApBrandBrandFamilyFamilyModelModelTemplateGet**
> ProvisioningDocsDocsTemplatesOutput V1ApBrandBrandFamilyFamilyModelModelTemplateGet (string brand, string family, string model, string? firmware = null, int? pageSize = null, string? startKey = null, string? status = null, string? templateName = null)

Get Template List

Retrieve a list of all templates for a model within a brand (e.g., Yealink and Polycom).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyFamilyModelModelTemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var family = "family_example";  // string | family
            var model = "model_example";  // string | model
            var firmware = "firmware_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var status = "active";  // string? |  (optional) 
            var templateName = "templateName_example";  // string? |  (optional) 

            try
            {
                // Get Template List
                ProvisioningDocsDocsTemplatesOutput result = apiInstance.V1ApBrandBrandFamilyFamilyModelModelTemplateGet(brand, family, model, firmware, pageSize, startKey, status, templateName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelTemplateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyFamilyModelModelTemplateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Template List
    ApiResponse<ProvisioningDocsDocsTemplatesOutput> response = apiInstance.V1ApBrandBrandFamilyFamilyModelModelTemplateGetWithHttpInfo(brand, family, model, firmware, pageSize, startKey, status, templateName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelTemplateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **family** | **string** | family |  |
| **model** | **string** | model |  |
| **firmware** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **status** | **string?** |  | [optional]  |
| **templateName** | **string?** |  | [optional]  |

### Return type

[**ProvisioningDocsDocsTemplatesOutput**](ProvisioningDocsDocsTemplatesOutput.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyfamilymodelmodeltemplatetemplateget"></a>
# **V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGet**
> ProvisioningDocsDocsTemplateOutputSingle V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGet (string brand, string family, string model, string template)

Get Template Details

Retrieve details about a template for a model by the randomly generated ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var family = "family_example";  // string | family
            var model = "model_example";  // string | model
            var template = "template_example";  // string | template

            try
            {
                // Get Template Details
                ProvisioningDocsDocsTemplateOutputSingle result = apiInstance.V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGet(brand, family, model, template);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Template Details
    ApiResponse<ProvisioningDocsDocsTemplateOutputSingle> response = apiInstance.V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGetWithHttpInfo(brand, family, model, template);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyFamilyModelModelTemplateTemplateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **family** | **string** | family |  |
| **model** | **string** | model |  |
| **template** | **string** | template |  |

### Return type

[**ProvisioningDocsDocsTemplateOutputSingle**](ProvisioningDocsDocsTemplateOutputSingle.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandfamilyget"></a>
# **V1ApBrandBrandFamilyGet**
> ProvisioningDocsDocsFamilyOutput V1ApBrandBrandFamilyGet (string brand, string? familyName = null, int? pageSize = null, string? startKey = null, string? status = null)

Get Family List

Retrieve a list of all families for a brand (e.g., Yealink and Polycom).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandFamilyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand
            var familyName = "familyName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var status = "active";  // string? |  (optional) 

            try
            {
                // Get Family List
                ProvisioningDocsDocsFamilyOutput result = apiInstance.V1ApBrandBrandFamilyGet(brand, familyName, pageSize, startKey, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandFamilyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Family List
    ApiResponse<ProvisioningDocsDocsFamilyOutput> response = apiInstance.V1ApBrandBrandFamilyGetWithHttpInfo(brand, familyName, pageSize, startKey, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandFamilyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand |  |
| **familyName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **status** | **string?** |  | [optional]  |

### Return type

[**ProvisioningDocsDocsFamilyOutput**](ProvisioningDocsDocsFamilyOutput.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandbrandget"></a>
# **V1ApBrandBrandGet**
> ProvisioningDocsDocsBrandOutputSingle V1ApBrandBrandGet (string brand)

Get Brand Details

Retrieve a brand's details by the randomly generated ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandBrandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brand = "brand_example";  // string | brand id to retrieve a brand

            try
            {
                // Get Brand Details
                ProvisioningDocsDocsBrandOutputSingle result = apiInstance.V1ApBrandBrandGet(brand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandBrandGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Brand Details
    ApiResponse<ProvisioningDocsDocsBrandOutputSingle> response = apiInstance.V1ApBrandBrandGetWithHttpInfo(brand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandBrandGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brand** | **string** | brand id to retrieve a brand |  |

### Return type

[**ProvisioningDocsDocsBrandOutputSingle**](ProvisioningDocsDocsBrandOutputSingle.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apbrandget"></a>
# **V1ApBrandGet**
> ProvisioningDocsDocsBrandsOutput V1ApBrandGet (string? brandName = null, int? pageSize = null, string? startKey = null, string? status = null)

Get Brand List

Retrieve a list of all brands (e.g., Yealink and Polycom) by client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApBrandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var brandName = "brandName_example";  // string? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var startKey = "startKey_example";  // string? |  (optional) 
            var status = "active";  // string? |  (optional) 

            try
            {
                // Get Brand List
                ProvisioningDocsDocsBrandsOutput result = apiInstance.V1ApBrandGet(brandName, pageSize, startKey, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApBrandGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApBrandGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Brand List
    ApiResponse<ProvisioningDocsDocsBrandsOutput> response = apiInstance.V1ApBrandGetWithHttpInfo(brandName, pageSize, startKey, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApBrandGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brandName** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **startKey** | **string?** |  | [optional]  |
| **status** | **string?** |  | [optional]  |

### Return type

[**ProvisioningDocsDocsBrandsOutput**](ProvisioningDocsDocsBrandsOutput.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1apconfigfilegeneratepost"></a>
# **V1ApConfigfileGeneratePost**
> ProvisioningDocsDocsConfigFileOutput V1ApConfigfileGeneratePost (ModelsGenerateConfigFileRequest varParams)

Generate Config File

Generate a configuration file that includes a list of parameters passed to the specified template_id in the request payload, with populated values returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1ApConfigfileGeneratePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.beta.cpaaslabs.net";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProvisioningApi(config);
            var varParams = new ModelsGenerateConfigFileRequest(); // ModelsGenerateConfigFileRequest | body params to generate config file

            try
            {
                // Generate Config File
                ProvisioningDocsDocsConfigFileOutput result = apiInstance.V1ApConfigfileGeneratePost(varParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.V1ApConfigfileGeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApConfigfileGeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate Config File
    ApiResponse<ProvisioningDocsDocsConfigFileOutput> response = apiInstance.V1ApConfigfileGeneratePostWithHttpInfo(varParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.V1ApConfigfileGeneratePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varParams** | [**ModelsGenerateConfigFileRequest**](ModelsGenerateConfigFileRequest.md) | body params to generate config file |  |

### Return type

[**ProvisioningDocsDocsConfigFileOutput**](ProvisioningDocsDocsConfigFileOutput.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

