namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    [DataContract]
    public partial class ParcelDelivery : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// Destination address.
        /// </summary>
        [DataMember(Name = "deliveryAddress", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress>? DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [DataMember(Name = "deliveryStatus", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryEvent>? DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalFrom", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalUntil", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod?>? HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [DataMember(Name = "itemShipped", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product>? ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [DataMember(Name = "originAddress", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress>? OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [DataMember(Name = "partOfOrder", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Order>? PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [DataMember(Name = "trackingNumber", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        [DataMember(Name = "trackingUrl", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? TrackingUrl { get; set; }
    }
}
