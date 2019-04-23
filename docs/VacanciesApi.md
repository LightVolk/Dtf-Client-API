# Org.OpenAPITools.Api.VacanciesApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJob**](VacanciesApi.md#getjob) | **GET** /job | 
[**GetJobFilters**](VacanciesApi.md#getjobfilters) | **GET** /job/filters | 
[**GetJobMore**](VacanciesApi.md#getjobmore) | **GET** /job/more/{last_id} | 
[**GetVacancies**](VacanciesApi.md#getvacancies) | **GET** /vacancies/widget | 


<a name="getjob"></a>
# **GetJob**
> InlineResponse20024 GetJob ()



Возвращает список вакансий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            
            var apiInstance = new VacanciesApi();

            try
            {
                InlineResponse20024 result = apiInstance.GetJob();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VacanciesApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobfilters"></a>
# **GetJobFilters**
> InlineResponse20026 GetJobFilters ()



Загружает список фильтров вакансий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJobFiltersExample
    {
        public void main()
        {
            
            var apiInstance = new VacanciesApi();

            try
            {
                InlineResponse20026 result = apiInstance.GetJobFilters();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VacanciesApi.GetJobFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobmore"></a>
# **GetJobMore**
> InlineResponse20024 GetJobMore (Object lastId)



Подгружает список вакансий

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetJobMoreExample
    {
        public void main()
        {
            
            var apiInstance = new VacanciesApi();
            var lastId = 23102;  // Object | Последний ID элемента из предыдущей страницы

            try
            {
                InlineResponse20024 result = apiInstance.GetJobMore(lastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VacanciesApi.GetJobMore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastId** | **Object**| Последний ID элемента из предыдущей страницы | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvacancies"></a>
# **GetVacancies**
> InlineResponse20015 GetVacancies ()



Возвращает список вакансий для виджета в списке статей

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVacanciesExample
    {
        public void main()
        {
            
            var apiInstance = new VacanciesApi();

            try
            {
                InlineResponse20015 result = apiInstance.GetVacancies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VacanciesApi.GetVacancies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

