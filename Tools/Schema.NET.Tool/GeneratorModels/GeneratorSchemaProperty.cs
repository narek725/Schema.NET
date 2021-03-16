namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1716 // Identifiers should not match keywords
    public class GeneratorSchemaProperty : ICloneable<GeneratorSchemaProperty, GeneratorSchemaClass>
#pragma warning restore CA1716 // Identifiers should not match keywords
    {
        public GeneratorSchemaProperty(GeneratorSchemaClass schemaClass, string name, string jsonName)
        {
            this.Class = schemaClass;
            this.Name = name;
            this.JsonName = jsonName;
        }

        public GeneratorSchemaClass Class { get; }

        public string? Description { get; set; }

        public string JsonName { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<GeneratorSchemaPropertyType> Types { get; } = new List<GeneratorSchemaPropertyType>();

        public string PropertyTypeString
        {
            get
            {
                var propertyTypes = this.Types.SelectMany(x => x.CSharpTypeStrings).ToArray();
                var propertyTypesString = string.Join(", ", propertyTypes);
                if (propertyTypes.Length == 1)
                {
                    return $"OneOrMany<{propertyTypesString}>";
                }
                else
                {
                    return $"Values<{propertyTypesString}>";
                }
            }
        }

        public string JsonConverterType
        {
            get
            {
                var jsonConverterType = "ValuesJsonConverter";
                if (this.Types.Any(x => string.Equals(x.Name, "Duration", StringComparison.OrdinalIgnoreCase)))
                {
                    jsonConverterType = "TimeSpanToISO8601DurationValuesJsonConverter";
                }
                else if (this.Types.Any(x => string.Equals(x.Name, "Date", StringComparison.OrdinalIgnoreCase)))
                {
                    jsonConverterType = "DateTimeToIso8601DateValuesJsonConverter";
                }

                return jsonConverterType;
            }
        }

        public GeneratorSchemaProperty Clone(GeneratorSchemaClass context)
        {
            var property = new GeneratorSchemaProperty(context, this.Name, this.JsonName)
            {
                Description = this.Description,
                Order = this.Order,
            };
            property.Types.AddRange(this.Types.Select(x => x.Clone()));
            return property;
        }
    }
}
