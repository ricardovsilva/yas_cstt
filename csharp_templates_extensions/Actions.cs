using System.Collections.Generic;
using System.Linq;

namespace csharp_templates_extensions
{
    public class Actions : List<string>
    {
        public string GetActions()
        {
            if (!this.Any()) return string.Empty;

            var actions = this.Select(_ => $"public ActionResult {_}()\n\t\t{{\n\t\t\tthrow new NotImplementedException();\n\t\t}}");
            return string.Join("\n\n\t\t", actions);
        }
    }
}
