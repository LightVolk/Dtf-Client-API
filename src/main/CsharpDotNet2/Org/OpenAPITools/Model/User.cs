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
  public class User {
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
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public decimal? Created { get; set; }

    /// <summary>
    /// Gets or Sets CreatedRFC
    /// </summary>
    [DataMember(Name="createdRFC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdRFC")]
    public string CreatedRFC { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Аватарка профиля
    /// </summary>
    /// <value>Аватарка профиля</value>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets Karma
    /// </summary>
    [DataMember(Name="karma", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "karma")]
    public decimal? Karma { get; set; }

    /// <summary>
    /// Список прикрепленных аккаунтов
    /// </summary>
    /// <value>Список прикрепленных аккаунтов</value>
    [DataMember(Name="social_accounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "social_accounts")]
    public List<SocialAccount> SocialAccounts { get; set; }

    /// <summary>
    /// Личный топик пользователя в Firebase Messaging
    /// </summary>
    /// <value>Личный топик пользователя в Firebase Messaging</value>
    [DataMember(Name="push_topic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push_topic")]
    public string PushTopic { get; set; }

    /// <summary>
    /// Gets or Sets AdvancedAccess
    /// </summary>
    [DataMember(Name="advanced_access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_access")]
    public AdvancedAccess AdvancedAccess { get; set; }

    /// <summary>
    /// Gets or Sets Counters
    /// </summary>
    [DataMember(Name="counters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "counters")]
    public Counters Counters { get; set; }

    /// <summary>
    /// Gets or Sets Cover
    /// </summary>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover")]
    public CoverUser Cover { get; set; }

    /// <summary>
    /// Хеш ID пользователя. Используется для сравнения данных, где ID захеширован
    /// </summary>
    /// <value>Хеш ID пользователя. Используется для сравнения данных, где ID захеширован</value>
    [DataMember(Name="user_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_hash")]
    public string UserHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CreatedRFC: ").Append(CreatedRFC).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Karma: ").Append(Karma).Append("\n");
      sb.Append("  SocialAccounts: ").Append(SocialAccounts).Append("\n");
      sb.Append("  PushTopic: ").Append(PushTopic).Append("\n");
      sb.Append("  AdvancedAccess: ").Append(AdvancedAccess).Append("\n");
      sb.Append("  Counters: ").Append(Counters).Append("\n");
      sb.Append("  Cover: ").Append(Cover).Append("\n");
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
