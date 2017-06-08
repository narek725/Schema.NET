namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally...
    /// </summary>
    [DataContract]
    public class MedicalCondition : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalCondition";
    }
}
