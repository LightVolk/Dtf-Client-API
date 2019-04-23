# Org.OpenAPITools.Api.UserApi

All URIs are relative to *https://api.dtf.ru/v1.6*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FavoriteAdd**](UserApi.md#favoriteadd) | **POST** /user/me/favorites | 
[**FavoriteRemove**](UserApi.md#favoriteremove) | **POST** /user/me/favorites/remove | 
[**GetUser**](UserApi.md#getuser) | **GET** /user/{id} | 
[**GetUserComments**](UserApi.md#getusercomments) | **GET** /user/{id}/comments | 
[**GetUserEntries**](UserApi.md#getuserentries) | **GET** /user/{id}/entries | 
[**GetUserFavoritesComments**](UserApi.md#getuserfavoritescomments) | **GET** /user/{id}/favorites/comments | 
[**GetUserFavoritesEntries**](UserApi.md#getuserfavoritesentries) | **GET** /user/{id}/favorites/entries | 
[**GetUserFavoritesVacancies**](UserApi.md#getuserfavoritesvacancies) | **GET** /user/{id}/favorites/vacancies | 
[**GetUserMe**](UserApi.md#getuserme) | **GET** /user/me | 
[**GetUserMeComments**](UserApi.md#getusermecomments) | **GET** /user/me/comments | 
[**GetUserMeEntries**](UserApi.md#getusermeentries) | **GET** /user/me/entries | 
[**GetUserMeFavoritesComments**](UserApi.md#getusermefavoritescomments) | **GET** /user/me/favorites/comments | 
[**GetUserMeFavoritesEntries**](UserApi.md#getusermefavoritesentries) | **GET** /user/me/favorites/entries | 
[**GetUserMeFavoritesVacancies**](UserApi.md#getusermefavoritesvacancies) | **GET** /user/me/favorites/vacancies | 
[**GetUserMeSubscriptionsRecommended**](UserApi.md#getusermesubscriptionsrecommended) | **GET** /user/me/subscriptions/recommended | 
[**GetUserMeSubscriptionsSubscribed**](UserApi.md#getusermesubscriptionssubscribed) | **GET** /user/me/subscriptions/subscribed | 
[**GetUserMeTuneCatalog**](UserApi.md#getusermetunecatalog) | **GET** /user/me/tunecatalog | 
[**GetUserMeUpdates**](UserApi.md#getusermeupdates) | **GET** /user/me/updates | 
[**GetUserMeUpdatesCount**](UserApi.md#getusermeupdatescount) | **GET** /user/me/updates/count | 
[**UserMeTuneCatalog**](UserApi.md#usermetunecatalog) | **POST** /user/me/tunecatalog | 
[**UserMeUpdatesRead**](UserApi.md#usermeupdatesread) | **POST** /user/me/updates/read | 
[**UserMeUpdatesReadId**](UserApi.md#usermeupdatesreadid) | **POST** /user/me/updates/read/{id} | 


<a name="favoriteadd"></a>
# **FavoriteAdd**
> InlineResponse20017 FavoriteAdd (Object id, Object type)



Добавить в избранное

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FavoriteAddExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var id = 8.14;  // Object | Id элемента (optional) 
            var type = 789;  // Object | Тип элемента. 1 - ENTRY, 2 - COMMENT (optional) 

            try
            {
                InlineResponse20017 result = apiInstance.FavoriteAdd(id, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.FavoriteAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**| Id элемента | [optional] 
 **type** | **Object**| Тип элемента. 1 - ENTRY, 2 - COMMENT | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favoriteremove"></a>
# **FavoriteRemove**
> InlineResponse20017 FavoriteRemove (Object id, Object type)



Удалить из избранного

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FavoriteRemoveExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var id = 8.14;  // Object | Id элемента (optional) 
            var type = 789;  // Object | Тип элемента. 1 - ENTRY, 2 - COMMENT (optional) 

            try
            {
                InlineResponse20017 result = apiInstance.FavoriteRemove(id, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.FavoriteRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**| Id элемента | [optional] 
 **type** | **Object**| Тип элемента. 1 - ENTRY, 2 - COMMENT | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> InlineResponse20012 GetUser (int? id)



Получить информацию о пользователе

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 56;  // int? | 

            try
            {
                InlineResponse20012 result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercomments"></a>
# **GetUserComments**
> InlineResponse2003 GetUserComments (Object id, long? count, long? offset)



Получить комментарии пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 8.14;  // Object | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.GetUserComments(id, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserentries"></a>
# **GetUserEntries**
> InlineResponse2001 GetUserEntries (Object id, long? count, long? offset)



Получить записи пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserEntriesExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 8.14;  // Object | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetUserEntries(id, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
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

<a name="getuserfavoritescomments"></a>
# **GetUserFavoritesComments**
> InlineResponse2003 GetUserFavoritesComments (Object id, long? count, long? offset)



Получить избранные комментарии пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserFavoritesCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 8.14;  // Object | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.GetUserFavoritesComments(id, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserFavoritesComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfavoritesentries"></a>
# **GetUserFavoritesEntries**
> InlineResponse2001 GetUserFavoritesEntries (Object id, long? count, long? offset)



Получить избранные записи пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserFavoritesEntriesExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 8.14;  // Object | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetUserFavoritesEntries(id, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserFavoritesEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
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

<a name="getuserfavoritesvacancies"></a>
# **GetUserFavoritesVacancies**
> InlineResponse20015 GetUserFavoritesVacancies (Object id, long? count, long? offset)



Получить избранные вакансии пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserFavoritesVacanciesExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = 8.14;  // Object | 
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20015 result = apiInstance.GetUserFavoritesVacancies(id, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserFavoritesVacancies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Object**|  | 
 **count** | **long?**|  | [optional] 
 **offset** | **long?**|  | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserme"></a>
# **GetUserMe**
> InlineResponse20012 GetUserMe ()



Получить информацию о текущем пользователе

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20012 result = apiInstance.GetUserMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermecomments"></a>
# **GetUserMeComments**
> InlineResponse2003 GetUserMeComments (long? count, long? offset)



Получить комментарии текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeCommentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.GetUserMeComments(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeComments: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermeentries"></a>
# **GetUserMeEntries**
> InlineResponse2001 GetUserMeEntries (long? count, long? offset)



Получить записи текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeEntriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetUserMeEntries(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeEntries: " + e.Message );
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

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermefavoritescomments"></a>
# **GetUserMeFavoritesComments**
> InlineResponse2003 GetUserMeFavoritesComments (long? count, long? offset)



Получить избранные комментарии текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeFavoritesCommentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.GetUserMeFavoritesComments(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeFavoritesComments: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermefavoritesentries"></a>
# **GetUserMeFavoritesEntries**
> InlineResponse2001 GetUserMeFavoritesEntries (long? count, long? offset)



Получить избранные записи текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeFavoritesEntriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetUserMeFavoritesEntries(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeFavoritesEntries: " + e.Message );
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

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermefavoritesvacancies"></a>
# **GetUserMeFavoritesVacancies**
> InlineResponse20015 GetUserMeFavoritesVacancies (long? count, long? offset)



Получить вакансии текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeFavoritesVacanciesExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var count = 789;  // long? |  (optional) 
            var offset = 789;  // long? |  (optional) 

            try
            {
                InlineResponse20015 result = apiInstance.GetUserMeFavoritesVacancies(count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeFavoritesVacancies: " + e.Message );
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

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermesubscriptionsrecommended"></a>
# **GetUserMeSubscriptionsRecommended**
> InlineResponse20016 GetUserMeSubscriptionsRecommended ()



Получить рекомендуемые подсайты

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeSubscriptionsRecommendedExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20016 result = apiInstance.GetUserMeSubscriptionsRecommended();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeSubscriptionsRecommended: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermesubscriptionssubscribed"></a>
# **GetUserMeSubscriptionsSubscribed**
> InlineResponse20016 GetUserMeSubscriptionsSubscribed ()



Получить подсайты, на которые пользователь подписан

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeSubscriptionsSubscribedExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20016 result = apiInstance.GetUserMeSubscriptionsSubscribed();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeSubscriptionsSubscribed: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermetunecatalog"></a>
# **GetUserMeTuneCatalog**
> InlineResponse20016 GetUserMeTuneCatalog ()



Получить список подсайтов для экрана настройки подсайтов

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeTuneCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20016 result = apiInstance.GetUserMeTuneCatalog();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeTuneCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermeupdates"></a>
# **GetUserMeUpdates**
> InlineResponse20013 GetUserMeUpdates (long? isRead, long? lastId)



Получить список уведомлений

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeUpdatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var isRead = 789;  // long? | Если равен 1, то все уведомления считаются прочитанными (optional)  (default to 1)
            var lastId = 789;  // long? | Указывает, начиная с какого уведомления загружать список уведомлений (optional) 

            try
            {
                InlineResponse20013 result = apiInstance.GetUserMeUpdates(isRead, lastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isRead** | **long?**| Если равен 1, то все уведомления считаются прочитанными | [optional] [default to 1]
 **lastId** | **long?**| Указывает, начиная с какого уведомления загружать список уведомлений | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusermeupdatescount"></a>
# **GetUserMeUpdatesCount**
> InlineResponse20014 GetUserMeUpdatesCount ()



Получить количество непрочитанных уведомлений у текущего пользователя

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserMeUpdatesCountExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20014 result = apiInstance.GetUserMeUpdatesCount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserMeUpdatesCount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermetunecatalog"></a>
# **UserMeTuneCatalog**
> InlineResponse20011 UserMeTuneCatalog ()



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
    public class UserMeTuneCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                InlineResponse20011 result = apiInstance.UserMeTuneCatalog();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserMeTuneCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermeupdatesread"></a>
# **UserMeUpdatesRead**
> InlineResponse20013 UserMeUpdatesRead (string ids)



Сделать уведомления прочитанными

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserMeUpdatesReadExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var ids = ids_example;  // string | Список Id через запятую (optional) 

            try
            {
                InlineResponse20013 result = apiInstance.UserMeUpdatesRead(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserMeUpdatesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | **string**| Список Id через запятую | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermeupdatesreadid"></a>
# **UserMeUpdatesReadId**
> InlineResponse20013 UserMeUpdatesReadId (long? id)



Сделать уведомление прочитанным

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserMeUpdatesReadIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: XDeviceToken
            Configuration.Default.ApiKey.Add("X-Device-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Device-Token", "Bearer");

            var apiInstance = new UserApi();
            var id = 789;  // long? | 

            try
            {
                InlineResponse20013 result = apiInstance.UserMeUpdatesReadId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserMeUpdatesReadId: " + e.Message );
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

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[XDeviceToken](../README.md#XDeviceToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

