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
    public interface ICommentApi
    {
        /// <summary>
        ///  Отредактировать комментарий
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="entryId"></param>
        /// <param name="text"></param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 CommentEdit (long? commentId, long? entryId, string text);
        /// <summary>
        ///  Отправить количество увиденных комментариев
        /// </summary>
        /// <param name="contentId">Id записи</param>
        /// <param name="count">Последнее увиденное количество</param>
        /// <returns></returns>
        void CommentSaveCommentsSeenCount (long? contentId, long? count);
        /// <summary>
        ///  Отправить комментарий. Чтобы создать комментарий с прикреплениями, в запросе нужно передать поле attachments. Внутри должен быть JSON-массив с приложениями, предварительно загруженными через API в том же формате, который был получен при загрузке.  При отправке комментариев с помощью API у вас есть возможность создать ссылку в формате markdown: **&#x60;[text on place of link](https://ya.ru/)&#x60;** 
        /// </summary>
        /// <param name="id">id записи</param>
        /// <param name="text">текст комментария</param>
        /// <param name="replyTo">id комментария, на который отвечаем (или 0)</param>
        /// <param name="attachments"></param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 CommentSend (string id, string text, string replyTo, string attachments);
        /// <summary>
        ///  Получить список лайкнувших комментарий
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetCommentLikes (long? id);
        /// <summary>
        ///  Получить комментарии к записи
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sorting"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetEntryComments (long? id, string sorting);
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sorting"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetEntryCommentsLevelsGet (long? id, string sorting);
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sorting"></param>
        /// <param name="ids">Список id корневых комментариев для загрузки веток</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetEntryCommentsLevelsPost (long? id, string sorting, int? ids);
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="entryId"></param>
        /// <param name="commentId"></param>
        /// <returns></returns>
        void GetEntryCommentsThread (long? entryId, long? commentId);
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
    public class CommentApi : ICommentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CommentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommentApi(String basePath)
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
        ///  Отредактировать комментарий
        /// </summary>
        /// <param name="commentId"></param> 
        /// <param name="entryId"></param> 
        /// <param name="text"></param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 CommentEdit (long? commentId, long? entryId, string text)
        {
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling CommentEdit");
            
            // verify the required parameter 'entryId' is set
            if (entryId == null) throw new ApiException(400, "Missing required parameter 'entryId' when calling CommentEdit");
            
    
            var path = "/comment/edit/{commentId}/{entryId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "commentId" + "}", ApiClient.ParameterToString(commentId));
path = path.Replace("{" + "entryId" + "}", ApiClient.ParameterToString(entryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (text != null) formParams.Add("text", ApiClient.ParameterToString(text)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentEdit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentEdit: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        ///  Отправить количество увиденных комментариев
        /// </summary>
        /// <param name="contentId">Id записи</param> 
        /// <param name="count">Последнее увиденное количество</param> 
        /// <returns></returns>            
        public void CommentSaveCommentsSeenCount (long? contentId, long? count)
        {
            
    
            var path = "/comment/saveCommentsSeenCount";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (contentId != null) formParams.Add("content_id", ApiClient.ParameterToString(contentId)); // form parameter
if (count != null) formParams.Add("count", ApiClient.ParameterToString(count)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentSaveCommentsSeenCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentSaveCommentsSeenCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Отправить комментарий. Чтобы создать комментарий с прикреплениями, в запросе нужно передать поле attachments. Внутри должен быть JSON-массив с приложениями, предварительно загруженными через API в том же формате, который был получен при загрузке.  При отправке комментариев с помощью API у вас есть возможность создать ссылку в формате markdown: **&#x60;[text on place of link](https://ya.ru/)&#x60;** 
        /// </summary>
        /// <param name="id">id записи</param> 
        /// <param name="text">текст комментария</param> 
        /// <param name="replyTo">id комментария, на который отвечаем (или 0)</param> 
        /// <param name="attachments"></param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 CommentSend (string id, string text, string replyTo, string attachments)
        {
            
    
            var path = "/comment/add";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
if (text != null) formParams.Add("text", ApiClient.ParameterToString(text)); // form parameter
if (replyTo != null) formParams.Add("reply_to", ApiClient.ParameterToString(replyTo)); // form parameter
if (attachments != null) formParams.Add("attachments", ApiClient.ParameterToString(attachments)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentSend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommentSend: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        ///  Получить список лайкнувших комментарий
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 GetCommentLikes (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCommentLikes");
            
    
            var path = "/comment/likers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommentLikes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommentLikes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии к записи
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="sorting"></param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetEntryComments (long? id, string sorting)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEntryComments");
            
            // verify the required parameter 'sorting' is set
            if (sorting == null) throw new ApiException(400, "Missing required parameter 'sorting' when calling GetEntryComments");
            
    
            var path = "/entry/{id}/comments/{sorting}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sorting" + "}", ApiClient.ParameterToString(sorting));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="sorting"></param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 GetEntryCommentsLevelsGet (long? id, string sorting)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEntryCommentsLevelsGet");
            
            // verify the required parameter 'sorting' is set
            if (sorting == null) throw new ApiException(400, "Missing required parameter 'sorting' when calling GetEntryCommentsLevelsGet");
            
    
            var path = "/entry/{id}/comments/levels/{sorting}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sorting" + "}", ApiClient.ParameterToString(sorting));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsLevelsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsLevelsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="sorting"></param> 
        /// <param name="ids">Список id корневых комментариев для загрузки веток</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 GetEntryCommentsLevelsPost (long? id, string sorting, int? ids)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEntryCommentsLevelsPost");
            
            // verify the required parameter 'sorting' is set
            if (sorting == null) throw new ApiException(400, "Missing required parameter 'sorting' when calling GetEntryCommentsLevelsPost");
            
    
            var path = "/entry/{id}/comments/levels/{sorting}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sorting" + "}", ApiClient.ParameterToString(sorting));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids[]", ApiClient.ParameterToString(ids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsLevelsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsLevelsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        ///  Получить комментарии к записи с ограничением по веткам
        /// </summary>
        /// <param name="entryId"></param> 
        /// <param name="commentId"></param> 
        /// <returns></returns>            
        public void GetEntryCommentsThread (long? entryId, long? commentId)
        {
            
            // verify the required parameter 'entryId' is set
            if (entryId == null) throw new ApiException(400, "Missing required parameter 'entryId' when calling GetEntryCommentsThread");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling GetEntryCommentsThread");
            
    
            var path = "/entry/{entryId}/comments/thread/{commentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "entryId" + "}", ApiClient.ParameterToString(entryId));
path = path.Replace("{" + "commentId" + "}", ApiClient.ParameterToString(commentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsThread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntryCommentsThread: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
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
