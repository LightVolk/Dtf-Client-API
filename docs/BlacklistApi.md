# Org.OpenAPITools.Api.BlacklistApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContentMute**](BlacklistApi.md#contentmute) | **POST** /content/mute | 
[**HashtagMute**](BlacklistApi.md#hashtagmute) | **POST** /hashtag/mute | 
[**SubsitegMute**](BlacklistApi.md#subsitegmute) | **POST** /subsite/mute | 


<a name="contentmute"></a>
# **ContentMute**
> InlineResponse20030 ContentMute (string action, long? id)



Добавить запись в черный список

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentMuteExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new BlacklistApi();
            var action = action_example;  // string | Тип действия (optional) 
            var id = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20030 result = apiInstance.ContentMute(action, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.ContentMute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| Тип действия | [optional] 
 **id** | **long?**|  | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hashtagmute"></a>
# **HashtagMute**
> InlineResponse20030 HashtagMute (string action, long? id)



Добавить хэштег в черный список

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HashtagMuteExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new BlacklistApi();
            var action = action_example;  // string | Тип действия (optional) 
            var id = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20030 result = apiInstance.HashtagMute(action, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.HashtagMute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| Тип действия | [optional] 
 **id** | **long?**|  | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subsitegmute"></a>
# **SubsitegMute**
> InlineResponse20030 SubsitegMute (string action, long? id)



Добавить подсайт в черный список

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubsitegMuteExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new BlacklistApi();
            var action = action_example;  // string | Тип действия (optional) 
            var id = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20030 result = apiInstance.SubsitegMute(action, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.SubsitegMute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| Тип действия | [optional] 
 **id** | **long?**|  | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

