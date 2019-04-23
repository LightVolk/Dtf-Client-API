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
    public interface IUploadApi
    {
        /// <summary>
        ///  Загрузить изображение/видео по ссылке.  Все изображения, видео, ссылки, твиты и так далее для прикрепления к комментарию или добавлению в статью должны быть загружены на Основу. В ответ на запрос вы получите JSON-структуру, которую можно будет передать как прикрепление (аттач). 
        /// </summary>
        /// <param name="url"></param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 UploaderExtract (string url);
        /// <summary>
        ///  Загрузить изображение/видео весом до 20 Мб
        /// </summary>
        /// <param name="file"></param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 UploaderUpload (System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UploadApi : IUploadApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UploadApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadApi(String basePath)
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
        ///  Загрузить изображение/видео по ссылке.  Все изображения, видео, ссылки, твиты и так далее для прикрепления к комментарию или добавлению в статью должны быть загружены на Основу. В ответ на запрос вы получите JSON-структуру, которую можно будет передать как прикрепление (аттач). 
        /// </summary>
        /// <param name="url"></param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 UploaderExtract (string url)
        {
            
    
            var path = "/uploader/extract";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (url != null) formParams.Add("url", ApiClient.ParameterToString(url)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploaderExtract: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploaderExtract: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
        /// <summary>
        ///  Загрузить изображение/видео весом до 20 Мб
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 UploaderUpload (System.IO.Stream file)
        {
            
    
            var path = "/uploader/upload";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploaderUpload: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploaderUpload: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
    }
}
