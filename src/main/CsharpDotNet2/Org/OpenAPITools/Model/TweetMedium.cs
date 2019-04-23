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
  public class TweetMedium {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailUrl
    /// </summary>
    [DataMember(Name="thumbnail_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    /// <summary>
    /// Gets or Sets MediaUrl
    /// </summary>
    [DataMember(Name="media_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media_url")]
    public string MediaUrl { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailWidth
    /// </summary>
    [DataMember(Name="thumbnail_width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail_width")]
    public decimal? ThumbnailWidth { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailHeight
    /// </summary>
    [DataMember(Name="thumbnail_height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail_height")]
    public decimal? ThumbnailHeight { get; set; }

    /// <summary>
    /// Gets or Sets Ratio
    /// </summary>
    [DataMember(Name="ratio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratio")]
    public decimal? Ratio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TweetMedium {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
      sb.Append("  MediaUrl: ").Append(MediaUrl).Append("\n");
      sb.Append("  ThumbnailWidth: ").Append(ThumbnailWidth).Append("\n");
      sb.Append("  ThumbnailHeight: ").Append(ThumbnailHeight).Append("\n");
      sb.Append("  Ratio: ").Append(Ratio).Append("\n");
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
