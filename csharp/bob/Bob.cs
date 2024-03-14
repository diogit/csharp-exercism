using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        string answer = "Whatever.";
        if (String.IsNullOrEmpty(statement))
        {
            answer = "Fine. Be that way!";
        } else if (statement.EndsWith("?") && statement == statement.ToUpper() && statement.ToLower() != statement.ToUpper())
        {
            answer = "Calm down, I know what I'm doing!";
        } else if (statement.EndsWith("?"))
        {
            answer = "Sure.";
        } else if (statement == statement.ToUpper() && statement.ToLower() != statement.ToUpper())
        {
            answer = "Whoa, chill out!";
        }

        return answer;
    }
}