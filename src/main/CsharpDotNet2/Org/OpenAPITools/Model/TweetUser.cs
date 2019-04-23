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
  public class TweetUser {
    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public decimal? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets FollowersCount
    /// </summary>
    [DataMember(Name="followers_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "followers_count")]
    public decimal? FollowersCount { get; set; }

    /// <summary>
    /// Gets or Sets FriendsCount
    /// </summary>
    [DataMember(Name="friends_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friends_count")]
    public decimal? FriendsCount { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ProfileImageUrl
    /// </summary>
    [DataMember(Name="profile_image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile_image_url")]
    public string ProfileImageUrl { get; set; }

    /// <summary>
    /// Gets or Sets ProfileImageUrlBigger
    /// </summary>
    [DataMember(Name="profile_image_url_bigger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile_image_url_bigger")]
    public string ProfileImageUrlBigger { get; set; }

    /// <summary>
    /// Gets or Sets ScreenName
    /// </summary>
    [DataMember(Name="screen_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "screen_name")]
    public string ScreenName { get; set; }

    /// <summary>
    /// Gets or Sets StatusesCount
    /// </summary>
    [DataMember(Name="statuses_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses_count")]
    public decimal? StatusesCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TweetUser {\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  FollowersCount: ").Append(FollowersCount).Append("\n");
      sb.Append("  FriendsCount: ").Append(FriendsCount).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
      sb.Append("  ProfileImageUrlBigger: ").Append(ProfileImageUrlBigger).Append("\n");
      sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
      sb.Append("  StatusesCount: ").Append(StatusesCount).Append("\n");
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
