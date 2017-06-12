namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    [DataContract]
    public partial class NGO : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NGO";
    }
}
