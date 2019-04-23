# Org.OpenAPITools.Api.LayoutApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLayout**](LayoutApi.md#getlayout) | **GET** /layout/{version} | 
[**GetLayoutHashtag**](LayoutApi.md#getlayouthashtag) | **GET** /layout/hashtag/{hashtag} | 


<a name="getlayout"></a>
# **GetLayout**
> InlineResponse20018 GetLayout (Object version)



Получить шаблон статьи для WebView

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLayoutExample
    {
        public void main()
        {
            
            var apiInstance = new LayoutApi();
            var version = 8.14;  // Object | 

            try
            {
                InlineResponse20018 result = apiInstance.GetLayout(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.GetLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **Object**|  | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlayouthashtag"></a>
# **GetLayoutHashtag**
> InlineResponse20018 GetLayoutHashtag (string hashtag)



Получить шаблон шапки экрана хештега

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLayoutHashtagExample
    {
        public void main()
        {
            
            var apiInstance = new LayoutApi();
            var hashtag = hashtag_example;  // string | 

            try
            {
                InlineResponse20018 result = apiInstance.GetLayoutHashtag(hashtag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.GetLayoutHashtag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashtag** | **string**|  | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

