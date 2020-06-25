using System;
using System.Collections;

namespace Keyword_Recoginition_Using_Hash_Table
{
    class Program
    { 
      // Keyword Recoginition using hashtable
      // Submitted by: Komal Shehzadi (2016-CS-178)
      
        static void Main(string[] args)
        {
            while (true)
            {
                Boolean flag = false;
                string strInput;
                Hashtable keyWords = new Hashtable();
                //Storing keywords in hash table
                keyWords.Add("01", "abstract");
                keyWords.Add("02", "as");
                keyWords.Add("03", "base");
                keyWords.Add("04", "bool");
                keyWords.Add("05", "break");
                keyWords.Add("06", "byte");
                keyWords.Add("07", "case");
                keyWords.Add("08", "catch");
                keyWords.Add("09", "char");
                keyWords.Add("10", "checked");
                keyWords.Add("11", "class");
                keyWords.Add("12", "const");
                keyWords.Add("13", "continue");
                keyWords.Add("14", "decimal");
                keyWords.Add("15", "default");
                keyWords.Add("16", "delegate");
                keyWords.Add("17", "do");
                keyWords.Add("18", "double");
                keyWords.Add("19", "else");
                keyWords.Add("20", "enum");
                keyWords.Add("21", "event");
                keyWords.Add("22", "explicit");
                keyWords.Add("23", "extern");
                keyWords.Add("24", "false");
                keyWords.Add("25", "finally");
                keyWords.Add("26", "finally");
                keyWords.Add("27", "float");
                keyWords.Add("28", "for");
                keyWords.Add("29", "foreach");
                keyWords.Add("30", "goto");
                keyWords.Add("31", "if");
                keyWords.Add("32", "implicit");
                keyWords.Add("33", "in");
                keyWords.Add("34", "int");
                keyWords.Add("35", "interface");
                keyWords.Add("36", "internal");
                keyWords.Add("37", "is");
                keyWords.Add("38", "lock");
                keyWords.Add("39", "long");
                keyWords.Add("40", "namespace");
                keyWords.Add("41", "new");
                keyWords.Add("42", "null");
                keyWords.Add("43", "object");
                keyWords.Add("44", "operator");
                keyWords.Add("45", "out");
                keyWords.Add("46", "override");
                keyWords.Add("47", "params");
                keyWords.Add("48", "private");
                keyWords.Add("49", "protected");
                keyWords.Add("50", "public");
                keyWords.Add("51", "readonly");
                keyWords.Add("52", "ref");
                keyWords.Add("53", "return");
                keyWords.Add("54", "sbyte");
                keyWords.Add("55", "sealed");
                keyWords.Add("56", "short");
                keyWords.Add("57", "sizeof");
                keyWords.Add("58", "stackalloc");
                keyWords.Add("59", "static");
                keyWords.Add("60", "string");
                keyWords.Add("61", "struct");
                keyWords.Add("62", "switch");
                keyWords.Add("63", "this");
                keyWords.Add("64", "throw");
                keyWords.Add("65", "true");
                keyWords.Add("66", "try");
                keyWords.Add("67", "typeof");
                keyWords.Add("68", "uint");
                keyWords.Add("69", "ulong");
                keyWords.Add("70", "unchecked");
                keyWords.Add("71", "unsafe");
                keyWords.Add("72", "ushort");
                keyWords.Add("73", "using");
                keyWords.Add("74", "using");
                keyWords.Add("75", "virtual");
                keyWords.Add("76", "void");
                keyWords.Add("77", "volatile");
                keyWords.Add("78", "while");
                keyWords.Add("79", "nameof");
                keyWords.Add("80", "join");
                keyWords.Add("81", "global");
                keyWords.Add("82", "group");
                keyWords.Add("83", "value");
                keyWords.Add("84", "var");
                keyWords.Add("85", "set");

                Console.Write("Enter input string = ");
                strInput = Console.ReadLine();
                // Get a collection of the keys.
                ICollection key = keyWords.Keys;

                foreach (string k in key)
                {
                    if (keyWords[k].Equals(strInput))
                    {
                        flag = true;
                        Console.WriteLine("<" + k + ", " + keyWords[k] + ">");
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("It is a Keyword!");
                    Console.WriteLine("********************************************");
                }
                else
                {
                    Console.WriteLine("It is an Identifier or Operator or Symbol!");
                    Console.WriteLine("*********************************************");
                }
            }
        }
    }
}
