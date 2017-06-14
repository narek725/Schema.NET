namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class PeopleAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PeopleAudience";

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [DataMember(Name = "requiredGender", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [DataMember(Name = "requiredMaxAge", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [DataMember(Name = "requiredMinAge", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [DataMember(Name = "suggestedGender", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMaxAge", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMinAge", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? SuggestedMinAge { get; set; }
    }
}
