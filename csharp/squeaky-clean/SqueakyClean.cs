using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new StringBuilder();
        bool isAfterDash = false;
        
        foreach (char c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when 'α' <= c && c <= 'ω' => string.Empty,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => string.Empty,
            });
            isAfterDash = c.Equals('-');
        }
        return stringBuilder.ToString();
    }
}
