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
  public class Vacancy {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets SalaryTo
    /// </summary>
    [DataMember(Name="salary_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salary_to")]
    public string SalaryTo { get; set; }

    /// <summary>
    /// Gets or Sets SalaryFrom
    /// </summary>
    [DataMember(Name="salary_from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salary_from")]
    public string SalaryFrom { get; set; }

    /// <summary>
    /// Gets or Sets SalaryText
    /// </summary>
    [DataMember(Name="salary_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salary_text")]
    public string SalaryText { get; set; }

    /// <summary>
    /// Gets or Sets Area
    /// </summary>
    [DataMember(Name="area", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "area")]
    public decimal? Area { get; set; }

    /// <summary>
    /// Gets or Sets AreaText
    /// </summary>
    [DataMember(Name="area_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "area_text")]
    public string AreaText { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public int? Schedule { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleText
    /// </summary>
    [DataMember(Name="schedule_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule_text")]
    public string ScheduleText { get; set; }

    /// <summary>
    /// Gets or Sets EntryId
    /// </summary>
    [DataMember(Name="entry_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entry_id")]
    public decimal? EntryId { get; set; }

    /// <summary>
    /// Gets or Sets CityId
    /// </summary>
    [DataMember(Name="city_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city_id")]
    public decimal? CityId { get; set; }

    /// <summary>
    /// Gets or Sets CityName
    /// </summary>
    [DataMember(Name="city_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city_name")]
    public string CityName { get; set; }

    /// <summary>
    /// Gets or Sets FavoritesCount
    /// </summary>
    [DataMember(Name="favoritesCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "favoritesCount")]
    public decimal? FavoritesCount { get; set; }

    /// <summary>
    /// Gets or Sets IsFavorited
    /// </summary>
    [DataMember(Name="isFavorited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFavorited")]
    public bool? IsFavorited { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public Company Company { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Vacancy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  SalaryTo: ").Append(SalaryTo).Append("\n");
      sb.Append("  SalaryFrom: ").Append(SalaryFrom).Append("\n");
      sb.Append("  SalaryText: ").Append(SalaryText).Append("\n");
      sb.Append("  Area: ").Append(Area).Append("\n");
      sb.Append("  AreaText: ").Append(AreaText).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  ScheduleText: ").Append(ScheduleText).Append("\n");
      sb.Append("  EntryId: ").Append(EntryId).Append("\n");
      sb.Append("  CityId: ").Append(CityId).Append("\n");
      sb.Append("  CityName: ").Append(CityName).Append("\n");
      sb.Append("  FavoritesCount: ").Append(FavoritesCount).Append("\n");
      sb.Append("  IsFavorited: ").Append(IsFavorited).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
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
