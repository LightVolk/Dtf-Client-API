# Org.OpenAPITools.Api.PushApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserPushSettings**](PushApi.md#getuserpushsettings) | **GET** /user/push/settings/get | 
[**GetUserPushTopic**](PushApi.md#getuserpushtopic) | **GET** /user/push/topic | 
[**UpdateUserPushSettings**](PushApi.md#updateuserpushsettings) | **POST** /user/push/settings/update | 


<a name="getuserpushsettings"></a>
# **GetUserPushSettings**
> InlineResponse20020 GetUserPushSettings ()



Получить настройки пушей для текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserPushSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new PushApi();

            try
            {
                InlineResponse20020 result = apiInstance.GetUserPushSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.GetUserPushSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserpushtopic"></a>
# **GetUserPushTopic**
> InlineResponse20019 GetUserPushTopic ()



Получить topic для текущего пользователя, чтобы подписаться на пуши

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserPushTopicExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new PushApi();

            try
            {
                InlineResponse20019 result = apiInstance.GetUserPushTopic();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.GetUserPushTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserpushsettings"></a>
# **UpdateUserPushSettings**
> InlineResponse2008 UpdateUserPushSettings (long? settings)



Отправить на сервер настройки пушей для текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserPushSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new PushApi();
            var settings = 789;  // long? | Битовая маска настроек (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.UpdateUserPushSettings(settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.UpdateUserPushSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settings** | **long?**| Битовая маска настроек | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

