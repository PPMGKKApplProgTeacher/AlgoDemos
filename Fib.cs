using System;
using System.Diagnostics;

class Fib
{
    private static ulong GetNthFibonacciTailRecursive(ulong n, ulong a = 1, ulong b = 1)
    {
        if (n == 1) return a;
        if (n == 2) return b;

        return GetNthFibonacciTailRecursive(n - 1, b, a + b);
    }

    public static ulong GetNthFibonacciIterativeOptimized(ulong n)
    {
        if (n <= 2) return 1;
        ulong a = 1, b = 1;
        for (ulong i = 3; i <= n; i++)
        {
            ulong temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    public static ulong GetNthFibonacciIte(ulong n)
    {
        ulong number = n - 1;
        ulong[] Fib = new ulong[number + 1];
        Fib[0] = 1;
        Fib[1] = 1;
        for (ulong i = 2; i <= number; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }

        return Fib[number];
    }

    public static ulong GetNthFibonacciNaiveRec(ulong n)
    {
        if (n > 15)
        {
            throw new Exception("I am not benchmarking this");
        }
        if ((n == 2) || (n == 1))
        {
            return 1;
        }
        else
        {
            return GetNthFibonacciNaiveRec(n - 1) + GetNthFibonacciNaiveRec(n - 2);
        }
    }

    public static ulong GetNthFibonacciArrRec(ulong n, ulong[] values = null)
    {
        if (values == null)
        {
            values = new ulong[n];
        }
        if ((n == 1) || (n == 2))
        {
            values[n - 1] = 1;
        }
        else
        {
            if (values[n - 1] == 0)
            {
                values[n - 1] = GetNthFibonacciArrRec(n - 1, values) + GetNthFibonacciArrRec(n - 2, values);
            }
        }

        return values[n - 1];
    }


    public static void Benchmark(Action action, string label, int iterations = 100000)
    {
        action.Invoke(); // Warm-up
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            action.Invoke();
        }
        stopwatch.Stop();
        Console.WriteLine($"{label}: {stopwatch.Elapsed.TotalMilliseconds / iterations:F6} ms (average over {iterations} iterations)");
    }

    // Helper method for benchmarking with exception handling
    public static void BenchmarkWithExceptionHandling(Action action, string methodName, int iterations)
    {
        try
        {
            Benchmark(action, methodName, iterations);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception in {methodName}: {ex.Message}");
        }
    }


    public static void Run()
    {
        ulong n = 93; // Use a valid Fibonacci number for testing		
        ulong[] values = new ulong[n];
        try
        {
            Console.WriteLine("Naive Recursive: " + GetNthFibonacciNaiveRec(n));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Naive Recursive: {ex.Message}");
        }
        Console.WriteLine("Array Recursive: " + GetNthFibonacciArrRec(n));
        Console.WriteLine("Tail Recursive: " + GetNthFibonacciTailRecursive(n));
        Console.WriteLine("Iterative: " + GetNthFibonacciIte(n));
        Console.WriteLine("Iterative Optimized: " + GetNthFibonacciIterativeOptimized(n));


        Console.WriteLine("\nBenchmarking Fibonacci methods...\n");


        BenchmarkWithExceptionHandling(() =>
        {
            GetNthFibonacciNaiveRec(n);
        }, "Naive Recursive", 1000000);

        Benchmark(() =>
        {
            GetNthFibonacciArrRec(n);
        }, "Array Recursive", 1000000);


        Benchmark(() =>
        {
            GetNthFibonacciTailRecursive(n);
        }, "Tail Recursive", 1000000);

        Benchmark(() =>
        {
            GetNthFibonacciIte(n);
        }, "Iterative", 1000000);

        Benchmark(() =>
        {
            GetNthFibonacciIterativeOptimized(n);
        }, "Iterative Optimized", 1000000);

    }
}
