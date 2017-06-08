namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    [DataContract]
    public class PrependAction : InsertAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PrependAction";
    }
}
