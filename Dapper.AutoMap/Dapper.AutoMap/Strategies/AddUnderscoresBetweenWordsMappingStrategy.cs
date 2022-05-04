using System.Text;

namespace Dapper.AutoMap;

public class AddUnderscoresBetweenWordsMappingStrategy : IMappingStrategy
{
    public string To(string from)
    {
        if (string.IsNullOrEmpty(from))
            return from;
        var chars = from.ToCharArray();
        var sb = new StringBuilder(chars.Length);

        var prev = 'A';
        foreach (var c in chars)
        {
            if (c != '_' && char.IsUpper(c) && !char.IsUpper(prev))
            {
                sb.Append('_');
            }
            sb.Append(c);
            prev = c;
        }

        return sb.ToString();
    }
}
