namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An Insurance agency.
    /// </summary>
    [DataContract]
    public class InsuranceAgency : FinancialService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InsuranceAgency";
    }
}
