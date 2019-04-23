# Org.OpenAPITools.Api.UploadApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploaderExtract**](UploadApi.md#uploaderextract) | **POST** /uploader/extract | 
[**UploaderUpload**](UploadApi.md#uploaderupload) | **POST** /uploader/upload | 


<a name="uploaderextract"></a>
# **UploaderExtract**
> InlineResponse2007 UploaderExtract (string url)



Загрузить изображение/видео по ссылке.  Все изображения, видео, ссылки, твиты и так далее для прикрепления к комментарию или добавлению в статью должны быть загружены на Основу. В ответ на запрос вы получите JSON-структуру, которую можно будет передать как прикрепление (аттач). 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploaderExtractExample
    {
        public void main()
        {
            
            var apiInstance = new UploadApi();
            var url = url_example;  // string |  (optional) 

            try
            {
                InlineResponse2007 result = apiInstance.UploaderExtract(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploaderExtract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploaderupload"></a>
# **UploaderUpload**
> InlineResponse2007 UploaderUpload (System.IO.Stream file)



Загрузить изображение/видео весом до 20 Мб

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploaderUploadExample
    {
        public void main()
        {
            
            var apiInstance = new UploadApi();
            var file = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                InlineResponse2007 result = apiInstance.UploaderUpload(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploaderUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

