// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using Microsoft.Azure.Management.Dns.Fluent.Models;
    using System.Collections.Generic;

    internal partial class NSRecordSetImpl 
    {
        /// <summary>
        /// Gets the metadata associated with this record set.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,string> Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet.Metadata
        {
            get
            {
                return this.Metadata() as System.Collections.Generic.IReadOnlyDictionary<string,string>;
            }
        }

        /// <summary>
        /// Gets TTL of the records in this record set.
        /// </summary>
        long Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet.TimeToLive
        {
            get
            {
                return this.TimeToLive();
            }
        }

        /// <summary>
        /// Gets the type of records in this record set.
        /// </summary>
        Models.RecordType Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet.RecordType
        {
            get
            {
                return this.RecordType();
            }
        }

        /// <summary>
        /// Gets the name server names of NS (name server) records in this record set.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> Microsoft.Azure.Management.Dns.Fluent.INSRecordSet.NameServers
        {
            get
            {
                return this.NameServers() as System.Collections.Generic.IReadOnlyList<string>;
            }
        }
    }
}