using System;
using System.Collections.Generic;

public static class SieveOfEratosthenes
{
    public static List<uint> FindPrimes(uint n)
    {
        var primes = new List<uint>();

        if (n < 2)
            return primes;

        bool[] isPrime = new bool[n + 1];

        for (uint i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (uint i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (uint j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (uint i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}