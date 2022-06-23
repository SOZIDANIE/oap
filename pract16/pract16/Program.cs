static void Main()
{

    //zad 1
    /*    StreamReader sr = File.OpenText("T1.txt");
        string st = sr.ReadToEnd();
        string[] str = st.ToLower().Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("введите слово ");
        string InpuntStr = Console.ReadLine();
        var Count = str.Where(x => x == InpuntStr);
        Console.WriteLine($"были найдены>> {Count.Count()}  вхождения и поискового запроса {InpuntStr}");
        Console.ReadKey();*/

    //zad 2
    /*Console.WriteLine("введитке a b или c");
    string InpuntStr1 = Console.ReadLine();
    if (InpuntStr1 == "a")
    {
        Console.WriteLine("введите предложение "); string InpuntStr = "";
        try
        {
            InpuntStr = Console.ReadLine();
        }
        catch (Exception) { Console.WriteLine("неверный ввод"); }




        char[] str = new char[InpuntStr.Length];
        for (int i = 0; i < InpuntStr.Length; i++)
        {
            str[i] = InpuntStr[i];
        }

        var Count = str.Where(x => char.IsNumber(x));
        Console.WriteLine("количество цифр " + Count.Count());
        Console.ReadKey();
    }
    if (InpuntStr1 == "b")
    {
        Console.WriteLine("введите предложение "); string InpuntStr = "";
        try
        {
            InpuntStr = Console.ReadLine();
        }
        catch (Exception) { Console.WriteLine("неверный ввод"); }
        foreach (var S in InpuntStr)
        {
            if (S == '/') break;
            Console.Write(S);
        }

        Console.ReadKey();
    }

    if (InpuntStr1 == "c")
    {
        Console.WriteLine("введите предложение "); string InpuntStr = "";
        try
        {
            InpuntStr = Console.ReadLine();
        }
        catch (Exception) { Console.WriteLine("неверный ввод"); }



        int i1 = 0;
        string str = "";
        for (int i = 0; i < InpuntStr.Length; i++)
        {
            if (InpuntStr[i] == '/') i1++;
            if (i1 > 0) str += InpuntStr[i];

        }


        str = str.ToUpper();
        Console.WriteLine(str);
        StreamWriter sw = File.CreateText("T3");
        Console.ReadKey();

    }*/



    //zad 3
    /*        double[] MainArr = new double[8] { 5.1, 1, 3, 9.2, 2, 3, 5.1, 3 };
            int[] ch = new int[8]; List<double> list = new List<double>();
            for (int i = 0; i < 8; i++)
            {
                int e = 0;
                int count = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (MainArr[i] == MainArr[j]) count++;

                    e++;
                }
                if (e != 1) ch[i] = count;


            }
            for (int i = 0; i < 8; i++)
            {
                if (!list.Contains(MainArr[i]))
                    Console.WriteLine(MainArr[i] + "-" + ch[i]);
                list.Add(MainArr[i]);
            }
            Console.ReadKey();*/

    //zad 4
    /*int numberPeople = Convert.ToInt32(Console.ReadLine());
    Dictionary<long, string> dic = new Dictionary<long, string>();
    StreamReader sr = File.OpenText("T4.txt");
    while (!sr.EndOfStream)
    {
        string localStr = sr.ReadLine();
        string country = ""; string СountPeole = "";
        foreach (var s in localStr)
        {
            if (Char.IsNumber(s)) СountPeole += s;
            if (Char.IsLetter(s) && s != ' ') country += s;



        }
        long.TryParse(СountPeole, out var number);
        dic.Add(number, country);

    }
    foreach (var s in dic.Where(x => x.Key > numberPeople).OrderBy(x => x.Key))
    {

        Console.WriteLine(s.Value + "  " + s.Key);
    }
    Console.ReadKey();*/



}