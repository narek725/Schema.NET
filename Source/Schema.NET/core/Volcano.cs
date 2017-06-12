namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    [DataContract]
    public partial class Volcano : Landform
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Volcano";
    }
}
