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
  public class Websocket {
    /// <summary>
    /// тип события
    /// </summary>
    /// <value>тип события</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// id статьи
    /// </summary>
    /// <value>id статьи</value>
    [DataMember(Name="content_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_id")]
    public decimal? ContentId { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// id контента
    /// </summary>
    /// <value>id контента</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public int? State { get; set; }

    /// <summary>
    /// хэш пользователя, для сравнения с авторизованным
    /// </summary>
    /// <value>хэш пользователя, для сравнения с авторизованным</value>
    [DataMember(Name="user_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_hash")]
    public string UserHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Websocket {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ContentId: ").Append(ContentId).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  UserHash: ").Append(UserHash).Append("\n");
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
