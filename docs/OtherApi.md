# Org.OpenAPITools.Api.OtherApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EntryCommentComplaint**](OtherApi.md#entrycommentcomplaint) | **POST** /entry/comment/complaint | 
[**EntryComplaint**](OtherApi.md#entrycomplaint) | **POST** /entry/complaint | 
[**Locate**](OtherApi.md#locate) | **GET** /locate | 
[**Search**](OtherApi.md#search) | **GET** /search | 


<a name="entrycommentcomplaint"></a>
# **EntryCommentComplaint**
> InlineResponse20011 EntryCommentComplaint (Object commentId)



Жалоба на комментарий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntryCommentComplaintExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new OtherApi();
            var commentId = 8.14;  // Object | Id комментария (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.EntryCommentComplaint(commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.EntryCommentComplaint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **Object**| Id комментария | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entrycomplaint"></a>
# **EntryComplaint**
> InlineResponse20011 EntryComplaint (Object contentId)



Жалоба на статью

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntryComplaintExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new OtherApi();
            var contentId = 8.14;  // Object | Id статьи (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.EntryComplaint(contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.EntryComplaint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentId** | **Object**| Id статьи | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locate"></a>
# **Locate**
> InlineResponse20010 Locate (string url)



Получить контент по ссылке

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocateExample
    {
        public void main()
        {
            
            var apiInstance = new OtherApi();
            var url = https://dtf.ru/games/22946-legendy-dwarf-fortress-saga-o-padenii-kreposti-boutmerded;  // string | Ссылка на страницу сайта

            try
            {
                InlineResponse20010 result = apiInstance.Locate(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.Locate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**| Ссылка на страницу сайта | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> InlineResponse2001 Search (string query, string orderBy, int? page)



Поиск

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            
            var apiInstance = new OtherApi();
            var query = apple;  // string | Строка для поиска
            var orderBy = relevant;  // string | Сортировка:   * `relevant` - По важности   * `date` - По дате  (optional) 
            var page = 1;  // int? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.Search(query, orderBy, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Строка для поиска | 
 **orderBy** | **string**| Сортировка:   * &#x60;relevant&#x60; - По важности   * &#x60;date&#x60; - По дате  | [optional] 
 **page** | **int?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

