#tool nuget:?package=NuGet.CommandLine&version=5.9.1
#addin nuget:?package=Cake.Git&version=2.0.0
#addin nuget:?package=Cake.CodeGen.OpenAPI&version=1.0.2
using Cake.CodeGen.OpenApi;
using Cake.Common.Tools.NuGet.NuGetAliases;
using System.Text.RegularExpressions;


var target = Argument("target", "Bundle");
var configuration = Argument("configuration", "Release");
var generator = Argument("generator", "aspnetcore");
var output_dir = Argument("output_dir", $"./build/{generator}");
var packageName = Argument("package_name", "Lyft.Mock");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory($"{output_dir}");
});

Task("GenerateOpenAPI")
    .IsDependentOn("Clean")
    .Does(() =>
{
    OpenApiGenerator.Generate("openapi.yaml", generator, $"{output_dir}", new OpenApiGenerateSettings()
    {
        ConfigurationFile = "./openapi-codegen.json",
        PackageName = packageName,
    });
});

Task("Build")
    .IsDependentOn("GenerateOpenAPI")
    .Does(() =>
{
    DotNetBuild($"{output_dir}/{packageName}.sln", new DotNetBuildSettings
    {
        Configuration = configuration,
        Framework = "net6.0",
        OutputDirectory = $"./build/{generator}/src/{packageName}/bin/{configuration}/lib/net6.0",
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    // DotNetTest($"{output_dir}/{packageName}", new DotNetTestSettings
    // {
    //     Configuration = configuration,
    //     NoBuild = true,
    // });
});

Task("Publish")
    .IsDependentOn("Build")
    .Does(()=>
{
    DotNetPublish("LyftAPI.csproj", new DotNetPublishSettings {
        Framework = "net6.0",
        Configuration = "Release",
        OutputDirectory = "./publish/",
        SelfContained = true,
        PublishTrimmed = true,
        Runtime = Runtime
    });
});


//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
