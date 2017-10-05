@ECHO OFF
ECHO Generating entities...

..\sdk\Bin\CrmSvcUtil.exe ^
/codewriterfilter:"CrmSvcUtilExtensions.BasicFilteringService, CrmSvcUtilExtensions" ^
/url:https://directionsemeatesting.crm4.dynamics.com/XRMServices/2011/Organization.svc ^
/namespace:TypedEntities /serviceContextName:XrmServiceContext ^
/username:jordi@directionsemeatesting.onmicrosoft.com /password:DirectionsEmea17 ^
/out:GeneratedCode.cs

ECHO Generating option sets...
..\sdk\Bin\CrmSvcUtil.exe ^
/codewriterfilter:"Microsoft.Crm.Sdk.Samples.FilteringService, GeneratePicklistEnums" ^
/codecustomization:"Microsoft.Crm.Sdk.Samples.CodeCustomizationService, GeneratePicklistEnums" ^
/namingservice:"Microsoft.Crm.Sdk.Samples.NamingService, GeneratePicklistEnums" ^
/url:https://directionsemeatesting.crm4.dynamics.com/XRMServices/2011/Organization.svc ^
/namespace:TypedEntities /serviceContextName:XrmServiceContext ^
/username:jordi@directionsemeatesting.onmicrosoft.com /password:DirectionsEmea17 ^
/out:OptionSets.cs

ECHO Done! :)
pause