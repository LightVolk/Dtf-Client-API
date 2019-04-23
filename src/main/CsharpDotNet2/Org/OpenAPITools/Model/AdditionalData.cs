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
  public class AdditionalData {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public decimal? Size { get; set; }

    /// <summary>
    /// Gets or Sets Uuid
    /// </summary>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public decimal? Duration { get; set; }

    /// <summary>
    /// Gets or Sets HasAudio
    /// </summary>
    [DataMember(Name="hasAudio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasAudio")]
    public bool? HasAudio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  HasAudio: ").Append(HasAudio).Append("\n");
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
