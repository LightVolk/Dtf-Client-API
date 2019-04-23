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
  public class InlineResponse20024Result {
    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<Vacancy> Items { get; set; }

    /// <summary>
    /// ID последнего элемента для подгрузки
    /// </summary>
    /// <value>ID последнего элемента для подгрузки</value>
    [DataMember(Name="last_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_id")]
    public decimal? LastId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20024Result {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  LastId: ").Append(LastId).Append("\n");
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
