﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using Telerik Data Access template.
// Code is generated on: 3/3/2019 8:16:36 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace VRGameSelectorServerDB
{
    public partial class VRArcadeDataAccessModelMetadataSource : FluentMetadataSource
    {
        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.Name = "VRArcadeDataAccessModel";
            container.DefaultNamespace = "VRGameSelectorServerDB";
            container.DefaultMapping.NullForeignKey = true;
            OnSetContainerSettings(container);
        }
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> mappingConfigurations = new List<MappingConfiguration>();
            mappingConfigurations.Add(this.GetVRClienthistoryMappingConfiguration());
            mappingConfigurations.Add(this.GetVRClientMappingConfiguration());
            mappingConfigurations.Add(this.GetVRConfigurationMappingConfiguration());
            mappingConfigurations.Add(this.GetVRTileconfigMappingConfiguration());
            mappingConfigurations.Add(this.GetVRTileconfigsetMappingConfiguration());
            mappingConfigurations.Add(this.GetVRTicketMappingConfiguration());
            mappingConfigurations.Add(this.GetVRTicketTypeMappingConfiguration());
            mappingConfigurations.Add(this.GetVRManageLogMappingConfiguration());
            mappingConfigurations.Add(this.GetVRWaiverLogMappingConfiguration());
            mappingConfigurations.Add(this.GetVRBookingReferenceMappingConfiguration());
         
            OnPrepareMapping(mappingConfigurations);
            return mappingConfigurations;
        }
        
        #region Extensibility Method Definitions
        partial void OnSetContainerSettings(MetadataContainer container);
        partial void OnPrepareMapping(List<MappingConfiguration> mappingConfigurations);
        
        #endregion
    }

}