# Org.OpenAPITools.Api.CommentApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommentEdit**](CommentApi.md#commentedit) | **POST** /comment/edit/{commentId}/{entryId} | 
[**CommentSaveCommentsSeenCount**](CommentApi.md#commentsavecommentsseencount) | **POST** /comment/saveCommentsSeenCount | 
[**CommentSend**](CommentApi.md#commentsend) | **POST** /comment/add | 
[**GetCommentLikes**](CommentApi.md#getcommentlikes) | **GET** /comment/likers/{id} | 
[**GetEntryComments**](CommentApi.md#getentrycomments) | **GET** /entry/{id}/comments/{sorting} | 
[**GetEntryCommentsLevelsGet**](CommentApi.md#getentrycommentslevelsget) | **GET** /entry/{id}/comments/levels/{sorting} | 
[**GetEntryCommentsLevelsPost**](CommentApi.md#getentrycommentslevelspost) | **POST** /entry/{id}/comments/levels/{sorting} | 
[**GetEntryCommentsThread**](CommentApi.md#getentrycommentsthread) | **GET** /entry/{entryId}/comments/thread/{commentId} | 
[**LikeEntry**](CommentApi.md#likeentry) | **POST** /like | 


<a name="commentedit"></a>
# **CommentEdit**
> InlineResponse2008 CommentEdit (long? commentId, long? entryId, string text)



Отредактировать комментарий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommentEditExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new CommentApi();
            var commentId = 789;  // long? | 
            var entryId = 789;  // long? | 
            var text = text_example;  // string |  (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.CommentEdit(commentId, entryId, text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.CommentEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**|  | 
 **entryId** | **long?**|  | 
 **text** | **string**|  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commentsavecommentsseencount"></a>
# **CommentSaveCommentsSeenCount**
> void CommentSaveCommentsSeenCount (long? contentId, long? count)



Отправить количество увиденных комментариев

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommentSaveCommentsSeenCountExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new CommentApi();
            var contentId = 789;  // long? | Id записи (optional) 
            var count = 789;  // long? | Последнее увиденное количество (optional) 

            try
            {
                apiInstance.CommentSaveCommentsSeenCount(contentId, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.CommentSaveCommentsSeenCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentId** | **long?**| Id записи | [optional] 
 **count** | **long?**| Последнее увиденное количество | [optional] 

### Return type

void (empty response body)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commentsend"></a>
# **CommentSend**
> InlineResponse2009 CommentSend (string id, string text, string replyTo, string attachments)



Отправить комментарий. Чтобы создать комментарий с прикреплениями, в запросе нужно передать поле attachments. Внутри должен быть JSON-массив с приложениями, предварительно загруженными через API в том же формате, который был получен при загрузке.  При отправке комментариев с помощью API у вас есть возможность создать ссылку в формате markdown: **`[text on place of link](https://ya.ru/)`** 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommentSendExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new CommentApi();
            var id = id_example;  // string | id записи (optional) 
            var text = text_example;  // string | текст комментария (optional) 
            var replyTo = replyTo_example;  // string | id комментария, на который отвечаем (или 0) (optional) 
            var attachments = attachments_example;  // string |  (optional) 

            try
            {
                InlineResponse2009 result = apiInstance.CommentSend(id, text, replyTo, attachments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.CommentSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id записи | [optional] 
 **text** | **string**| текст комментария | [optional] 
 **replyTo** | **string**| id комментария, на который отвечаем (или 0) | [optional] 
 **attachments** | **string**|  | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentlikes"></a>
# **GetCommentLikes**
> InlineResponse2006 GetCommentLikes (long? id)



Получить список лайкнувших комментарий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCommentLikesExample
    {
        public void main()
        {
            
            var apiInstance = new CommentApi();
            var id = 789;  // long? | 

            try
            {
                InlineResponse2006 result = apiInstance.GetCommentLikes(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.GetCommentLikes: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrycomments"></a>
# **GetEntryComments**
> InlineResponse2003 GetEntryComments (long? id, string sorting)



Получить комментарии к записи

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEntryCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new CommentApi();
            var id = 789;  // long? | 
            var sorting = sorting_example;  // string | 

            try
            {
                InlineResponse2003 result = apiInstance.GetEntryComments(id, sorting);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.GetEntryComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **sorting** | **string**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrycommentslevelsget"></a>
# **GetEntryCommentsLevelsGet**
> InlineResponse2004 GetEntryCommentsLevelsGet (long? id, string sorting)



Получить комментарии к записи с ограничением по веткам

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEntryCommentsLevelsGetExample
    {
        public void main()
        {
            
            var apiInstance = new CommentApi();
            var id = 789;  // long? | 
            var sorting = sorting_example;  // string | 

            try
            {
                InlineResponse2004 result = apiInstance.GetEntryCommentsLevelsGet(id, sorting);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.GetEntryCommentsLevelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **sorting** | **string**|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrycommentslevelspost"></a>
# **GetEntryCommentsLevelsPost**
> InlineResponse2004 GetEntryCommentsLevelsPost (long? id, string sorting, int? ids)



Получить комментарии к записи с ограничением по веткам

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEntryCommentsLevelsPostExample
    {
        public void main()
        {
            
            var apiInstance = new CommentApi();
            var id = 789;  // long? | 
            var sorting = sorting_example;  // string | 
            var ids = 56;  // int? | Список id корневых комментариев для загрузки веток (optional) 

            try
            {
                InlineResponse2004 result = apiInstance.GetEntryCommentsLevelsPost(id, sorting, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.GetEntryCommentsLevelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **sorting** | **string**|  | 
 **ids** | **int?**| Список id корневых комментариев для загрузки веток | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrycommentsthread"></a>
# **GetEntryCommentsThread**
> void GetEntryCommentsThread (long? entryId, long? commentId)



Получить комментарии к записи с ограничением по веткам

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetEntryCommentsThreadExample
    {
        public void main()
        {
            
            var apiInstance = new CommentApi();
            var entryId = 789;  // long? | 
            var commentId = 789;  // long? | 

            try
            {
                apiInstance.GetEntryCommentsThread(entryId, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentApi.GetEntryCommentsThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entryId** | **long?**|  | 
 **commentId** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

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

            var apiInstance = new CommentApi();
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
                Debug.Print("Exception when calling CommentApi.LikeEntry: " + e.Message );
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

