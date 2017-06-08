namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system...
    /// </summary>
    [DataContract]
    public class AnatomicalStructure : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AnatomicalStructure";
    }
}
