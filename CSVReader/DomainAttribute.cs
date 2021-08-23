using System;

namespace CSVReader
{
    /// <summary>
    /// Domain Attribute for the Domain class
    /// </summary>
    public class DomainAttribute
    {
        /// <summary>
        /// The ID
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// The Name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The type of DNS record
        /// </summary>
        public string Type { get; private set; }
        /// <summary>
        /// The time to live (TTL)
        /// </summary>
        public int Ttl { get; private set; }
        /// <summary>
        /// The priority
        /// </summary>
        public int Priority { get; private set; }
        /// <summary>
        /// The Data
        /// </summary>
        public string Data { get; private set; }

        public DomainAttribute(long id, string name, string type, int ttl, int priority, string data)
        {
            Id = id;
            Name = name;
            Type = type;
            Ttl = ttl;
            Priority = priority;
            Data = data;
        }
    }
}
