﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Scim.Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleIdServer.Scim.Persistence
{
    public interface ISCIMSchemaQueryRepository
    {
        Task<SCIMSchema> FindSCIMSchemaById(string schemaId);
        Task<SCIMSchema> FindRootSCIMSchemaByName(string name);
        Task<SCIMSchema> FindRootSCIMSchemaByResourceType(string resourceType);
        Task<IEnumerable<SCIMSchema>> FindSCIMSchemaByIdentifiers(IEnumerable<string> schemaIdentifiers);
        Task<IEnumerable<SCIMSchema>> FindSCIMSchemaByResourceTypes(IEnumerable<string> schemaIdentifiers);
        Task<IEnumerable<SCIMSchema>> GetAll();
        Task<IEnumerable<SCIMSchema>> GetAllRoot();
    }
}
