namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
    [DataContract]
    public class MobileApplication : SoftwareApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MobileApplication";

        /// <summary>
        /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
        /// </summary>
        [DataMember(Name = "carrierRequirements", Order = 2)]
        public string CarrierRequirements { get; set; }
    }
}
