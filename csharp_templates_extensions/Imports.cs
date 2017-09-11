using System.Collections.Generic;
using System.Linq;

namespace csharp_templates_extensions
{
    public class Imports : List<string>
    {
        public string GetImports()
        {
            if (!this.Any()) return string.Empty;

            var imports = this.Select(_ => $"using {_};");
            return string.Join("\n", imports);
        }
    }
}
