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
    public interface IWebhooksSubscriptionsApi
    {
        /// <summary>
        ///  Подписаться на событие
        /// </summary>
        /// <param name="url">Ссылка на которую будут отправлены данные по событию</param>
        /// <param name="_event">Название события</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 ApiWebhookAdd (string url, string _event);
        /// <summary>
        ///  Удаление подписки на событие
        /// </summary>
        /// <param name="_event">Название события</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 ApiWebhookDel (string _event);
        /// <summary>
        ///  Получить события на которые подписан пользователь
        /// </summary>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 ApiWebhooksGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksSubscriptionsApi : IWebhooksSubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhooksSubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksSubscriptionsApi(String basePath)
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
        ///  Подписаться на событие
        /// </summary>
        /// <param name="url">Ссылка на которую будут отправлены данные по событию</param> 
        /// <param name="_event">Название события</param> 
        /// <returns>InlineResponse20028</returns>            
        public InlineResponse20028 ApiWebhookAdd (string url, string _event)
        {
            
    
            var path = "/webhooks/add";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (url != null) formParams.Add("url", ApiClient.ParameterToString(url)); // form parameter
if (_event != null) formParams.Add("event", ApiClient.ParameterToString(_event)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhookAdd: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhookAdd: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        ///  Удаление подписки на событие
        /// </summary>
        /// <param name="_event">Название события</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 ApiWebhookDel (string _event)
        {
            
    
            var path = "/webhooks/del";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (_event != null) formParams.Add("event", ApiClient.ParameterToString(_event)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhookDel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhookDel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        /// <summary>
        ///  Получить события на которые подписан пользователь
        /// </summary>
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 ApiWebhooksGet ()
        {
            
    
            var path = "/webhooks/get";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiWebhooksGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
    }
}
