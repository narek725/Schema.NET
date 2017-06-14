namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    [DataContract]
    public partial class TrainTrip : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainTrip";

        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        [DataMember(Name = "arrivalPlatform", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArrivalPlatform { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [DataMember(Name = "arrivalStation", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<TrainStation>? ArrivalStation { get; set; }

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ArrivalTime { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [DataMember(Name = "departurePlatform", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DeparturePlatform { get; set; }

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [DataMember(Name = "departureStation", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<TrainStation>? DepartureStation { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DepartureTime { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [DataMember(Name = "trainName", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [DataMember(Name = "trainNumber", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TrainNumber { get; set; }
    }
}
