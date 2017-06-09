namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any anatomical structure which pertains to the soft nervous tissue functioning as the coordinating center of sensation and intellectual and nervous activity.
    /// </summary>
    [DataContract]
    public class BrainStructure : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BrainStructure";
    }
}
