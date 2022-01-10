using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Shared
{
    public class BaseReadModel
    {
        [BsonId]
        public long Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}