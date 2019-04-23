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
  public class InlineResponse20026Result {
    /// <summary>
    /// Gets or Sets Area
    /// </summary>
    [DataMember(Name="area", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "area")]
    public List<JobFilter> Area { get; set; }

    /// <summary>
    /// Gets or Sets Cities
    /// </summary>
    [DataMember(Name="cities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cities")]
    public List<JobFilter> Cities { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public List<JobFilter> Schedule { get; set; }

    /// <summary>
    /// Gets or Sets Specializations
    /// </summary>
    [DataMember(Name="specializations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specializations")]
    public List<JobFilter> Specializations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20026Result {\n");
      sb.Append("  Area: ").Append(Area).Append("\n");
      sb.Append("  Cities: ").Append(Cities).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  Specializations: ").Append(Specializations).Append("\n");
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
