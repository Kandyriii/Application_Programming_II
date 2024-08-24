string str1 = "Hello";
string str2 = "Hello";
string str3 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
Console.WriteLine(str1 == str2);
Console.WriteLine(str1 == str3);
Console.WriteLine(str1.Equals(str3));