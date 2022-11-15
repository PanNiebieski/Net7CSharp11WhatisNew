using System.Text;
var name = "Street Fighter";
var sb = new StringBuilder();

var jsonText1 = "{ \n \"name\": \"Mortal Kombat\" , \"company\": \"A\" \n}";

var jsonText2 = """{ "name": "Mortal Kombat" , "company": "A" }""";

var jsonText3 = """
                { 
                    "name": "Mortal Kombat" , 
                    "company" : "A"
                }
                """;

//Interpolated String C# 6
var text = $"""
        Hello
    ----{name}----
        and goodbye
    """;

var jsonText4 = $$"""
                { 
                    name: {{name}} , 
                    company: A 
                }
                """;


sb.AppendLine(jsonText1);
sb.AppendLine(); sb.AppendLine();

sb.AppendLine(jsonText2);
sb.AppendLine(); sb.AppendLine();

sb.AppendLine(jsonText3);
sb.AppendLine(); sb.AppendLine();

sb.AppendLine(text);
sb.AppendLine(); sb.AppendLine();

sb.AppendLine(jsonText4);
sb.AppendLine(); sb.AppendLine();

Console.WriteLine(sb.ToString());


