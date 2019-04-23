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
    public interface ITweetsApi
    {
        /// <summary>
        ///  Возвращает ленту твитов
        /// </summary>
        /// <param name="mode">tweets mode sorting</param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse20021</returns>
        InlineResponse20021 GetTweets (string mode, long? count, long? offset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TweetsApi : ITweetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TweetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TweetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TweetsApi(String basePath)
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
        ///  Возвращает ленту твитов
        /// </summary>
        /// <param name="mode">tweets mode sorting</param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse20021</returns>            
        public InlineResponse20021 GetTweets (string mode, long? count, long? offset)
        {
            
            // verify the required parameter 'mode' is set
            if (mode == null) throw new ApiException(400, "Missing required parameter 'mode' when calling GetTweets");
            
    
            var path = "/tweets/{mode}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mode" + "}", ApiClient.ParameterToString(mode));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTweets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTweets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20021) ApiClient.Deserialize(response.Content, typeof(InlineResponse20021), response.Headers);
        }
    
    }
}
