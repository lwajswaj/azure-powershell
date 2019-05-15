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

using Microsoft.Azure.Commands.WebApps.Models;
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.WebApps.Models.WebApp;

namespace Microsoft.Azure.Commands.WebApps.Cmdlets.AppServiceEnvironments
{
  /// <summary>
  /// this cmdlet will let you Get an Azure App Service Environment using ARM APIs
  /// </summary>
  [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AppServiceEnvironment"), OutputType(typeof(PSAppServiceEnvironment))]
  class GetAppServiceEnvironmentCmdlet : WebAppBaseClientCmdLet
  {
    private const string ParameterSet1 = "S1";
    private const string ParameterSet2 = "S2";

    [Parameter(ParameterSetName = ParameterSet1, Position = 0, Mandatory = false, HelpMessage = "The name of the resource group.")]
    [ResourceGroupCompleter]
    [ValidateNotNullOrEmpty]
    public string ResourceGroupName { get; set; }

    [Parameter(ParameterSetName = ParameterSet1, Position = 1, Mandatory = false, HelpMessage = "The name of the app service environment.")]
    [ResourceNameCompleter("Microsoft.Web/hostingEnvironments", "ResourceGroupName")]
    [ValidateNotNullOrEmpty]
    public string Name { get; set; }


    [Parameter(ParameterSetName = ParameterSet2, Position = 0, Mandatory = true, HelpMessage = "The location of the app service environment.")]
    [LocationCompleter("Microsoft.Web/hostingEnvironments")]
    [ValidateNotNullOrEmpty]
    public string Location { get; set; }

    public override void ExecuteCmdlet()
    {
      switch (ParameterSetName)
      {
        case ParameterSet1:
          if (!string.IsNullOrEmpty(ResourceGroupName) && !string.IsNullOrEmpty(Name))
          {
            GetAppServiceEnvironment();
          }
          else if (!string.IsNullOrEmpty(ResourceGroupName))
          {
            GetByResourceGroup();
          }
          else if (!string.IsNullOrEmpty(Name))
          {
            GetByAppServiceEnvironmentName();
          }
          else
          {
            GetBySubscription();
          }
          break;
        case ParameterSet2:
          GetByLocation();
          break;
      }
    }
    
    private void GetAppServiceEnvironment() {
      WriteObject(WebsitesClient.GetAppServiceEnvironment(ResourceGroupName, Name), true);
    }

    private void GetByAppServiceEnvironmentName()
    {
      const string progressDescriptionFormat = "Progress: {0}/{1} app service environments processed.";
      var progressRecord = new ProgressRecord(1, string.Format("Get app service environments with name '{0}'", Name), "Progress:");

      WriteProgress(progressRecord);

      var appServiceEnvironmentResources = ResourcesClient.ResourceManagementClient.FilterResources(new FilterResourcesOptions
      {
        ResourceType = "Microsoft.Web/hostingEnvironments"
      }).Where(ase => string.Equals(ase.Name, Name, StringComparison.OrdinalIgnoreCase)).ToArray();

      var list = new List<PSAppServiceEnvironment>();
      for (var i = 0; i < appServiceEnvironmentResources.Length; i++)
      {
        var ase = appServiceEnvironmentResources[i];
        try
        {
          var result = WebsitesClient.GetAppServiceEnvironment(ase.ResourceGroupName, ase.Name);
          if (result != null)
          {
            list.Add(new PSAppServiceEnvironment(result));
          }
        }
        catch (Exception e)
        {
          WriteExceptionError(e);
        }

        progressRecord.StatusDescription = string.Format(progressDescriptionFormat, i + 1, appServiceEnvironmentResources.Length);
        progressRecord.PercentComplete = (100 * (i + 1)) / appServiceEnvironmentResources.Length;
        WriteProgress(progressRecord);
      }

      WriteObject(list, true);
    }

    private void GetByResourceGroup()
    {
      WriteObject(WebsitesClient.ListAppServiceEnvironments(ResourceGroupName), true);
    }

    private void GetBySubscription()
    {
      const string progressDescriptionFormat = "Progress: {0}/{1} resource groups processed.";
      const string progressCurrentOperationFormat = "Getting app service environments for resource group '{0}'";
      var progressRecord = new ProgressRecord(1, "Get app service environments from all resource groups", "Progress:")
      {
        CurrentOperation = "Getting all subscription resource groups ..."
      };

      WriteProgress(progressRecord);

      var resourceGroups = ResourcesClient.ResourceManagementClient.FilterResources(new FilterResourcesOptions
      {
        ResourceType = "Microsoft.Web/hostingEnvironments"
      }).Select(ase => ase.ResourceGroupName).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();

      var list = new List<PSAppServiceEnvironment>();

      for (var i = 0; i < resourceGroups.Length; i++)
      {
        var rg = resourceGroups[i];
        try
        {
          var result = WebsitesClient.ListAppServiceEnvironments(rg);
          if (result != null)
          {
            foreach (var item in result)
            {
              list.Add(new PSAppServiceEnvironment(item));
            }
          }
        }
        catch (Exception e)
        {
          WriteExceptionError(e);
        }

        progressRecord.CurrentOperation = string.Format(progressCurrentOperationFormat, rg);
        progressRecord.StatusDescription = string.Format(progressDescriptionFormat, i + 1, resourceGroups.Length);
        progressRecord.PercentComplete = (100 * (i + 1)) / resourceGroups.Length;
        WriteProgress(progressRecord);
      }

      WriteObject(list, true);
    }

    private void GetByLocation()
    {
      const string progressDescriptionFormat = "Progress: {0}/{1} app service environments processed.";
      var progressRecord = new ProgressRecord(1, string.Format("Get app service environments at location '{0}'", Location), "Progress:");

      WriteProgress(progressRecord);

      var appServiceEnvironmentResources = ResourcesClient.ResourceManagementClient.FilterResources(new FilterResourcesOptions
      {
        ResourceType = "Microsoft.Web/hostingEnvironments"
      }).Where(sf => string.Equals(sf.Location, Location.Replace(" ", string.Empty), StringComparison.OrdinalIgnoreCase)).ToArray();

      var list = new List<AppServiceEnvironmentResource>();
      for (var i = 0; i < appServiceEnvironmentResources.Length; i++)
      {
        var ase = appServiceEnvironmentResources[i];
        try
        {
          var result = WebsitesClient.GetAppServiceEnvironment(ase.ResourceGroupName, ase.Name);
          if (result != null)
          {
            list.Add(result);
          }
        }
        catch (Exception e)
        {
          WriteExceptionError(e);
        }

        progressRecord.StatusDescription = string.Format(progressDescriptionFormat, i + 1, appServiceEnvironmentResources.Length);
        progressRecord.PercentComplete = (100 * (i + 1)) / appServiceEnvironmentResources.Length;
        WriteProgress(progressRecord);
      }

      WriteObject(list, true);
    }
  }
}
