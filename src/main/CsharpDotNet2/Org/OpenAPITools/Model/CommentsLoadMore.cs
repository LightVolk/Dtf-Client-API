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
  public class CommentsLoadMore {
    /// <summary>
    /// Список id комментариев для подгрузки
    /// </summary>
    /// <value>Список id комментариев для подгрузки</value>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public List<decimal?> Ids { get; set; }

    /// <summary>
    /// Количество подгружаемых комментариев
    /// </summary>
    /// <value>Количество подгружаемых комментариев</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public decimal? Count { get; set; }

    /// <summary>
    /// Список аватарок пользователей в подгружаемых комментариях
    /// </summary>
    /// <value>Список аватарок пользователей в подгружаемых комментариях</value>
    [DataMember(Name="avatars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatars")]
    public List<string> Avatars { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommentsLoadMore {\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Avatars: ").Append(Avatars).Append("\n");
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
