# Org.OpenAPITools.Model.Entry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal?** |  | [optional] 
**Title** | **string** | Заголовок статьи | [optional] 
**WebviewUrl** | **string** | Ссылка, которую нужно открыть вместо открытия статьи | [optional] 
**EntryContent** | [**EntryContent**](EntryContent.md) |  | [optional] 
**Date** | **decimal?** | Дата создания статьи | [optional] 
**DateRFC** | **string** | Дата создания статьи | [optional] 
**LastModificationDate** | **decimal?** | Дата последнего изменения статьи | [optional] 
**Author** | [**Author**](Author.md) |  | [optional] 
**Type** | **int?** | Тип контента:   * &#x60;TYPE_ENTRY&#x60; - 1   * &#x60;TYPE_VACANCY&#x60; - 2   * &#x60;TYPE_STATICPAGE&#x60; - 3   * &#x60;TYPE_EVENT&#x60; - 4   * &#x60;TYPE_REPOST&#x60; - 5  | [optional] 
**Intro** | **string** | Подзаголовок статьи | [optional] 
**Cover** | [**Cover**](Cover.md) |  | [optional] 
**IntroInFeed** | **string** |  | [optional] 
**Similar** | [**List<Similar>**](Similar.md) |  | [optional] 
**HitsCount** | **decimal?** | Число просмотров | [optional] 
**Likes** | [**Likes**](Likes.md) |  | [optional] 
**CommentsPreview** | [**List<Comment>**](Comment.md) | Список аватарок комментирующих для заглушки | [optional] 
**CommentsCount** | **int?** |  | [optional] 
**FavoritesCount** | **int?** |  | [optional] 
**IsFavorited** | **bool?** |  | [optional] 
**IsEnabledLikes** | **bool?** |  | [optional] 
**IsEnabledComments** | **bool?** |  | [optional] 
**IsEditorial** | **bool?** | Показывает, что это пост редакции | [optional] 
**IsPinned** | **bool?** | Показывает, закреплен ли пост | [optional] 
**AudioUrl** | **string** | Ссылка на mp3 файл с озвучкой статьи | [optional] 
**Badges** | [**List<Badge>**](Badge.md) |  | [optional] 
**CommentatorsAvatars** | **List<string>** |  | [optional] 
**Subsite** | [**Subsite**](Subsite.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

