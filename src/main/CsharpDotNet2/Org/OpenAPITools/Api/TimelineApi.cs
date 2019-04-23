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
    public interface ITimelineApi
    {
        /// <summary>
        ///  Получить прикрепленную запись
        /// </summary>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetFlashholder ();
        /// <summary>
        ///  Возвращает ленту записей
        /// </summary>
        /// <param name="category">category entries</param>
        /// <param name="sorting">sorting entries</param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetTimeline (string category, string sorting, long? count, long? offset);
        /// <summary>
        ///  Получить ленту записей по хэштегу
        /// </summary>
        /// <param name="hashtag"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetTimelineByHashtag (string hashtag, long? count, long? offset);
        /// <summary>
        ///  Получить ленту новостей
        /// </summary>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetTimelineNews (long? count, long? offset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TimelineApi : ITimelineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TimelineApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimelineApi(String basePath)
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
        ///  Получить прикрепленную запись
        /// </summary>
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetFlashholder ()
        {
            
    
            var path = "/getflashholdedentry";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlashholder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlashholder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Возвращает ленту записей
        /// </summary>
        /// <param name="category">category entries</param> 
        /// <param name="sorting">sorting entries</param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetTimeline (string category, string sorting, long? count, long? offset)
        {
            
            // verify the required parameter 'category' is set
            if (category == null) throw new ApiException(400, "Missing required parameter 'category' when calling GetTimeline");
            
            // verify the required parameter 'sorting' is set
            if (sorting == null) throw new ApiException(400, "Missing required parameter 'sorting' when calling GetTimeline");
            
    
            var path = "/timeline/{category}/{sorting}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category" + "}", ApiClient.ParameterToString(category));
path = path.Replace("{" + "sorting" + "}", ApiClient.ParameterToString(sorting));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimeline: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimeline: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить ленту записей по хэштегу
        /// </summary>
        /// <param name="hashtag"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetTimelineByHashtag (string hashtag, long? count, long? offset)
        {
            
            // verify the required parameter 'hashtag' is set
            if (hashtag == null) throw new ApiException(400, "Missing required parameter 'hashtag' when calling GetTimelineByHashtag");
            
    
            var path = "/timeline/mainpage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (hashtag != null) queryParams.Add("hashtag", ApiClient.ParameterToString(hashtag)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimelineByHashtag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimelineByHashtag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        ///  Получить ленту новостей
        /// </summary>
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetTimelineNews (long? count, long? offset)
        {
            
    
            var path = "/news/default/recent";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimelineNews: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTimelineNews: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
    }
}
