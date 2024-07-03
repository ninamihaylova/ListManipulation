class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0] == "end")
            {
                break;
            }

            switch (command[0])
            {
                case "Add":
                    numbers.Add(int.Parse(command[1]));
                    break;
                case "Remove":
                    numbers.Remove(int.Parse(command[1]));
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(command[1]));
                    break;
                case "Insert":
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
