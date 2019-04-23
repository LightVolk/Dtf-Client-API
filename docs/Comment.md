# Org.OpenAPITools.Model.Comment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal?** |  | [optional] 
**Date** | **decimal?** |  | [optional] 
**DateRFC** | **string** |  | [optional] 
**Author** | [**Author**](Author.md) |  | [optional] 
**Text** | **string** |  | [optional] 
**Media** | [**List<Medium>**](Medium.md) |  | [optional] 
**Likes** | [**Likes**](Likes.md) |  | [optional] 
**Entry** | [**Entry**](Entry.md) |  | [optional] 
**ReplyTo** | **int?** |  | [optional] 
**IsFavorited** | **bool?** |  | [optional] 
**IsPinned** | **bool?** |  | [optional] 
**IsEdited** | **bool?** |  | [optional] 
**Level** | **int?** |  | [optional] 
**SourceId** | **int?** | С какой OS был написан комментарий:   * &#x60;0&#x60; - Other   * &#x60;1&#x60; - iOS   * &#x60;2&#x60; - Android  | [optional] 
**LoadMore** | [**CommentsLoadMore**](CommentsLoadMore.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

