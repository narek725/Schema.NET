﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A moving company.
    /// </summary>
    public partial interface IMovingCompany : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A moving company.
    /// </summary>
    [DataContract]
    public partial class MovingCompany : HomeAndConstructionBusiness, IMovingCompany, IEquatable<MovingCompany>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovingCompany";

        /// <inheritdoc/>
        public bool Equals(MovingCompany other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MovingCompany);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
