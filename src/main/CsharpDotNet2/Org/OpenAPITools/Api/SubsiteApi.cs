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
    public interface ISubsiteApi
    {
        /// <summary>
        ///  Возвращает подсайт
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GetSubsite (Object id);
        /// <summary>
        ///  Возвращает список статей для подсайта
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sorting"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetSubsiteTimeline (Object id, string sorting, long? count, long? offset);
        /// <summary>
        ///  Получить вакансии для компании
        /// </summary>
        /// <param name="subsiteId">id подсайта</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GetSubsiteVacancies (Object subsiteId);
        /// <summary>
        ///  Подгрузить вакансии для компании
        /// </summary>
        /// <param name="subsiteId">id подсайта</param>
        /// <param name="lastId">last_id из предыдущей подгрузки</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GetSubsiteVacanciesMore (Object subsiteId, Object lastId);
        /// <summary>
        ///  Получить рекомендуемые подсайты для анонимного пользователя
        /// </summary>
        /// <param name="type">Тип контента:   * &#x60;sections&#x60; - подсайты   * &#x60;companies&#x60; - компании </param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GetSubsitesList (string type);
        /// <summary>
        ///  Подписка на подсайт
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 SubsiteSubscribe (Object id);
        /// <summary>
        ///  Отписка от подсайта
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 SubsiteUnsubscribe (Object id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubsiteApi : ISubsiteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubsiteApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubsiteApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubsiteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubsiteApi(String basePath)
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
        ///  Возвращает подсайт
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 GetSubsite (Object id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSubsite");
            
    
            var path = "/subsite/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        ///  Возвращает список статей для подсайта
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="sorting"></param> 
        /// <param name="count"></param> 
        /// <param name="offset"></param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetSubsiteTimeline (Object id, string sorting, long? count, long? offset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSubsiteTimeline");
            
            // verify the required parameter 'sorting' is set
            if (sorting == null) throw new ApiException(400, "Missing required parameter 'sorting' when calling GetSubsiteTimeline");
            
    
            var path = "/subsite/{id}/timeline/{sorting}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteTimeline: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteTimeline: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  Получить вакансии для компании
        /// </summary>
        /// <param name="subsiteId">id подсайта</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 GetSubsiteVacancies (Object subsiteId)
        {
            
            // verify the required parameter 'subsiteId' is set
            if (subsiteId == null) throw new ApiException(400, "Missing required parameter 'subsiteId' when calling GetSubsiteVacancies");
            
    
            var path = "/subsite/{subsite_id}/vacancies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subsite_id" + "}", ApiClient.ParameterToString(subsiteId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteVacancies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteVacancies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        /// <summary>
        ///  Подгрузить вакансии для компании
        /// </summary>
        /// <param name="subsiteId">id подсайта</param> 
        /// <param name="lastId">last_id из предыдущей подгрузки</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 GetSubsiteVacanciesMore (Object subsiteId, Object lastId)
        {
            
            // verify the required parameter 'subsiteId' is set
            if (subsiteId == null) throw new ApiException(400, "Missing required parameter 'subsiteId' when calling GetSubsiteVacanciesMore");
            
            // verify the required parameter 'lastId' is set
            if (lastId == null) throw new ApiException(400, "Missing required parameter 'lastId' when calling GetSubsiteVacanciesMore");
            
    
            var path = "/subsite/{subsite_id}/vacancies/more/{last_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subsite_id" + "}", ApiClient.ParameterToString(subsiteId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteVacanciesMore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsiteVacanciesMore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        /// <summary>
        ///  Получить рекомендуемые подсайты для анонимного пользователя
        /// </summary>
        /// <param name="type">Тип контента:   * &#x60;sections&#x60; - подсайты   * &#x60;companies&#x60; - компании </param> 
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GetSubsitesList (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetSubsitesList");
            
    
            var path = "/subsites_list/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsitesList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubsitesList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        ///  Подписка на подсайт
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse20025</returns>            
        public InlineResponse20025 SubsiteSubscribe (Object id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SubsiteSubscribe");
            
    
            var path = "/subsite/{id}/subscribe";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsiteSubscribe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsiteSubscribe: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20025) ApiClient.Deserialize(response.Content, typeof(InlineResponse20025), response.Headers);
        }
    
        /// <summary>
        ///  Отписка от подсайта
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse20025</returns>            
        public InlineResponse20025 SubsiteUnsubscribe (Object id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SubsiteUnsubscribe");
            
    
            var path = "/subsite/{id}/unsubscribe";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsiteUnsubscribe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsiteUnsubscribe: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20025) ApiClient.Deserialize(response.Content, typeof(InlineResponse20025), response.Headers);
        }
    
    }
}
