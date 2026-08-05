using System.Reflection;

// SINTAXIS 1: valor desnudo en deps/dllcore.version (leido en runtime)
var fromFile = File.ReadAllText("deps/dllcore.version").Trim();

// SINTAXIS 3: propiedad <DllCoreVersion> del .csproj, compilada como metadata
var fromCsproj = Assembly.GetExecutingAssembly()
    .GetCustomAttributes<AssemblyMetadataAttribute>()
    .First(a => a.Key == "DllCoreVersion").Value;

Console.WriteLine($"Dealer 2 leyendo DLL v{fromFile}");
Console.WriteLine($"Dealer 2 csproj DllCoreVersion = {fromCsproj}");
if (fromFile != fromCsproj)
{
    Console.WriteLine("INCOHERENCIA: deps/dllcore.version y <DllCoreVersion> no coinciden");
    return 1;
}
return 0;
