#pragma warning disable 436

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("TestUtils", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("UnitTests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("com.unity.git.tests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("com.unity.git.ui.tests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("UnityTestsAPI", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("UnityTestsUI", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("IntegrationTests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("TaskSystemIntegrationTests", AllInternalsVisible = true)]
//Required for NSubstitute
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2", AllInternalsVisible = true)]

//Required for Unity compilation
[assembly: InternalsVisibleTo("Assembly-CSharp-Editor", AllInternalsVisible = true)]