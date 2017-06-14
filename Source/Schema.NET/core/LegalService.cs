namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e...
    /// </summary>
    [DataContract]
    public partial class LegalService : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LegalService";
    }
}
