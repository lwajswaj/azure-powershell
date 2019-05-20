// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.WebApps.Models.WebApp;
using Microsoft.Azure.Commands.WebApps.Utilities;
using Microsoft.Azure.Management.WebSites.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.WebApps.Cmdlets.AppServiceEnvironments
{
  [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AppServiceEnvironment"), OutputType(typeof(PSAppServiceEnvironment))]
  public class NewAzureAppServiceEnvironmentCmdlet : AppServiceEnvironmentBaseCmdlet
  {
    [Parameter(Position = 2, Mandatory = true, HelpMessage = "The location of the app service environment.")]
    [LocationCompleter("Microsoft.Web/hostingEnvironments")]
    [ValidateNotNullOrEmpty]
    public string Location { get; set; }

    [Parameter(Position = 3, Mandatory = true, HelpMessage = "The full resource ID of a subnet in a virtual network to deploy the App Service Environment in. Example format: /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.Network/VirtualNetworks/vnet1/subnets/subnet1")]
    [ValidateNotNullOrEmpty]
    public string SubnetId { get; set; }

    [Parameter(Mandatory = false, HelpMessage = "DNS suffix of the App Service Environment")]
    public string DnsSuffix { get; set; }

    [Parameter(Mandatory = false, HelpMessage = "It specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. Allowed values are [None|Web|Publishing]")]
    [PSArgumentCompleter("None", "Web", "Publishing")]
    public string InternalLoadBalancingMode { get; set; } = "None";

    [Parameter(Mandatory = false, HelpMessage = "Number of instances in the worker pool.")]
    public int Workers { get; set; }

    [Parameter(Mandatory = false, HelpMessage = "Custom settings for changing the behavior of the App Service Environment")]
    public Hashtable ClusterSettings { get; set; }

    [Parameter(Mandatory = false, HelpMessage = "Resource tags")]
    public Dictionary<string,string> Tags { get; set; }

    [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
    public SwitchParameter AsJob { get; set; }

    public override void ExecuteCmdlet()
    {
      AppServiceEnvironmentResource appServiceEnvironment = new AppServiceEnvironmentResource
      {
        AppServiceEnvironmentResourceName = Name,
        Location = Location,
        Kind = "ASEV2",
        AppServiceEnvironmentResourceLocation = Location,
        InternalLoadBalancingMode = (Management.WebSites.Models.InternalLoadBalancingMode)Enum.Parse(typeof(Management.WebSites.Models.InternalLoadBalancingMode), InternalLoadBalancingMode),
        VirtualNetwork = new VirtualNetworkProfile(id: CmdletHelpers.GetParentResourceId("Microsoft.Network", SubnetId),
                                                   subnet: CmdletHelpers.GetResourceFromResourceId(SubnetId)),
        VnetName = CmdletHelpers.GetResourceFromResourceId(CmdletHelpers.GetParentResourceId("Microsoft.Network", SubnetId)),
        VnetResourceGroupName = CmdletHelpers.GetResourceGroupFromResourceId(SubnetId),
        VnetSubnetName = CmdletHelpers.GetResourceFromResourceId(SubnetId)
      };

      appServiceEnvironment.WorkerPools = new List<WorkerPool>();

      if (!string.IsNullOrEmpty(DnsSuffix))
      {
        appServiceEnvironment.DnsSuffix = DnsSuffix;
      }

      if (ClusterSettings != null)
      {
        appServiceEnvironment.ClusterSettings = ClusterSettings.ConvertToNameValuePairList();
      }

      if (Tags != null)
      {
        appServiceEnvironment.Tags = Tags;
      }

      AppServiceEnvironmentResource retAse = WebsitesClient.CreateOrUpdateAppServiceEnvironment(ResourceGroupName, Name, appServiceEnvironment);
      PSAppServiceEnvironment psAse = new PSAppServiceEnvironment(retAse);

      WriteObject(psAse, true);
    }
  }
}
