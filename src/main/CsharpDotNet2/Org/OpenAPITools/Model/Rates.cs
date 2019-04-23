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
  public class Rates {
    /// <summary>
    /// Gets or Sets Usd
    /// </summary>
    [DataMember(Name="usd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usd")]
    public Rate Usd { get; set; }

    /// <summary>
    /// Gets or Sets Eur
    /// </summary>
    [DataMember(Name="eur", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eur")]
    public Rate Eur { get; set; }

    /// <summary>
    /// Gets or Sets Btc
    /// </summary>
    [DataMember(Name="btc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "btc")]
    public Rate Btc { get; set; }

    /// <summary>
    /// Gets or Sets Eth
    /// </summary>
    [DataMember(Name="eth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eth")]
    public Rate Eth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Rates {\n");
      sb.Append("  Usd: ").Append(Usd).Append("\n");
      sb.Append("  Eur: ").Append(Eur).Append("\n");
      sb.Append("  Btc: ").Append(Btc).Append("\n");
      sb.Append("  Eth: ").Append(Eth).Append("\n");
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
