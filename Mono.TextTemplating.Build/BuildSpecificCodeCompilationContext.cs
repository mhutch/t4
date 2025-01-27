using Mono.TextTemplating.CodeCompilation;

namespace Mono.TextTemplating.Build
{
    public sealed class BuildSpecificCodeCompilationContext : ICodeCompilationContext
    {
        
        readonly string _compilerSearchPath;
        readonly string _netCoreRoot;
        public BuildSpecificCodeCompilationContext (string compilerSearchPath, string NetCoreRoot)
        {
            _compilerSearchPath = compilerSearchPath;
            _netCoreRoot = NetCoreRoot;
        }

        public string CompilerSearchPath => _compilerSearchPath;

        public string NetCoreRoot => _netCoreRoot;
    }
}