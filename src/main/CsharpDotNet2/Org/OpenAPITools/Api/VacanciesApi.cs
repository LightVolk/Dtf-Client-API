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
    public interface IVacanciesApi
    {
        /// <summary>
        ///  Возвращает список вакансий
        /// </summary>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GetJob ();
        /// <summary>
        ///  Загружает список фильтров вакансий
        /// </summary>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GetJobFilters ();
        /// <summary>
        ///  Подгружает список вакансий
        /// </summary>
        /// <param name="lastId">Последний ID элемента из предыдущей страницы</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GetJobMore (Object lastId);
        /// <summary>
        ///  Возвращает список вакансий для виджета в списке статей
        /// </summary>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GetVacancies ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VacanciesApi : IVacanciesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VacanciesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VacanciesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VacanciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VacanciesApi(String basePath)
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
        ///  Возвращает список вакансий
        /// </summary>
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 GetJob ()
        {
            
    
            var path = "/job";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        /// <summary>
        ///  Загружает список фильтров вакансий
        /// </summary>
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 GetJobFilters ()
        {
            
    
            var path = "/job/filters";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetJobFilters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetJobFilters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
        /// <summary>
        ///  Подгружает список вакансий
        /// </summary>
        /// <param name="lastId">Последний ID элемента из предыдущей страницы</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 GetJobMore (Object lastId)
        {
            
            // verify the required parameter 'lastId' is set
            if (lastId == null) throw new ApiException(400, "Missing required parameter 'lastId' when calling GetJobMore");
            
    
            var path = "/job/more/{last_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "last_id" + "}", ApiClient.ParameterToString(lastId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetJobMore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetJobMore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        /// <summary>
        ///  Возвращает список вакансий для виджета в списке статей
        /// </summary>
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 GetVacancies ()
        {
            
    
            var path = "/vacancies/widget";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVacancies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVacancies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
    }
}
