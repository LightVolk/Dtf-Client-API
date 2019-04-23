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
  public class AdvancedAccessActions {
    /// <summary>
    /// Gets or Sets ReadComments
    /// </summary>
    [DataMember(Name="read_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_comments")]
    public bool? ReadComments { get; set; }

    /// <summary>
    /// Gets or Sets WriteComments
    /// </summary>
    [DataMember(Name="write_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "write_comments")]
    public bool? WriteComments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdvancedAccessActions {\n");
      sb.Append("  ReadComments: ").Append(ReadComments).Append("\n");
      sb.Append("  WriteComments: ").Append(WriteComments).Append("\n");
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
