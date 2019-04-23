# Org.OpenAPITools.Api.AuthApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthLogin**](AuthApi.md#authlogin) | **POST** /auth/login | 
[**AuthQr**](AuthApi.md#authqr) | **POST** /auth/qr | 
[**AuthSocial**](AuthApi.md#authsocial) | **POST** /auth/social/{type} | 


<a name="authlogin"></a>
# **AuthLogin**
> InlineResponse200 AuthLogin (string login, string password)



Авторизация через email

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthLoginExample
    {
        public void main()
        {
            
            var apiInstance = new AuthApi();
            var login = login_example;  // string |  (optional) 
            var password = password_example;  // string |  (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AuthLogin(login, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | **string**|  | [optional] 
 **password** | **string**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authqr"></a>
# **AuthQr**
> InlineResponse200 AuthQr (string token)



Авторизация через QR код

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthQrExample
    {
        public void main()
        {
            
            var apiInstance = new AuthApi();
            var token = token_example;  // string |  (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AuthQr(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthQr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authsocial"></a>
# **AuthSocial**
> InlineResponse200 AuthSocial (string type, string token, string email, int? linking)



Авторизация через социальную сеть

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthSocialExample
    {
        public void main()
        {
            
            var apiInstance = new AuthApi();
            var type = type_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var email = email_example;  // string |  (optional) 
            var linking = 56;  // int? | Если 1, то аккаунт привяжется к текущему (optional)  (default to 0)

            try
            {
                InlineResponse200 result = apiInstance.AuthSocial(type, token, email, linking);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSocial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 
 **token** | **string**|  | [optional] 
 **email** | **string**|  | [optional] 
 **linking** | **int?**| Если 1, то аккаунт привяжется к текущему | [optional] [default to 0]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

