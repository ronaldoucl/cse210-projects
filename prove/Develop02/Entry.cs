using System;

public class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public DateTime _date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public override string ToString()
    {
        return $"Date: {_date.ToShortDateString()} - Prompt: {_prompt}\nResponse: {_response}\n";
    }

    public string ToCsv()
    {
        return $"{_date},{EscapeForCsv(_prompt)},{EscapeForCsv(_response)}";
    }

    private static string EscapeForCsv(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            field = field.Replace("\"", "\"\"");
            field = $"\"{field}\"";
        }
        return field;
    }
}