//

string[] first_arr = { "1234", "123", "1567", "-2", "computer science", "new" };

string[] second_arr = first_arr.Where(e => e.Length < 4).ToArray();

Console.WriteLine(String.Join(' ', second_arr));
