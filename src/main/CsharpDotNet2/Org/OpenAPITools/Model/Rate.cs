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
  public class Rate {
    /// <summary>
    /// Gets or Sets _Rate
    /// </summary>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public string _Rate { get; set; }

    /// <summary>
    /// Gets or Sets Change
    /// </summary>
    [DataMember(Name="change", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change")]
    public decimal? Change { get; set; }

    /// <summary>
    /// Gets or Sets Sym
    /// </summary>
    [DataMember(Name="sym", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sym")]
    public string Sym { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Rate {\n");
      sb.Append("  _Rate: ").Append(_Rate).Append("\n");
      sb.Append("  Change: ").Append(Change).Append("\n");
      sb.Append("  Sym: ").Append(Sym).Append("\n");
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
