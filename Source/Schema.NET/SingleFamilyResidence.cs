namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Residence type: Single-family home.
    /// </summary>
    [DataContract]
    public class SingleFamilyResidence : House
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SingleFamilyResidence";

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy")]
        public QuantitativeValue Occupancy { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms")]
        public override object NumberOfRooms { get; protected set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public override decimal? NumberOfRoomsNumber
        {
            get => this.NumberOfRooms as decimal?;
            set => this.NumberOfRooms = value;
        }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public override QuantitativeValue NumberOfRoomsQuantitativeValue
        {
            get => this.NumberOfRooms as QuantitativeValue;
            set => this.NumberOfRooms = value;
        }
    }
}
