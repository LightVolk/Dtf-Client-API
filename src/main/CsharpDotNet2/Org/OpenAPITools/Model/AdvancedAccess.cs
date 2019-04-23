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
  public class AdvancedAccess {
    /// <summary>
    /// Gets or Sets IsNeedsAdvancedAccess
    /// </summary>
    [DataMember(Name="is_needs_advanced_access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_needs_advanced_access")]
    public bool? IsNeedsAdvancedAccess { get; set; }

    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public AdvancedAccessActions Actions { get; set; }

    /// <summary>
    /// Gets or Sets DtfSubscription
    /// </summary>
    [DataMember(Name="dtf_subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dtf_subscription")]
    public Subscription DtfSubscription { get; set; }

    /// <summary>
    /// Gets or Sets TvSubscription
    /// </summary>
    [DataMember(Name="tv_subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tv_subscription")]
    public Subscription TvSubscription { get; set; }

    /// <summary>
    /// Gets or Sets VcSubscription
    /// </summary>
    [DataMember(Name="vc_subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vc_subscription")]
    public Subscription VcSubscription { get; set; }

    /// <summary>
    /// Gets or Sets Hash
    /// </summary>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdvancedAccess {\n");
      sb.Append("  IsNeedsAdvancedAccess: ").Append(IsNeedsAdvancedAccess).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  DtfSubscription: ").Append(DtfSubscription).Append("\n");
      sb.Append("  TvSubscription: ").Append(TvSubscription).Append("\n");
      sb.Append("  VcSubscription: ").Append(VcSubscription).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
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
