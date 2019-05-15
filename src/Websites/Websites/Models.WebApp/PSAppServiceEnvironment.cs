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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Commands.WebApps.Models.WebApp
{
  public class PSAppServiceEnvironment : AppServiceEnvironmentResource
  {
    public PSAppServiceEnvironment(AppServiceEnvironmentResource other) : base(
      allowedMultiSizes: other.AllowedMultiSizes,
      allowedWorkerSizes: other.AllowedWorkerSizes,
      apiManagementAccountId: other.ApiManagementAccountId,
      appServiceEnvironmentResourceLocation: other.Location,
      appServiceEnvironmentResourceName: other.Name,
      clusterSettings: other.ClusterSettings,
      databaseEdition: other.DatabaseEdition,
      databaseServiceObjective: other.DatabaseServiceObjective,
      defaultFrontEndScaleFactor: other.DefaultFrontEndScaleFactor,
      dnsSuffix: other.DnsSuffix,
      dynamicCacheEnabled: other.DynamicCacheEnabled,
      environmentCapacities: other.EnvironmentCapacities,
      environmentIsHealthy: other.EnvironmentIsHealthy,
      environmentStatus: other.EnvironmentStatus,
      frontEndScaleFactor: other.FrontEndScaleFactor,
      hasLinuxWorkers: other.HasLinuxWorkers,
      internalLoadBalancingMode: other.InternalLoadBalancingMode,
      ipsslAddressCount: other.IpsslAddressCount,
      lastAction: other.LastAction,
      lastActionResult: other.LastActionResult,
      location: other.Location,
      maximumNumberOfMachines: other.MaximumNumberOfMachines,
      multiRoleCount: other.MultiRoleCount,
      multiSize: other.MultiSize,
      name: other.Name,
      networkAccessControlList: other.NetworkAccessControlList,
      provisioningState: other.ProvisioningState,
      resourceGroup: other.ResourceGroup,
      sslCertKeyVaultId: other.SslCertKeyVaultId,
      sslCertKeyVaultSecretName: other.SslCertKeyVaultSecretName,
      status: other.Status,
      subscriptionId: other.SubscriptionId,
      suspended: other.Suspended,
      upgradeDomains: other.UpgradeDomains,
      userWhitelistedIpRanges: other.UserWhitelistedIpRanges,
      vipMappings: other.VipMappings,
      virtualNetwork: other.VirtualNetwork,
      vnetName: other.VnetName,
      vnetResourceGroupName: other.VnetResourceGroupName,
      vnetSubnetName: other.VnetSubnetName,
      workerPools: other.WorkerPools
      )
    { }
  }
}
