namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    [DataContract]
    public class Vessel : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Vessel";
    }
}
