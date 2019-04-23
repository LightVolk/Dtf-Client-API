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
  public class Subsite {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets Cover
    /// </summary>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover")]
    public SubsiteCover Cover { get; set; }

    /// <summary>
    /// Gets or Sets IsSubscribed
    /// </summary>
    [DataMember(Name="is_subscribed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_subscribed")]
    public bool? IsSubscribed { get; set; }

    /// <summary>
    /// Gets or Sets IsVerified
    /// </summary>
    [DataMember(Name="is_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_verified")]
    public bool? IsVerified { get; set; }

    /// <summary>
    /// Gets or Sets IsUnsubscribable
    /// </summary>
    [DataMember(Name="is_unsubscribable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_unsubscribable")]
    public bool? IsUnsubscribable { get; set; }

    /// <summary>
    /// Gets or Sets SubscribersCount
    /// </summary>
    [DataMember(Name="subscribers_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribers_count")]
    public int? SubscribersCount { get; set; }

    /// <summary>
    /// Gets or Sets CommentsCount
    /// </summary>
    [DataMember(Name="comments_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_count")]
    public int? CommentsCount { get; set; }

    /// <summary>
    /// Gets or Sets EntriesCount
    /// </summary>
    [DataMember(Name="entries_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries_count")]
    public int? EntriesCount { get; set; }

    /// <summary>
    /// Gets or Sets VacanciesCount
    /// </summary>
    [DataMember(Name="vacancies_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vacancies_count")]
    public int? VacanciesCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Subsite {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Cover: ").Append(Cover).Append("\n");
      sb.Append("  IsSubscribed: ").Append(IsSubscribed).Append("\n");
      sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
      sb.Append("  IsUnsubscribable: ").Append(IsUnsubscribable).Append("\n");
      sb.Append("  SubscribersCount: ").Append(SubscribersCount).Append("\n");
      sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
      sb.Append("  EntriesCount: ").Append(EntriesCount).Append("\n");
      sb.Append("  VacanciesCount: ").Append(VacanciesCount).Append("\n");
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
