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
    public interface IEntryApi
    {
        /// <summary>
        ///  Создать запись
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="subsiteId"></param>
        /// <param name="attachments"></param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 EntryCreate (string title, string text, Object subsiteId, string attachments);
        /// <summary>
        ///  Найти статью по ссылке
        /// </summary>
        /// <param name="url">Ссылка на статью</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 EntryLocate (string url);
        /// <summary>
        ///  Получить запись по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetEntryById (long? id);
        /// <summary>
        ///  Получить популярные записи для определенной записи
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetPopularEntries (long? id);
        /// <summary>
        ///  Лайкнуть запись / комментарий
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">Тип контента:   * &#x60;content&#x60; - запись   * &#x60;comment&#x60; - комментарий</param>
        /// <param name="sign">Изменить рейтинг  * &#x60;-1&#x60; - Понизить  * &#x60;0&#x60; - Сбросить  * &#x60;1&#x60; - Повысить </param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 LikeEntry (long? id, string type, long? sign);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EntryApi : IEntryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EntryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EntryApi(String basePath)
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
        ///  Создать запись
        /// </summary>
        /// <param name="title"></param> 
        /// <param name="text"></param> 
        /// <param name="subsiteId"></param> 
        /// <param name="attachments"></param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 EntryCreate (string title, string text, Object subsiteId, string attachments)
        {
            
    
            var path = "/entry/create";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (title != null) formParams.Add("title", ApiClient.ParameterToString(title)); // form parameter
if (text != null) formParams.Add("text", ApiClient.ParameterToString(text)); // form parameter
if (subsiteId != null) formParams.Add("subsite_id", ApiClient.ParameterToString(subsiteId)); // form parameter
if (attachments != null) formParams.Add("attachments", ApiClient.ParameterToString(attachments)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryCreate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  Найти статью по ссылке
        /// </summary>
        /// <param name="url">Ссылка на статью</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 EntryLocate (string url)
        {
            
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling EntryLocate");
            
    
            var path = "/entry/locate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryLocate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryLocate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  Получить запись по ID
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetEntryById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEntryById");
            
    
            var path = "/entry/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  Получить популярные записи для определенной записи
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetPopularEntries (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPopularEntries");
            
    
            var path = "/entry/{id}/popular";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPopularEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPopularEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Лайкнуть запись / комментарий
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="type">Тип контента:   * &#x60;content&#x60; - запись   * &#x60;comment&#x60; - комментарий</param> 
        /// <param name="sign">Изменить рейтинг  * &#x60;-1&#x60; - Понизить  * &#x60;0&#x60; - Сбросить  * &#x60;1&#x60; - Повысить </param> 
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 LikeEntry (long? id, string type, long? sign)
        {
            
    
            var path = "/like";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
if (type != null) formParams.Add("type", ApiClient.ParameterToString(type)); // form parameter
if (sign != null) formParams.Add("sign", ApiClient.ParameterToString(sign)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LikeEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LikeEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
    }
}
