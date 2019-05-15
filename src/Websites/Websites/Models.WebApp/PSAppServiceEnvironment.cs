using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Commands.WebApps.Models.WebApp
{
  public class PSAppServiceEnvironment : AppServiceEnvironment
  {
    public PSAppServiceEnvironment(AppServiceEnvironment other) : base(
      allowedMultiSizes: other.AllowedMultiSizes,
      allowedWorkerSizes: other.AllowedWorkerSizes,
      apiManagementAccountId: other.ApiManagementAccountId,
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
