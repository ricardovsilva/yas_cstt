using System;
using System.Linq;
using System.Collections.Generic;

namespace csharp_templates_extensions
{
    public class Dependencies : List<string>
    {
        public string GetConstructorParameters()
        {
            if (!this.Any()) return string.Empty;

            var parameters = this.Select(_ => $"{_} {ToVariableName(_)}");
            return string.Join(", ", parameters);
        }

        public string GetPrivateFieldsAssignement()
        {
            if (!this.Any()) return string.Empty;

            var fields = this.Select(_ => $"this.{ToVariableName(_)} = {ToVariableName(_)}");
            return string.Join(";\n\t\t\t", fields) + ";";
        }

        public string GetPrivateFields()
        {
            if (!this.Any()) return string.Empty;

            var fields = this.Select(_ => $"private {_} {ToVariableName(_)};");
            return string.Join("\n\t\t", fields);
        }

        private string ToVariableName(string text)
        {
            if (text.StartsWith("I")) text = text.Substring(1);

            return Char.ToLowerInvariant(text[0]) + text.Substring(1);
        }
    }
}
