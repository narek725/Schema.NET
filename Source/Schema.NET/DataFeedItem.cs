namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    [DataContract]
    public class DataFeedItem : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DataFeedItem";

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified")]
        public DateTimeOffset DateModified { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        [DataMember(Name = "dateDeleted")]
        public DateTimeOffset DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item")]
        public Thing Item { get; set; }
    }
}
