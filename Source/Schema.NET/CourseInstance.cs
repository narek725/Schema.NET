namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An instance of a Course which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    [DataContract]
    public class CourseInstance : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CourseInstance";

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "instructor")]
        public Person Instructor { get; set; }

        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [DataMember(Name = "courseMode")]
        public object CourseMode { get; protected set; }

        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [IgnoreDataMember]
        public Uri CourseModeURL
        {
            get => this.CourseMode as Uri;
            set => this.CourseMode = value;
        }

        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [IgnoreDataMember]
        public string CourseModeText
        {
            get => this.CourseMode as string;
            set => this.CourseMode = value;
        }
    }
}
