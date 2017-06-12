namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    [DataContract]
    public partial class MedicalScholarlyArticle : ScholarlyArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalScholarlyArticle";
    }
}
