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
    public interface IAuthApi
    {
        /// <summary>
        ///  Авторизация через email
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AuthLogin (string login, string password);
        /// <summary>
        ///  Авторизация через QR код
        /// </summary>
        /// <param name="token"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AuthQr (string token);
        /// <summary>
        ///  Авторизация через социальную сеть
        /// </summary>
        /// <param name="type"></param>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <param name="linking">Если 1, то аккаунт привяжется к текущему</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AuthSocial (string type, string token, string email, int? linking);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthApi : IAuthApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
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
        ///  Авторизация через email
        /// </summary>
        /// <param name="login"></param> 
        /// <param name="password"></param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AuthLogin (string login, string password)
        {
            
    
            var path = "/auth/login";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (login != null) formParams.Add("login", ApiClient.ParameterToString(login)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthLogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthLogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        ///  Авторизация через QR код
        /// </summary>
        /// <param name="token"></param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AuthQr (string token)
        {
            
    
            var path = "/auth/qr";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (token != null) formParams.Add("token", ApiClient.ParameterToString(token)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthQr: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthQr: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        ///  Авторизация через социальную сеть
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="token"></param> 
        /// <param name="email"></param> 
        /// <param name="linking">Если 1, то аккаунт привяжется к текущему</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AuthSocial (string type, string token, string email, int? linking)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling AuthSocial");
            
    
            var path = "/auth/social/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (token != null) formParams.Add("token", ApiClient.ParameterToString(token)); // form parameter
if (email != null) formParams.Add("email", ApiClient.ParameterToString(email)); // form parameter
if (linking != null) formParams.Add("linking", ApiClient.ParameterToString(linking)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthSocial: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthSocial: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
    }
}
