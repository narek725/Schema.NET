namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    [DataContract]
    public partial class ChooseAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChooseAction";

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [DataMember(Name = "actionOption", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Thing>? ActionOption { get; set; }
    }
}
