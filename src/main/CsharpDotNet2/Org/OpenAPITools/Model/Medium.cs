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
  public class Medium {
    /// <summary>
    /// Тип медиафайла:   * `1` - TYPE_IMAGE   * `2` - TYPE_VIDEO 
    /// </summary>
    /// <value>Тип медиафайла:   * `1` - TYPE_IMAGE   * `2` - TYPE_VIDEO </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// Gets or Sets ImageUrl
    /// </summary>
    [DataMember(Name="imageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageUrl")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or Sets IframeUrl
    /// </summary>
    [DataMember(Name="iframeUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iframeUrl")]
    public string IframeUrl { get; set; }

    /// <summary>
    /// Gets or Sets Service
    /// </summary>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public string Service { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalData
    /// </summary>
    [DataMember(Name="additionalData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalData")]
    public AdditionalData AdditionalData { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public Size Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Medium {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  IframeUrl: ").Append(IframeUrl).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
