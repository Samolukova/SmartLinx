// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using global::System.Runtime.CompilerServices;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::Redirector_Tests_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.9.74")]
public class Redirector_Tests_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Redirector_Tests_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(Redirector_Tests_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}

[global::Xunit.CollectionDefinition("SpecFlowNonParallelizableFeatures", DisableParallelization = true)]
public class Redirector_Tests_SpecFlowNonParallelizableFeaturesCollectionDefinition
{
}
#pragma warning restore
