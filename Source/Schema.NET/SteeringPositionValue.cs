namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating a steering position.
    /// </summary>
    [DataContract]
    public class SteeringPositionValue : QualitativeValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SteeringPositionValue";
    }
}
