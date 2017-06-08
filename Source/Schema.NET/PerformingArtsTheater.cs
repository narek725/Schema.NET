namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    [DataContract]
    public class PerformingArtsTheater : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PerformingArtsTheater";
    }
}
