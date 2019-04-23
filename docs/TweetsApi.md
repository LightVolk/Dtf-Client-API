# Org.OpenAPITools.Api.TweetsApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTweets**](TweetsApi.md#gettweets) | **GET** /tweets/{mode} | 


<a name="gettweets"></a>
# **GetTweets**
> InlineResponse20021 GetTweets (string mode, long? count, long? offset)



Возвращает ленту твитов

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTweetsExample
    {
        public void main()
        {
            
            var apiInstance = new TweetsApi();
            var mode = mode_example;  // string | tweets mode sorting
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20021 result = apiInstance.GetTweets(mode, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TweetsApi.GetTweets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mode** | **string**| tweets mode sorting | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

