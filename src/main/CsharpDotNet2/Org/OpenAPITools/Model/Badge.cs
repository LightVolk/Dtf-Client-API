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
  public class Badge {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Color
    /// </summary>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// Gets or Sets Background
    /// </summary>
    [DataMember(Name="background", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "background")]
    public string Background { get; set; }

    /// <summary>
    /// Gets or Sets Border
    /// </summary>
    [DataMember(Name="border", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "border")]
    public string Border { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Badge {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  Background: ").Append(Background).Append("\n");
      sb.Append("  Border: ").Append(Border).Append("\n");
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
