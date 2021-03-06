#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 6/27/2019
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '2.4.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with WindowsPowerShell and PowerShell Core.

For more information about the Az module, please visit the following: https://docs.microsoft.com/en-us/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '1.6.0'; },
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.Aks'; RequiredVersion = '1.0.1'; },
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '1.2.0'; },
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.3.0'; },
               @{ModuleName = 'Az.Batch'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.Billing'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.3.0'; },
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.1.1'; },
               @{ModuleName = 'Az.Compute'; RequiredVersion = '2.4.0'; },
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '1.0.1'; },
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '1.0.1'; },
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.1.2'; },
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.2.1'; },
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.1'; },
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.2.1'; },
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.2.0'; },
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '2.0.0'; },
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '1.2.0'; },
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '1.2.0'; },
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.2.1'; },
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '1.2.1'; },
               @{ModuleName = 'Az.Network'; RequiredVersion = '1.11.0'; },
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '1.3.1'; },
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.1.2'; },
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '1.4.2'; },
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.1.0'; },
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.1'; },
               @{ModuleName = 'Az.Resources'; RequiredVersion = '1.6.0'; },
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.2.1'; },
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '1.1.1'; },
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.0.2'; },
               @{ModuleName = 'Az.Sql'; RequiredVersion = '1.13.0'; },
               @{ModuleName = 'Az.Storage'; RequiredVersion = '1.5.0'; },
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.1.1'; },
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '1.0.0'; },
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.0.1'; },
               @{ModuleName = 'Az.Websites'; RequiredVersion = '1.3.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '2.4.0 - July 2019
Az.Accounts
* Add support for profile cmdlets
* Add support for environments and data planes in generated cmdlets
* Fix bug where incorrect endpoint was being used in some cases for data plane cmdlets in Windows PowerShell

Az.Advisor
* GA release of Az.Advisor
* This module is now included as a part of the roll-up `Az` module

Az.ApiManagement
* Fix for issue https://github.com/Azure/azure-powershell/issues/8671
    - **Get-AzApiManagementSubscription**
        - Added support for querying subscriptions by User and Product
        - Added support for querying using Scope ''/'', ''/apis'', ''/apis/echo-api''
* Fix for issue https://github.com/Azure/azure-powershell/issues/9307 and https://github.com/Azure/azure-powershell/issues/8432
    - **Import-AzApiManagementApi**
        - Added support for specifiying ''ApiVersion'' and ''ApiVersionSetId'' when importing Apis

Az.Automation
* Fixed Set-AzAutomationConnectionFieldValue cmdlet bug to handle string value.

Az.Compute
* Add HyperVGeneration parameter to New-AzImageConfig

Az.DataFactory
* Updating the output of get activity runs, get pipeline runs, and get trigger runs ADF cmdlets to support Select-Object pipe.

Az.EventGrid
* Fix typo in ''New-AzEventGridSubscription'' documentation

Az.IotHub
* Add support to regenerate authorization policy keys.

Az.Network
* Added ''RoutingPreference'' to public ip tags
* Improve examples for ''Get-AzNetworkServiceTag'' reference documentation

Az.PolicyInsights
* Fix null reference issue in Get-AzPolicyState
    - More information here: https://github.com/Azure/azure-powershell/issues/9446

Az.OperationalInsights
* Fixed CustomLog datasource model returned in Get-AzOperationalInsightsDataSource

Az.RecoveryServices
* Fix for get-policy command for IaaSVMs

Az.Resources
    - Fix help text for Get-AzPolicyState -Top parameter
    - Add client-side paging support for Get-AzPolicyAlias
    - Add new parameters for Set-AzPolicyAssignment, -PolicyParameters and -PolicyParametersObject
    - Handful of doc and example updates for Policy cmdlets

Az.ServiceBus
* Fix for issue #4938 - New-AzureRmServiceBusQueue returns BadRequest when setting MaxSizeInMegabytes

Az.Sql
* Add Instance Failover Group cmdlets from preview release to public release
* Support Azure SQL Server\Database Auditing with new cmdlets.
    - Set-AzSqlServerAudit
    - Get-AzSqlServerAudit
    - Remove-AzSqlServerAudit
    - Set-AzSqlDatabaseAudit
    - Get-AzSqlDatabaseAudit
    - Remove-AzSqlDatabaseAudit
* Remove email constraints from Vulnerability Assessment settings

Az.Storage
* Change 2 parameters ''-IndexDocument'' and ''-ErrorDocument404Path'' from required to optional  in cmdlet:
    -  Enable-AzStorageStaticWebsite
* Update help of Get-AzStorageBlobContent by add an example
* Show more error information when cmdlet failed with StorageException
* Support create or update Storage account with Azure Files AAD DS Authentication
    -  New-AzStorageAccount
    -  Set-AzStorageAccount
* Support list or close file handles of a file share, file directory or a file
    - Get-AzStorageFileHandle
    - Close-AzStorageFileHandle

Az.StorageSync
* This module is now included as a part of the roll-up `Az` module
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

