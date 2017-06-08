namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A gym.
    /// </summary>
    [DataContract]
    public class ExerciseGym : SportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ExerciseGym";
    }
}
