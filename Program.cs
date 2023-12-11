//var string1 = Console.ReadLine();
//Console.WriteLine(GoodBinaryString(string1));

using BinaryStrings;


string binaryString1 = "101010";
string binaryString2 = "00110";
string binaryString3 = "110";

GoodBinaryString binaryString = new GoodBinaryString();
Console.WriteLine(binaryString.CheckBinaryString(binaryString1)); //True
Console.WriteLine(binaryString.CheckBinaryString(binaryString2)); //True
Console.WriteLine(binaryString.CheckBinaryString(binaryString3)); //False