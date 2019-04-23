# Org.OpenAPITools.Api.TimelineApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFlashholder**](TimelineApi.md#getflashholder) | **GET** /getflashholdedentry | 
[**GetTimeline**](TimelineApi.md#gettimeline) | **GET** /timeline/{category}/{sorting} | 
[**GetTimelineByHashtag**](TimelineApi.md#gettimelinebyhashtag) | **GET** /timeline/mainpage | 
[**GetTimelineNews**](TimelineApi.md#gettimelinenews) | **GET** /news/default/recent | 


<a name="getflashholder"></a>
# **GetFlashholder**
> InlineResponse2001 GetFlashholder ()



Получить прикрепленную запись

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetFlashholderExample
    {
        public void main()
        {
            
            var apiInstance = new TimelineApi();

            try
            {
                InlineResponse2001 result = apiInstance.GetFlashholder();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.GetFlashholder: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimeline"></a>
# **GetTimeline**
> InlineResponse2001 GetTimeline (string category, string sorting, long? count, long? offset)



Возвращает ленту записей

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTimelineExample
    {
        public void main()
        {
            
            var apiInstance = new TimelineApi();
            var category = category_example;  // string | category entries
            var sorting = sorting_example;  // string | sorting entries
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetTimeline(category, sorting, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.GetTimeline: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**| category entries | 
 **sorting** | **string**| sorting entries | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimelinebyhashtag"></a>
# **GetTimelineByHashtag**
> InlineResponse2001 GetTimelineByHashtag (string hashtag, long? count, long? offset)



Получить ленту записей по хэштегу

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTimelineByHashtagExample
    {
        public void main()
        {
            
            var apiInstance = new TimelineApi();
            var hashtag = hashtag_example;  // string | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetTimelineByHashtag(hashtag, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.GetTimelineByHashtag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashtag** | **string**|  | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimelinenews"></a>
# **GetTimelineNews**
> InlineResponse2001 GetTimelineNews (long? count, long? offset)



Получить ленту новостей

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTimelineNewsExample
    {
        public void main()
        {
            
            var apiInstance = new TimelineApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetTimelineNews(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimelineApi.GetTimelineNews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

