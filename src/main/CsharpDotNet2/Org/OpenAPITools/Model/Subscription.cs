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
  public class Subscription {
    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="is_active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets ActiveUntil
    /// </summary>
    [DataMember(Name="active_until", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_until")]
    public decimal? ActiveUntil { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Subscription {\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  ActiveUntil: ").Append(ActiveUntil).Append("\n");
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
