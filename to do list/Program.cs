using to_do_list;

while (true)
{
    try
    {

        Console.WriteLine("choose an option:\n1.add duty\n2.show duty with details\n3.reamove duty");
        var option = int.Parse(Console.ReadLine()!);
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("enter title name");
                    var dutyName = Console.ReadLine()!;
                    Console.WriteLine("enter description");
                    var description = Console.ReadLine()!;
                    Console.WriteLine("priority:\n1.high\n2.medium\n3.low");
                    var type = int.Parse(Console.ReadLine()!);
                    DateTime date;
                    bool result = false;
                    do
                    {
                        Console.WriteLine("enter date time");
                        result = DateTime.TryParse(Console.ReadLine()!, out date);
                    } while (!result);
                    DutyManagment.AddDuty(dutyName, description, date, type);
                    break;
                }
            case 2:
                {
                    foreach (var duty in DutyManagment.GetDuty())
                    {
                        duty.ShowDuty();
                        Console.WriteLine("**********************");
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("enter duty name");
                    var dutyName = Console.ReadLine()!;
                    DutyManagment.ReamoveDuty(dutyName);
                    break;
                }
        }
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}