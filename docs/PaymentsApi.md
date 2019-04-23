# Org.OpenAPITools.Api.PaymentsApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentsCheck**](PaymentsApi.md#paymentscheck) | **GET** /payments/check | 


<a name="paymentscheck"></a>
# **PaymentsCheck**
> InlineResponse20011 PaymentsCheck ()



Проверка текущего пользователя на возможность платить за подписку

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentsCheckExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new PaymentsApi();

            try
            {
                InlineResponse20011 result = apiInstance.PaymentsCheck();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentsCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

