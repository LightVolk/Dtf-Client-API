using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        /// <summary>
        ///  Добавить в избранное
        /// </summary>
        /// <param name="id">Id элемента</param>
        /// <param name="type">Тип элемента. 1 - ENTRY, 2 - COMMENT</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 FavoriteAdd (Object id, Object type);
        /// <summary>
        ///  Удалить из избранного
        /// </summary>
        /// <param name="id">Id элемента</param>
        /// <param name="type">Тип элемента. 1 - ENTRY, 2 - COMMENT</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 FavoriteRemove (Object id, Object type);
        /// <summary>
        ///  Получить информацию о пользователе
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GetUser (int? id);
        /// <summary>
        ///  Получить комментарии пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetUserComments (Object id, long? count, long? offset);
        /// <summary>
        ///  Получить записи пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetUserEntries (Object id, long? count, long? offset);
        /// <summary>
        ///  Получить избранные комментарии пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetUserFavoritesComments (Object id, long? count, long? offset);
        /// <summary>
        ///  Получить избранные записи пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetUserFavoritesEntries (Object id, long? count, long? offset);
        /// <summary>
        ///  Получить избранные вакансии пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GetUserFavoritesVacancies (Object id, long? count, long? offset);
        /// <summary>
        ///  Получить информацию о текущем пользователе
        /// </summary>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GetUserMe ();
        /// <summary>
        ///  Получить комментарии текущего пользователя
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetUserMeComments (long? count, long? offset);
        /// <summary>
        ///  Получить записи текущего пользователя
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetUserMeEntries (long? count, long? offset);
        /// <summary>
        ///  Получить избранные комментарии текущего пользователя
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetUserMeFavoritesComments (long? count, long? offset);
        /// <summary>
        ///  Получить избранные записи текущего пользователя
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetUserMeFavoritesEntries (long? count, long? offset);
        /// <summary>
        ///  Получить вакансии текущего пользователя
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GetUserMeFavoritesVacancies (long? count, long? offset);
        /// <summary>
        ///  Получить рекомендуемые подсайты
        /// </summary>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GetUserMeSubscriptionsRecommended ();
        /// <summary>
        ///  Получить подсайты, на которые пользователь подписан
        /// </summary>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GetUserMeSubscriptionsSubscribed ();
        /// <summary>
        ///  Получить список подсайтов для экрана настройки подсайтов
        /// </summary>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GetUserMeTuneCatalog ();
        /// <summary>
        ///  Получить список уведомлений
        /// </summary>
        /// <param name="isRead">Если равен 1, то все уведомления считаются прочитанными</param>
        /// <param name="lastId">Указывает, начиная с какого уведомления загружать список уведомлений</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 GetUserMeUpdates (long? isRead, long? lastId);
        /// <summary>
        ///  Получить количество непрочитанных уведомлений у текущего пользователя
        /// </summary>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 GetUserMeUpdatesCount ();
        /// <summary>
        ///  Создать запись
        /// </summary>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 UserMeTuneCatalog ();
        /// <summary>
        ///  Сделать уведомления прочитанными
        /// </summary>
        /// <param name="ids">Список Id через запятую</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 UserMeUpdatesRead (string ids);
        /// <summary>
        ///  Сделать уведомление прочитанным
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 UserMeUpdatesReadId (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Добавить в избранное
        /// </summary>
        /// <param name="id">Id элемента</param> 
        /// <param name="type">Тип элемента. 1 - ENTRY, 2 - COMMENT</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 FavoriteAdd (Object id, Object type)
        {
            
    
            var path = "/user/me/favorites";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
if (type != null) formParams.Add("type", ApiClient.ParameterToString(type)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FavoriteAdd: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavoriteAdd: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Удалить из избранного
        /// </summary>
        /// <param name="id">Id элемента</param> 
        /// <param name="type">Тип элемента. 1 - ENTRY, 2 - COMMENT</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 FavoriteRemove (Object id, Object type)
        {
            
    
            var path = "/user/me/favorites/remove";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
if (type != null) formParams.Add("type", ApiClient.ParameterToString(type)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FavoriteRemove: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavoriteRemove: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Получить информацию о пользователе
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 GetUser (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path = "/user/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии пользователя
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetUserComments (Object id, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserComments");
            
    
            var path = "/user/{id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  Получить записи пользователя
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetUserEntries (Object id, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserEntries");
            
    
            var path = "/user/{id}/entries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить избранные комментарии пользователя
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetUserFavoritesComments (Object id, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserFavoritesComments");
            
    
            var path = "/user/{id}/favorites/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  Получить избранные записи пользователя
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetUserFavoritesEntries (Object id, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserFavoritesEntries");
            
    
            var path = "/user/{id}/favorites/entries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить избранные вакансии пользователя
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 GetUserFavoritesVacancies (Object id, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserFavoritesVacancies");
            
    
            var path = "/user/{id}/favorites/vacancies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesVacancies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFavoritesVacancies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        /// <summary>
        ///  Получить информацию о текущем пользователе
        /// </summary>
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 GetUserMe ()
        {
            
    
            var path = "/user/me";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMe: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии текущего пользователя
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetUserMeComments (long? count, long? offset)
        {
            
    
            var path = "/user/me/comments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  Получить записи текущего пользователя
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetUserMeEntries (long? count, long? offset)
        {
            
    
            var path = "/user/me/entries";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить избранные комментарии текущего пользователя
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetUserMeFavoritesComments (long? count, long? offset)
        {
            
    
            var path = "/user/me/favorites/comments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  Получить избранные записи текущего пользователя
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetUserMeFavoritesEntries (long? count, long? offset)
        {
            
    
            var path = "/user/me/favorites/entries";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить вакансии текущего пользователя
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 GetUserMeFavoritesVacancies (long? count, long? offset)
        {
            
    
            var path = "/user/me/favorites/vacancies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesVacancies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeFavoritesVacancies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        /// <summary>
        ///  Получить рекомендуемые подсайты
        /// </summary>
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GetUserMeSubscriptionsRecommended ()
        {
            
    
            var path = "/user/me/subscriptions/recommended";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeSubscriptionsRecommended: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeSubscriptionsRecommended: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        ///  Получить подсайты, на которые пользователь подписан
        /// </summary>
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GetUserMeSubscriptionsSubscribed ()
        {
            
    
            var path = "/user/me/subscriptions/subscribed";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeSubscriptionsSubscribed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeSubscriptionsSubscribed: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        ///  Получить список подсайтов для экрана настройки подсайтов
        /// </summary>
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GetUserMeTuneCatalog ()
        {
            
    
            var path = "/user/me/tunecatalog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeTuneCatalog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeTuneCatalog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        ///  Получить список уведомлений
        /// </summary>
        /// <param name="isRead">Если равен 1, то все уведомления считаются прочитанными</param> 
        /// <param name="lastId">Указывает, начиная с какого уведомления загружать список уведомлений</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 GetUserMeUpdates (long? isRead, long? lastId)
        {
            
    
            var path = "/user/me/updates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (isRead != null) queryParams.Add("is_read", ApiClient.ParameterToString(isRead)); // query parameter
 if (lastId != null) queryParams.Add("last_id", ApiClient.ParameterToString(lastId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        /// <summary>
        ///  Получить количество непрочитанных уведомлений у текущего пользователя
        /// </summary>
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 GetUserMeUpdatesCount ()
        {
            
    
            var path = "/user/me/updates/count";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeUpdatesCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserMeUpdatesCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        /// <summary>
        ///  Создать запись
        /// </summary>
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 UserMeTuneCatalog ()
        {
            
    
            var path = "/user/me/tunecatalog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeTuneCatalog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeTuneCatalog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Сделать уведомления прочитанными
        /// </summary>
        /// <param name="ids">Список Id через запятую</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 UserMeUpdatesRead (string ids)
        {
            
    
            var path = "/user/me/updates/read";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (ids != null) formParams.Add("ids", ApiClient.ParameterToString(ids)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeUpdatesRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeUpdatesRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        /// <summary>
        ///  Сделать уведомление прочитанным
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 UserMeUpdatesReadId (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserMeUpdatesReadId");
            
    
            var path = "/user/me/updates/read/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeUpdatesReadId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMeUpdatesReadId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
    }
}
