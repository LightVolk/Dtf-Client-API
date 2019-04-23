# Org.OpenAPITools.Api.SubsiteApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubsite**](SubsiteApi.md#getsubsite) | **GET** /subsite/{id} | 
[**GetSubsiteTimeline**](SubsiteApi.md#getsubsitetimeline) | **GET** /subsite/{id}/timeline/{sorting} | 
[**GetSubsiteVacancies**](SubsiteApi.md#getsubsitevacancies) | **GET** /subsite/{subsite_id}/vacancies | 
[**GetSubsiteVacanciesMore**](SubsiteApi.md#getsubsitevacanciesmore) | **GET** /subsite/{subsite_id}/vacancies/more/{last_id} | 
[**GetSubsitesList**](SubsiteApi.md#getsubsiteslist) | **GET** /subsites_list/{type} | 
[**SubsiteSubscribe**](SubsiteApi.md#subsitesubscribe) | **GET** /subsite/{id}/subscribe | 
[**SubsiteUnsubscribe**](SubsiteApi.md#subsiteunsubscribe) | **GET** /subsite/{id}/unsubscribe | 


<a name="getsubsite"></a>
# **GetSubsite**
> InlineResponse20023 GetSubsite (Object id)



Возвращает подсайт

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSubsiteExample
    {
        public void main()
        {
            
            var apiInstance = new SubsiteApi();
            var id = 8.14;  // Object | 

            try
            {
                InlineResponse20023 result = apiInstance.GetSubsite(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.GetSubsite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubsitetimeline"></a>
# **GetSubsiteTimeline**
> InlineResponse2002 GetSubsiteTimeline (Object id, string sorting, long? count, long? offset)



Возвращает список статей для подсайта

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSubsiteTimelineExample
    {
        public void main()
        {
            
            var apiInstance = new SubsiteApi();
            var id = 8.14;  // Object | 
            var sorting = sorting_example;  // string | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.GetSubsiteTimeline(id, sorting, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.GetSubsiteTimeline: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
 **sorting** | **string**|  | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubsitevacancies"></a>
# **GetSubsiteVacancies**
> InlineResponse20024 GetSubsiteVacancies (Object subsiteId)



Получить вакансии для компании

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSubsiteVacanciesExample
    {
        public void main()
        {
            
            var apiInstance = new SubsiteApi();
            var subsiteId = 8.14;  // Object | id подсайта

            try
            {
                InlineResponse20024 result = apiInstance.GetSubsiteVacancies(subsiteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.GetSubsiteVacancies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subsiteId** | **Object**| id подсайта | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubsitevacanciesmore"></a>
# **GetSubsiteVacanciesMore**
> InlineResponse20024 GetSubsiteVacanciesMore (Object subsiteId, Object lastId)



Подгрузить вакансии для компании

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSubsiteVacanciesMoreExample
    {
        public void main()
        {
            
            var apiInstance = new SubsiteApi();
            var subsiteId = 8.14;  // Object | id подсайта
            var lastId = 8.14;  // Object | last_id из предыдущей подгрузки

            try
            {
                InlineResponse20024 result = apiInstance.GetSubsiteVacanciesMore(subsiteId, lastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.GetSubsiteVacanciesMore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subsiteId** | **Object**| id подсайта | 
 **lastId** | **Object**| last_id из предыдущей подгрузки | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubsiteslist"></a>
# **GetSubsitesList**
> InlineResponse20016 GetSubsitesList (string type)



Получить рекомендуемые подсайты для анонимного пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSubsitesListExample
    {
        public void main()
        {
            
            var apiInstance = new SubsiteApi();
            var type = sections;  // string | Тип контента:   * `sections` - подсайты   * `companies` - компании 

            try
            {
                InlineResponse20016 result = apiInstance.GetSubsitesList(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.GetSubsitesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Тип контента:   * &#x60;sections&#x60; - подсайты   * &#x60;companies&#x60; - компании  | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subsitesubscribe"></a>
# **SubsiteSubscribe**
> InlineResponse20025 SubsiteSubscribe (Object id)



Подписка на подсайт

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubsiteSubscribeExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new SubsiteApi();
            var id = 8.14;  // Object | 

            try
            {
                InlineResponse20025 result = apiInstance.SubsiteSubscribe(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.SubsiteSubscribe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subsiteunsubscribe"></a>
# **SubsiteUnsubscribe**
> InlineResponse20025 SubsiteUnsubscribe (Object id)



Отписка от подсайта

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubsiteUnsubscribeExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new SubsiteApi();
            var id = 8.14;  // Object | 

            try
            {
                InlineResponse20025 result = apiInstance.SubsiteUnsubscribe(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubsiteApi.SubsiteUnsubscribe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

