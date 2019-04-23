# Org.OpenAPITools.Api.WebhooksSubscriptionsApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiWebhookAdd**](WebhooksSubscriptionsApi.md#apiwebhookadd) | **POST** /webhooks/add | 
[**ApiWebhookDel**](WebhooksSubscriptionsApi.md#apiwebhookdel) | **POST** /webhooks/del | 
[**ApiWebhooksGet**](WebhooksSubscriptionsApi.md#apiwebhooksget) | **GET** /webhooks/get | 


<a name="apiwebhookadd"></a>
# **ApiWebhookAdd**
> InlineResponse20028 ApiWebhookAdd (string url, string _event)



Подписаться на событие

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiWebhookAddExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new WebhooksSubscriptionsApi();
            var url = url_example;  // string | Ссылка на которую будут отправлены данные по событию (optional) 
            var _event = _event_example;  // string | Название события (optional) 

            try
            {
                InlineResponse20028 result = apiInstance.ApiWebhookAdd(url, _event);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksSubscriptionsApi.ApiWebhookAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**| Ссылка на которую будут отправлены данные по событию | [optional] 
 **_event** | **string**| Название события | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiwebhookdel"></a>
# **ApiWebhookDel**
> InlineResponse20029 ApiWebhookDel (string _event)



Удаление подписки на событие

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiWebhookDelExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new WebhooksSubscriptionsApi();
            var _event = _event_example;  // string | Название события (optional) 

            try
            {
                InlineResponse20029 result = apiInstance.ApiWebhookDel(_event);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksSubscriptionsApi.ApiWebhookDel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_event** | **string**| Название события | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiwebhooksget"></a>
# **ApiWebhooksGet**
> InlineResponse20027 ApiWebhooksGet ()



Получить события на которые подписан пользователь

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiWebhooksGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new WebhooksSubscriptionsApi();

            try
            {
                InlineResponse20027 result = apiInstance.ApiWebhooksGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksSubscriptionsApi.ApiWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

