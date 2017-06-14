namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food-related business.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishment : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishment";

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "acceptsReservations", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri, bool?>? AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [DataMember(Name = "hasMenu", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Menu, string, Uri>? HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [DataMember(Name = "servesCuisine", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Rating>? StarRating { get; set; }
    }
}
