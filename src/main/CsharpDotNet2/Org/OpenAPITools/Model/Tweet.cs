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
  public class Tweet {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public TweetUser User { get; set; }

    /// <summary>
    /// Gets or Sets RetweetCount
    /// </summary>
    [DataMember(Name="retweet_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retweet_count")]
    public decimal? RetweetCount { get; set; }

    /// <summary>
    /// Gets or Sets FavoriteCount
    /// </summary>
    [DataMember(Name="favorite_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "favorite_count")]
    public decimal? FavoriteCount { get; set; }

    /// <summary>
    /// Gets or Sets HasMedia
    /// </summary>
    [DataMember(Name="has_media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_media")]
    public bool? HasMedia { get; set; }

    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public List<TweetMedium> Media { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public decimal? CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Tweet {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  RetweetCount: ").Append(RetweetCount).Append("\n");
      sb.Append("  FavoriteCount: ").Append(FavoriteCount).Append("\n");
      sb.Append("  HasMedia: ").Append(HasMedia).Append("\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
