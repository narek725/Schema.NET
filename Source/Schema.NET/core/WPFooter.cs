namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    [DataContract]
    public partial class WPFooter : WebPageElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPFooter";
    }
}
