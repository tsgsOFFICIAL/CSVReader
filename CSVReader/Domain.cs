using System;
using System.Collections.Generic;

namespace CSVReader
{
    /// <summary>
    /// The Domain object holds all information about a given domain
    /// </summary>
    public class Domain
    {
        #region properties
        /// <summary>
        /// The domain name
        /// </summary>
        public string DomainName { get; private set; }
        /// <summary>
        /// A list of domain attributes
        /// </summary>
        public List<DomainAttribute> Attributes { get; private set; }
        #endregion
        /// <summary>
        /// Initialise a new Domain with a name and a new List of attributes
        /// </summary>
        /// <param name="domainName">Domain name</param>
        public Domain(string domainName)
        {
            DomainName = domainName;
            Attributes = new List<DomainAttribute>();
        }
        /// <summary>
        /// Add an attribute to the list of attributes
        /// </summary>
        /// <param name="attribute">The DomainAttribute object passed as an argument</param>
        public void AddAttribute(DomainAttribute attribute)
        {
            Attributes.Add(attribute);
        }
    }
}
