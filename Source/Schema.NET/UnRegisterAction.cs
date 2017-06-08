namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of un-registering from a service.
    /// Related actions:
    ///
    /// RegisterAction: antonym of UnRegisterAction...
    /// </summary>
    [DataContract]
    public class UnRegisterAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "UnRegisterAction";
    }
}
