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
  public class Likes {
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Summ
    /// </summary>
    [DataMember(Name="summ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summ")]
    public int? Summ { get; set; }

    /// <summary>
    /// Gets or Sets IsLiked
    /// </summary>
    [DataMember(Name="is_liked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_liked")]
    public int? IsLiked { get; set; }

    /// <summary>
    /// Gets or Sets IsHidden
    /// </summary>
    [DataMember(Name="is_hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_hidden")]
    public bool? IsHidden { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Likes {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Summ: ").Append(Summ).Append("\n");
      sb.Append("  IsLiked: ").Append(IsLiked).Append("\n");
      sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
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
