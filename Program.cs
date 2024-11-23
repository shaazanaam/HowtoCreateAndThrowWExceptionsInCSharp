string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

string overallStatusMessage = "";

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}


catch (DivideByZeroException ex)
{
    Console.WriteLine(" An error occured during 'Workflow1'");
    Console.WriteLine(ex.Message);
}


static void Workflow1(string[][] userEnteredValues)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        //processStatusMessage = Process1(userEntries);

        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
        }

        
    }

    if (operationStatusMessage == "good")
    {
        operationStatusMessage = "operating procedure complete";
    }

    //return operationStatusMessage;
}

static void Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        // bool integerFormat = int.TryParse(userValue, out valueEntered);

        //if (integerFormat == true)
        //{
        //   if (valueEntered != 0)
        try
        {
            valueEntered = int.Parse(userValue);

        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException(" Invalid data. User input values must be valid integers.");
            throw invalidFormatException;
        }
        try
        {
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }

        catch (DivideByZeroException)
        {
            DivideByZeroException invalidDivision = new DivideByZeroException("Invalid data . User input must be non- zero values");
            throw invalidDivision;
        }


    }

    //return returnMessage;
}