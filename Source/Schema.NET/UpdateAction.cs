namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    [DataContract]
    public class UpdateAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "UpdateAction";

        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        [DataMember(Name = "targetCollection")]
        public Thing TargetCollection { get; set; }
    }
}
