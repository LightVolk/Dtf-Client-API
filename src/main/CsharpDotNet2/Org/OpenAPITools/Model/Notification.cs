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
  public class Notification {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Тип уведомления:   * `2` - TYPE_LIKE   * `4` - TYPE_REPLY   * `8` - TYPE_BANNED   * `16` - TYPE_UNPUBLISH   * `32` - TYPE_COMMENT   * `64` - TYPE_SYSTEM   * `128` - TYPE_VACANCY 
    /// </summary>
    /// <value>Тип уведомления:   * `2` - TYPE_LIKE   * `4` - TYPE_REPLY   * `8` - TYPE_BANNED   * `16` - TYPE_UNPUBLISH   * `32` - TYPE_COMMENT   * `64` - TYPE_SYSTEM   * `128` - TYPE_VACANCY </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public decimal? Type { get; set; }

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
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<User> Users { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets CommentText
    /// </summary>
    [DataMember(Name="comment_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment_text")]
    public string CommentText { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Название иконки, которая подставляется вместо аватарки.
    /// </summary>
    /// <value>Название иконки, которая подставляется вместо аватарки.</value>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Notification {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  DateRFC: ").Append(DateRFC).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  CommentText: ").Append(CommentText).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
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
