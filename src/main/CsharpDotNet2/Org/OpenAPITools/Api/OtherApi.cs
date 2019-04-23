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
    public interface IOtherApi
    {
        /// <summary>
        ///  Жалоба на комментарий
        /// </summary>
        /// <param name="commentId">Id комментария</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 EntryCommentComplaint (Object commentId);
        /// <summary>
        ///  Жалоба на статью
        /// </summary>
        /// <param name="contentId">Id статьи</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 EntryComplaint (Object contentId);
        /// <summary>
        ///  Получить контент по ссылке
        /// </summary>
        /// <param name="url">Ссылка на страницу сайта</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 Locate (string url);
        /// <summary>
        ///  Поиск
        /// </summary>
        /// <param name="query">Строка для поиска</param>
        /// <param name="orderBy">Сортировка:   * &#x60;relevant&#x60; - По важности   * &#x60;date&#x60; - По дате </param>
        /// <param name="page"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 Search (string query, string orderBy, int? page);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OtherApi : IOtherApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OtherApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OtherApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OtherApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OtherApi(String basePath)
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
        ///  Жалоба на комментарий
        /// </summary>
        /// <param name="commentId">Id комментария</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 EntryCommentComplaint (Object commentId)
        {
            
    
            var path = "/entry/comment/complaint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (commentId != null) formParams.Add("comment_id", ApiClient.ParameterToString(commentId)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryCommentComplaint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryCommentComplaint: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Жалоба на статью
        /// </summary>
        /// <param name="contentId">Id статьи</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 EntryComplaint (Object contentId)
        {
            
    
            var path = "/entry/complaint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (contentId != null) formParams.Add("content_id", ApiClient.ParameterToString(contentId)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryComplaint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EntryComplaint: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Получить контент по ссылке
        /// </summary>
        /// <param name="url">Ссылка на страницу сайта</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 Locate (string url)
        {
            
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling Locate");
            
    
            var path = "/locate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Locate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Locate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
        /// <summary>
        ///  Поиск
        /// </summary>
        /// <param name="query">Строка для поиска</param> 
        /// <param name="orderBy">Сортировка:   * &#x60;relevant&#x60; - По важности   * &#x60;date&#x60; - По дате </param> 
        /// <param name="page"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 Search (string query, string orderBy, int? page)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling Search");
            
    
            var path = "/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (orderBy != null) queryParams.Add("order_by", ApiClient.ParameterToString(orderBy)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
    }
}
