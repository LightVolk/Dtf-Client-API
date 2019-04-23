# Org.OpenAPITools.Api.EntryApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EntryCreate**](EntryApi.md#entrycreate) | **POST** /entry/create | 
[**EntryLocate**](EntryApi.md#entrylocate) | **GET** /entry/locate | 
[**GetEntryById**](EntryApi.md#getentrybyid) | **GET** /entry/{id} | 
[**GetPopularEntries**](EntryApi.md#getpopularentries) | **GET** /entry/{id}/popular | 
[**LikeEntry**](EntryApi.md#likeentry) | **POST** /like | 


<a name="entrycreate"></a>
# **EntryCreate**
> InlineResponse2002 EntryCreate (string title, string text, Object subsiteId, string attachments)



Создать запись

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntryCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new EntryApi();
            var title = title_example;  // string |  (optional) 
            var text = text_example;  // string |  (optional) 
            var subsiteId = 8.14;  // Object |  (optional) 
            var attachments = attachments_example;  // string |  (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.EntryCreate(title, text, subsiteId, attachments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryApi.EntryCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**|  | [optional] 
 **text** | **string**|  | [optional] 
 **subsiteId** | **Object**|  | [optional] 
 **attachments** | **string**|  | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entrylocate"></a>
# **EntryLocate**
> InlineResponse2002 EntryLocate (string url)



Найти статью по ссылке

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntryLocateExample
    {
        public void main()
        {
            
            var apiInstance = new EntryApi();
            var url = https://dtf.ru/games/22946-legendy-dwarf-fortress-saga-o-padenii-kreposti-boutmerded;  // string | Ссылка на статью

            try
            {
                InlineResponse2002 result = apiInstance.EntryLocate(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryApi.EntryLocate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**| Ссылка на статью | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrybyid"></a>
# **GetEntryById**
> InlineResponse2002 GetEntryById (long? id)



Получить запись по ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEntryByIdExample
    {
        public void main()
        {
            
            var apiInstance = new EntryApi();
            var id = 789;  // long? | 

            try
            {
                InlineResponse2002 result = apiInstance.GetEntryById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryApi.GetEntryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopularentries"></a>
# **GetPopularEntries**
> InlineResponse2001 GetPopularEntries (long? id)



Получить популярные записи для определенной записи

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPopularEntriesExample
    {
        public void main()
        {
            
            var apiInstance = new EntryApi();
            var id = 789;  // long? | 

            try
            {
                InlineResponse2001 result = apiInstance.GetPopularEntries(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryApi.GetPopularEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likeentry"></a>
# **LikeEntry**
> InlineResponse2005 LikeEntry (long? id, string type, long? sign)



Лайкнуть запись / комментарий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikeEntryExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new EntryApi();
            var id = 789;  // long? |  (optional) 
            var type = type_example;  // string | Тип контента:   * `content` - запись   * `comment` - комментарий (optional) 
            var sign = 789;  // long? | Изменить рейтинг  * `-1` - Понизить  * `0` - Сбросить  * `1` - Повысить  (optional) 

            try
            {
                InlineResponse2005 result = apiInstance.LikeEntry(id, type, sign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntryApi.LikeEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | [optional] 
 **type** | **string**| Тип контента:   * &#x60;content&#x60; - запись   * &#x60;comment&#x60; - комментарий | [optional] 
 **sign** | **long?**| Изменить рейтинг  * &#x60;-1&#x60; - Понизить  * &#x60;0&#x60; - Сбросить  * &#x60;1&#x60; - Повысить  | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

