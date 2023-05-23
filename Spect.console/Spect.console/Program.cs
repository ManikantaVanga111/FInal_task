using Spectre.Console;
namespace Day3_Spectre_Console_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*  AnsiConsole.MarkupLine("[red] Hello [/]");
              AnsiConsole.MarkupLine("[underline red] Hello [/]");
              AnsiConsole.MarkupLine("[red] Hello [/] [green]World[/]");
              AnsiConsole.MarkupLine("[default on red] Hello [/] [green]World[/]");
              AnsiConsole.MarkupLine("[gray on blue] Hello [/] [green]World[/]");
              AnsiConsole.MarkupLine("[rgb(124,254,0)] Hello [/] [green]World[/]");*/


            //Emojis
            //AnsiConsole.MarkupLine("Good Morning :beaming_face_with_smiling_eyes:");

            /*//user text prompts

            string text = AnsiConsole.Ask<string>("[red]Enter some text[/]");
            AnsiConsole.MarkupLine($"[blue]{text}[/]");*/


            //Selection prompt

            /*   //Single selection
               var choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                       .Title("Select your choice")
                       .AddChoices(new[] {
                           "Apple", "Banana", "Mango",
                           "Orange"
               }));
               AnsiConsole.MarkupLine($"You selected [blue]{choice}[/]");*/

            //Multiple selection
            /* var choice1 = AnsiConsole.Prompt(new MultiSelectionPrompt<string>()
                     .Title("Select your choice")
                     .AddChoices(new[] {
                         "Apple", "Banana", "Mango",
                         "Orange"
             }));

             foreach (var c in choice1)
             {
                 Console.WriteLine($"You selected {c}");
             }*/



            /*//Tables
            SqlConnection con = new SqlConnection("Server=IN-333K9S3;Database=DemoDB;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select * from Customers", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            var table = new Table();
            //Borders

            table.Border = TableBorder.Ascii2;


            //Adding Columns
            table.AddColumn("CustomerId");
            table.AddColumn("ContactName");
            table.AddColumn("Email");
            table.AddColumn("City");
            table.AddColumn("Age");
            //table.HideHeaders();
            //table.Border(TableBorder.Rounded);

            table.Title("[blue]INCOME DETAILS[/]");// --> To add the table title

            table.BorderColor(Color.Blue);// -->To add color to table border

            //table.Columns[0].LeftAligned();// -->To center the text in particular column

            //To center the text in all colums
            foreach (var column in table.Columns)
            {
                column.RightAligned(); // centered(),leftaligned(),rightaligned()
            }

            while (reader.Read())
            {
                //Adding Rows
                table.AddRow(reader["CustomerId"].ToString(), reader["CustomerName"].ToString(), reader["Email"].ToString(), reader["City"].ToString(), reader["Age"].ToString());
            }
            con.Close();
            

            //printing the table
            AnsiConsole.Write(table);

*/


            /*//Figlet
            AnsiConsole.Write(new FigletText("Customer Details").Centered().Color(Color.Red));
            */
            /*
                        //Panel

                        string s = "My name is harish";
                        var panel = new Panel(s)
                            .Header("Info")
                            .BorderColor(Color.Green);
                        //.Expand(); //--> It will give the box of console width
                        panel.Border = BoxBorder.Rounded;

                        AnsiConsole.Render(panel);
            */
            /*
                        //Calander
                        var calendar = new Calendar(2020, 10);
                        calendar.HeaderStyle(Style.Parse("blue bold"));
                        calendar.AddCalendarEvent(2020, 10, 11);
                        calendar.HighlightStyle(Style.Parse("yellow bold"));
                        calendar.BorderColor(Color.Blue);
                        AnsiConsole.Write(calendar);
            */

            //RULES
            Console.WriteLine();
            var rule = new Rule("[green]Welcome to Product Managment App[/]");
            //rule.LeftJustified();
            rule.Style = Style.Parse("red dim");
            AnsiConsole.Write(rule);

        }
    }
}