﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions on insert operations
    /// </summary>
    public class InsertRestrictionsType
    {
        /// <summary>
        /// Initialize new <see cref="InsertRestrictionsType"/>
        /// </summary>
        public InsertRestrictionsType()
        {
            Permissions = new List<PermissionType>();
        }

        /// <summary>
        /// Entities can be inserted.
        /// </summary>
        public bool? Insertable { get; set; }

        /// <summary>
        /// Required permissions. One of the specified sets of scopes is required to perform the insert.
        /// </summary>
        public List<PermissionType> Permissions { get; }

        /// <summary>
        /// A brief description of the request.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A lengthy description of the request.
        /// </summary>
        public string LongDescription { get; set; }
    }
}
