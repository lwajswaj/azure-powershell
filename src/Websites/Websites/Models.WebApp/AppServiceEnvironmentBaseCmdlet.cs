﻿// ----------------------------------------------------------------------------------
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
using Microsoft.Azure.Commands.WebApps.Models;
using Microsoft.Azure.Commands.WebApps.Models.WebApp;
using Microsoft.Azure.Commands.WebApps.Utilities;
using Microsoft.Azure.Management.WebSites.Models;
using System;
using System.Management.Automation;


namespace Microsoft.Azure.Commands.WebApps.Models.WebApp
{
  public abstract class AppServiceEnvironmentBaseCmdlet : WebAppBaseClientCmdLet
  {
    protected const string ParameterSet1Name = "S1";
    protected const string ParameterSet2Name = "S2";

    [Parameter(ParameterSetName = ParameterSet1Name, Position = 0, Mandatory = true, HelpMessage = "The name of the resource group.")]
    [ResourceGroupCompleter]
    [ValidateNotNullOrEmpty]
    public string ResourceGroupName { get; set; }

    [Parameter(ParameterSetName = ParameterSet1Name, Position = 1, Mandatory = true, HelpMessage = "The name of the app service environment.")]
    [ResourceNameCompleter("Microsoft.Web/hostingEnvironments", "ResourceGroupName")]
    [ValidateNotNullOrEmpty]
    public string Name { get; set; }

    [Parameter(ParameterSetName = ParameterSet2Name, Position = 0, Mandatory = true, HelpMessage = "The app service environment object", ValueFromPipeline = true)]
    [ValidateNotNullOrEmpty]
    public PSAppServiceEnvironment AppServiceEnvironment { get; set; }

    public override void ExecuteCmdlet()
    {
      if (string.Equals(ParameterSetName, ParameterSet2Name, StringComparison.OrdinalIgnoreCase))
      {
        string rg, name;
        var psAppServiceEnvironment = new PSAppServiceEnvironment(AppServiceEnvironment);

        CmdletHelpers.TryParseAppServiceEnvironmentMetadataFromResourceId(psAppServiceEnvironment.Id, out rg, out name);

        ResourceGroupName = rg;
        Name = name;
      }
    }
  }
}
