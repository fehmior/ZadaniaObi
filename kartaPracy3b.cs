         //1.
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine(i+" "+"dzień listopada");
        }
        //2.
        for (int i = 0; i < 9; i+=2)
        {
                Console.WriteLine(i * i);
        }
        //3.
        for (int i = 1000; i <= 9999; i++)
        {
            if (i % 379 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //4.
        for (int i = 100; i <= 999; i++)
        {
            if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //5.
        int suma = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int b = int.Parse((Console.ReadLine()));
            suma += b;
        }
        Console.WriteLine(suma);

        //6.
        int k = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 0; i <= k; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }
        Console.WriteLine(suma);
        

        //7.
        int m = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 10; i < m; i++)
        {
            if (i % 2 != 0)
            {
                suma += i;
            }
        }
        Console.WriteLine(suma);
        
        //8
        double wart = double.Parse(Console.ReadLine());
        int czas = int.Parse(Console.ReadLine());
        int a = czas * 12 / 2;
        double ob = 0;
        for (int i = 0; i < a; i++)
        {
            ob += wart * 0.06;

        }
        Console.Write(ob+wart);

        //9
        int n = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 100 == 21)
            {
                suma += i;
            }
        }
        Console.Write($"Suma liczb kończących się liczba 21 wynosi {suma} ");


