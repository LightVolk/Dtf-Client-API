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
    public interface ILayoutApi
    {
        /// <summary>
        ///  Получить шаблон статьи для WebView
        /// </summary>
        /// <param name="version"></param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 GetLayout (Object version);
        /// <summary>
        ///  Получить шаблон шапки экрана хештега
        /// </summary>
        /// <param name="hashtag"></param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 GetLayoutHashtag (string hashtag);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LayoutApi : ILayoutApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LayoutApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LayoutApi(String basePath)
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
        ///  Получить шаблон статьи для WebView
        /// </summary>
        /// <param name="version"></param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 GetLayout (Object version)
        {
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetLayout");
            
    
            var path = "/layout/{version}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLayout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLayout: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
        /// <summary>
        ///  Получить шаблон шапки экрана хештега
        /// </summary>
        /// <param name="hashtag"></param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 GetLayoutHashtag (string hashtag)
        {
            
            // verify the required parameter 'hashtag' is set
            if (hashtag == null) throw new ApiException(400, "Missing required parameter 'hashtag' when calling GetLayoutHashtag");
            
    
            var path = "/layout/hashtag/{hashtag}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hashtag" + "}", ApiClient.ParameterToString(hashtag));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLayoutHashtag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLayoutHashtag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
    }
}
