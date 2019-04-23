using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Entry {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Заголовок статьи
    /// </summary>
    /// <value>Заголовок статьи</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Ссылка, которую нужно открыть вместо открытия статьи
    /// </summary>
    /// <value>Ссылка, которую нужно открыть вместо открытия статьи</value>
    [DataMember(Name="webviewUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webviewUrl")]
    public string WebviewUrl { get; set; }

    /// <summary>
    /// Gets or Sets EntryContent
    /// </summary>
    [DataMember(Name="entryContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryContent")]
    public EntryContent EntryContent { get; set; }

    /// <summary>
    /// Дата создания статьи
    /// </summary>
    /// <value>Дата создания статьи</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public decimal? Date { get; set; }

    /// <summary>
    /// Дата создания статьи
    /// </summary>
    /// <value>Дата создания статьи</value>
    [DataMember(Name="dateRFC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateRFC")]
    public string DateRFC { get; set; }

    /// <summary>
    /// Дата последнего изменения статьи
    /// </summary>
    /// <value>Дата последнего изменения статьи</value>
    [DataMember(Name="lastModificationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModificationDate")]
    public decimal? LastModificationDate { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public Author Author { get; set; }

    /// <summary>
    /// Тип контента:   * `TYPE_ENTRY` - 1   * `TYPE_VACANCY` - 2   * `TYPE_STATICPAGE` - 3   * `TYPE_EVENT` - 4   * `TYPE_REPOST` - 5 
    /// </summary>
    /// <value>Тип контента:   * `TYPE_ENTRY` - 1   * `TYPE_VACANCY` - 2   * `TYPE_STATICPAGE` - 3   * `TYPE_EVENT` - 4   * `TYPE_REPOST` - 5 </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// Подзаголовок статьи
    /// </summary>
    /// <value>Подзаголовок статьи</value>
    [DataMember(Name="intro", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intro")]
    public string Intro { get; set; }

    /// <summary>
    /// Gets or Sets Cover
    /// </summary>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover")]
    public Cover Cover { get; set; }

    /// <summary>
    /// Gets or Sets IntroInFeed
    /// </summary>
    [DataMember(Name="introInFeed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "introInFeed")]
    public string IntroInFeed { get; set; }

    /// <summary>
    /// Gets or Sets Similar
    /// </summary>
    [DataMember(Name="similar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "similar")]
    public List<Similar> Similar { get; set; }

    /// <summary>
    /// Число просмотров
    /// </summary>
    /// <value>Число просмотров</value>
    [DataMember(Name="hitsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hitsCount")]
    public decimal? HitsCount { get; set; }

    /// <summary>
    /// Gets or Sets Likes
    /// </summary>
    [DataMember(Name="likes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likes")]
    public Likes Likes { get; set; }

    /// <summary>
    /// Список аватарок комментирующих для заглушки
    /// </summary>
    /// <value>Список аватарок комментирующих для заглушки</value>
    [DataMember(Name="commentsPreview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commentsPreview")]
    public List<Comment> CommentsPreview { get; set; }

    /// <summary>
    /// Gets or Sets CommentsCount
    /// </summary>
    [DataMember(Name="commentsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commentsCount")]
    public int? CommentsCount { get; set; }

    /// <summary>
    /// Gets or Sets FavoritesCount
    /// </summary>
    [DataMember(Name="favoritesCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "favoritesCount")]
    public int? FavoritesCount { get; set; }

    /// <summary>
    /// Gets or Sets IsFavorited
    /// </summary>
    [DataMember(Name="isFavorited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFavorited")]
    public bool? IsFavorited { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledLikes
    /// </summary>
    [DataMember(Name="isEnabledLikes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledLikes")]
    public bool? IsEnabledLikes { get; set; }

    /// <summary>
    /// Gets or Sets IsEnabledComments
    /// </summary>
    [DataMember(Name="isEnabledComments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEnabledComments")]
    public bool? IsEnabledComments { get; set; }

    /// <summary>
    /// Показывает, что это пост редакции
    /// </summary>
    /// <value>Показывает, что это пост редакции</value>
    [DataMember(Name="isEditorial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEditorial")]
    public bool? IsEditorial { get; set; }

    /// <summary>
    /// Показывает, закреплен ли пост
    /// </summary>
    /// <value>Показывает, закреплен ли пост</value>
    [DataMember(Name="isPinned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>
    /// Ссылка на mp3 файл с озвучкой статьи
    /// </summary>
    /// <value>Ссылка на mp3 файл с озвучкой статьи</value>
    [DataMember(Name="audioUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "audioUrl")]
    public string AudioUrl { get; set; }

    /// <summary>
    /// Gets or Sets Badges
    /// </summary>
    [DataMember(Name="badges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "badges")]
    public List<Badge> Badges { get; set; }

    /// <summary>
    /// Gets or Sets CommentatorsAvatars
    /// </summary>
    [DataMember(Name="commentatorsAvatars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commentatorsAvatars")]
    public List<string> CommentatorsAvatars { get; set; }

    /// <summary>
    /// Gets or Sets Subsite
    /// </summary>
    [DataMember(Name="subsite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subsite")]
    public Subsite Subsite { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Entry {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  WebviewUrl: ").Append(WebviewUrl).Append("\n");
      sb.Append("  EntryContent: ").Append(EntryContent).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  DateRFC: ").Append(DateRFC).Append("\n");
      sb.Append("  LastModificationDate: ").Append(LastModificationDate).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Intro: ").Append(Intro).Append("\n");
      sb.Append("  Cover: ").Append(Cover).Append("\n");
      sb.Append("  IntroInFeed: ").Append(IntroInFeed).Append("\n");
      sb.Append("  Similar: ").Append(Similar).Append("\n");
      sb.Append("  HitsCount: ").Append(HitsCount).Append("\n");
      sb.Append("  Likes: ").Append(Likes).Append("\n");
      sb.Append("  CommentsPreview: ").Append(CommentsPreview).Append("\n");
      sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
      sb.Append("  FavoritesCount: ").Append(FavoritesCount).Append("\n");
      sb.Append("  IsFavorited: ").Append(IsFavorited).Append("\n");
      sb.Append("  IsEnabledLikes: ").Append(IsEnabledLikes).Append("\n");
      sb.Append("  IsEnabledComments: ").Append(IsEnabledComments).Append("\n");
      sb.Append("  IsEditorial: ").Append(IsEditorial).Append("\n");
      sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
      sb.Append("  AudioUrl: ").Append(AudioUrl).Append("\n");
      sb.Append("  Badges: ").Append(Badges).Append("\n");
      sb.Append("  CommentatorsAvatars: ").Append(CommentatorsAvatars).Append("\n");
      sb.Append("  Subsite: ").Append(Subsite).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
