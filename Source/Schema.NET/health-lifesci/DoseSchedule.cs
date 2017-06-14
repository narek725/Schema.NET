namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    [DataContract]
    public partial class DoseSchedule : MedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DoseSchedule";
    }
}
