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
  public class Comment {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public decimal? Date { get; set; }

    /// <summary>
    /// Gets or Sets DateRFC
    /// </summary>
    [DataMember(Name="dateRFC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateRFC")]
    public string DateRFC { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public Author Author { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public List<Medium> Media { get; set; }

    /// <summary>
    /// Gets or Sets Likes
    /// </summary>
    [DataMember(Name="likes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likes")]
    public Likes Likes { get; set; }

    /// <summary>
    /// Gets or Sets Entry
    /// </summary>
    [DataMember(Name="entry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entry")]
    public Entry Entry { get; set; }

    /// <summary>
    /// Gets or Sets ReplyTo
    /// </summary>
    [DataMember(Name="replyTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replyTo")]
    public int? ReplyTo { get; set; }

    /// <summary>
    /// Gets or Sets IsFavorited
    /// </summary>
    [DataMember(Name="isFavorited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFavorited")]
    public bool? IsFavorited { get; set; }

    /// <summary>
    /// Gets or Sets IsPinned
    /// </summary>
    [DataMember(Name="is_pinned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_pinned")]
    public bool? IsPinned { get; set; }

    /// <summary>
    /// Gets or Sets IsEdited
    /// </summary>
    [DataMember(Name="isEdited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEdited")]
    public bool? IsEdited { get; set; }

    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public int? Level { get; set; }

    /// <summary>
    /// С какой OS был написан комментарий:   * `0` - Other   * `1` - iOS   * `2` - Android 
    /// </summary>
    /// <value>С какой OS был написан комментарий:   * `0` - Other   * `1` - iOS   * `2` - Android </value>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_id")]
    public int? SourceId { get; set; }

    /// <summary>
    /// Gets or Sets LoadMore
    /// </summary>
    [DataMember(Name="load_more", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "load_more")]
    public CommentsLoadMore LoadMore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Comment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  DateRFC: ").Append(DateRFC).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  Likes: ").Append(Likes).Append("\n");
      sb.Append("  Entry: ").Append(Entry).Append("\n");
      sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
      sb.Append("  IsFavorited: ").Append(IsFavorited).Append("\n");
      sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
      sb.Append("  IsEdited: ").Append(IsEdited).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  LoadMore: ").Append(LoadMore).Append("\n");
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
