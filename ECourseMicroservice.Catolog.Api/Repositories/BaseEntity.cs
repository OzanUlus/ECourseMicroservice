﻿using MongoDB.Bson.Serialization.Attributes;

namespace ECourseMicroservice.Catolog.Api.Repositories
{
    public class BaseEntity
    {
        [BsonElement("_id")]
        public Guid Id { get; set; }
    }
}
