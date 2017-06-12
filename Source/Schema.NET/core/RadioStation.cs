namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A radio station.
    /// </summary>
    [DataContract]
    public partial class RadioStation : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioStation";
    }
}
