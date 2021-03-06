﻿using Newtonsoft.Json;
using System;

namespace Piksel.SMHISharp
{
    public class IntDateConverter : JsonConverter
    {
        private static DateTimeOffset Epoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTimeOffset);
        }

        public override bool CanRead => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            DateTimeOffset dto;
            if (reader.Value is DateTime)
            {
                dto = new DateTimeOffset((DateTime)reader.Value);
            }
            else
            {
                var timestamp = (long)reader.Value;
                dto = Epoch.AddMilliseconds(timestamp);
            }

            if (objectType == typeof(DateTimeOffset))
                return dto;

            if (objectType == typeof(DateTime))
                return dto.DateTime;

            return null;
        }

        public override bool CanWrite => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DateTimeOffset dto;
            if (value is DateTime)
            {
                dto = new DateTimeOffset(((DateTime)value));
            }
            else if (value is DateTimeOffset)
            {
                dto = (DateTimeOffset)value;
            }
            else
            {
                throw new JsonException("Cannot serialize type " + value.GetType().Name);
            }
            writer.WriteValue((dto - Epoch).TotalMilliseconds);
        }
    }
}