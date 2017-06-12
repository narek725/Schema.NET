namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Catholic church.
    /// </summary>
    [DataContract]
    public partial class CatholicChurch : PlaceOfWorship
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CatholicChurch";
    }
}
