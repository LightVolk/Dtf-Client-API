# Org.OpenAPITools.Model.Notification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal?** |  | [optional] 
**Type** | **decimal?** | Тип уведомления:   * &#x60;2&#x60; - TYPE_LIKE   * &#x60;4&#x60; - TYPE_REPLY   * &#x60;8&#x60; - TYPE_BANNED   * &#x60;16&#x60; - TYPE_UNPUBLISH   * &#x60;32&#x60; - TYPE_COMMENT   * &#x60;64&#x60; - TYPE_SYSTEM   * &#x60;128&#x60; - TYPE_VACANCY  | [optional] 
**Date** | **decimal?** |  | [optional] 
**DateRFC** | **string** |  | [optional] 
**Users** | [**List<User>**](User.md) |  | [optional] 
**Text** | **string** |  | [optional] 
**CommentText** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 
**Icon** | **string** | Название иконки, которая подставляется вместо аватарки. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

