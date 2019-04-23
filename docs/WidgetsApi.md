# Org.OpenAPITools.Api.WidgetsApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRates**](WidgetsApi.md#getrates) | **GET** /rates | 


<a name="getrates"></a>
# **GetRates**
> InlineResponse20022 GetRates ()



Возвращает курс валют

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRatesExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();

            try
            {
                InlineResponse20022 result = apiInstance.GetRates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetRates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

