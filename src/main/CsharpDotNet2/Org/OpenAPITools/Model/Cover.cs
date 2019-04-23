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
  public class Cover {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalData
    /// </summary>
    [DataMember(Name="additionalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalData")]
    public AdditionalData AdditionalData { get; set; }

    /// <summary>
    /// Gets or Sets ThumbnailUrl
    /// </summary>
    [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnailUrl")]
    public string ThumbnailUrl { get; set; }

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
    public Size Size { get; set; }

    /// <summary>
    /// Gets or Sets SizeSimple
    /// </summary>
    [DataMember(Name="sizeSimple", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeSimple")]
    public string SizeSimple { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Cover {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
      sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  SizeSimple: ").Append(SizeSimple).Append("\n");
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
