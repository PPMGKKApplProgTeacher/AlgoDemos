using System;
using System.Collections.Generic;

namespace CombinationSumProblems
{
    // Problem 1: Combination Sum
    // Проблем 1: Сума на комбинации
    // Даден е масив от различни цели числа candidates и целево цяло число target. 
    // Върнете списък с всички уникални комбинации от кандидати, където избраните числа сумират до target.
    // Същото число може да бъде избрано от candidates неограничен брой пъти.
    // Всяка комбинация трябва да бъде уникална по честотата на използване на поне едно от числата.
    // Ограничения:
    //     1 <= candidates.length <= 30
    //     2 <= candidates[i] <= 40
    //     Всички елементи в candidates са уникални.
    //     1 <= target <= 40


    // Test 1: candidates = [2, 4, 6], target = 8
    // Expected Output: [[2,2,2,2],[2,2,4],[4,4],[2,6]]

    // Test 2: candidates = [3, 5, 7], target = 10
    // Expected Output: [[3,3,3,3],[3,7],[5,5]]

    // Test 3: candidates = [1, 2, 3], target = 4
    // Expected Output: [[1,1,1,1],[1,1,2],[2,2],[1,3]]

    // Test 4: candidates = [8, 10, 12], target = 16
    // Expected Output: [[8,8]]

    // Test 5: candidates = [9], target = 9
    // Expected Output: [[9]]

    // Test 6: candidates = [2, 3, 6], target = 11
    // Expected Output: [[2,2,2,2,3],[2,2,3,6]]

    // Test 7: candidates = [1, 2], target = 5
    // Expected Output: [[1,1,1,1,1],[1,1,1,2],[1,2,2]]

    // Test 8: candidates = [5, 10, 20], target = 30
    // Expected Output: [[5,5,5,5,5,5],[5,5,5,5,10],[10,10,10],[5,5,20],[10,20]]

    // Test 9: candidates = [4, 6, 8], target = 12
    // Expected Output: [[4,4,4],[4,8],[6,6]]

    // Test 10: candidates = [3, 5, 7], target = 6
    // Expected Output: [[3,3]]

    class CombinationSum
    {
        public void Solve(int[] candidates, int target)
        {
            Console.WriteLine("Combination Sum problem called with:");
            Console.WriteLine($"Candidates: {string.Join(", ", candidates)}, Target: {target}");
            
            // Очакван изход:
            // Input: candidates = [2,3,6,7], target = 7
            // Output: [[2,2,3],[7]]
            // 
            // Input: candidates = [2,3,5], target = 8
            // Output: [[2,2,2,2],[2,3,3],[3,5]]
        }
    }

    // Problem 2: Combination Sum II
    // Проблем 2: Сума на комбинации II
    // Дадена е колекция от кандидат числа (candidates) и целево число (target).
    // Намерете всички уникални комбинации в candidates, където кандидат числата сумират до target.
    // Всяко число от candidates може да бъде използвано само веднъж в комбинацията.
    // Ограничения:
    //     1 <= candidates.length <= 100
    //     1 <= candidates[i] <= 50
    //     1 <= target <= 30

    // Test 1: candidates = [3, 5, 7], target = 12
    // Expected Output: [[5,7]]

    // Test 2: candidates = [2, 3, 6, 7], target = 9
    // Expected Output: [[2,7],[3,6]]

    // Test 3: candidates = [10, 1, 2, 7, 6, 1, 5], target = 12
    // Expected Output: [[1,1,10],[1,2,6],[2,5,5]]

    // Test 4: candidates = [1, 2, 3, 4, 5], target = 10
    // Expected Output: [[1,2,3,4],[2,3,5]]

    // Test 5: candidates = [2, 2, 3, 3, 4], target = 6
    // Expected Output: [[2,2,2],[3,3]]

    // Test 6: candidates = [5, 10, 15], target = 20
    // Expected Output: [[5,15],[10,10]]

    // Test 7: candidates = [1, 1, 1, 2, 2, 2], target = 4
    // Expected Output: [[1,1,2],[2,2]]

    // Test 8: candidates = [8, 8, 8], target = 16
    // Expected Output: [[8,8]]

    // Test 9: candidates = [6, 7, 8], target = 13
    // Expected Output: [[6,7]]

    // Test 10: candidates = [1, 5, 6, 7], target = 8
    // Expected Output: [[1,7]]

    class CombinationSumII
    {
        public void Solve(int[] candidates, int target)
        {
            Console.WriteLine("Combination Sum II problem called with:");
            Console.WriteLine($"Candidates: {string.Join(", ", candidates)}, Target: {target}");
            
            // Очакван изход:
            // Input: candidates = [10,1,2,7,6,1,5], target = 8
            // Output: [[1,1,6],[1,2,5],[1,7],[2,6]]
            //
            // Input: candidates = [2,5,2,1,2], target = 5
            // Output: [[1,2,2],[5]]
        }
    }

    // Problem 3: Combination Sum III
    // Проблем 3: Сума на комбинации III
    // Намерете всички валидни комбинации от k числа, които сумират до n при следните условия:
    //     Използват се само числа от 1 до 9.
    //     Всяко число се използва най-много веднъж.
    // Ограничения:
    //     2 <= k <= 9
    //     1 <= n <= 60


    // Test 1: k = 2, n = 5
    // Expected Output: [[1,4],[2,3]]

    // Test 2: k = 3, n = 10
    // Expected Output: [[1,2,7],[1,3,6],[1,4,5],[2,3,5]]

    // Test 3: k = 4, n = 15
    // Expected Output: [[1,2,3,9],[1,2,4,8],[1,2,5,7],[1,3,4,7],[1,3,5,6],[2,3,4,6]]

    // Test 4: k = 5, n = 18
    // Expected Output: [[1,2,3,4,8],[1,2,3,5,7],[1,2,4,5,6]]

    // Test 5: k = 3, n = 20
    // Expected Output: [[6,7,8]]

    // Test 6: k = 2, n = 8
    // Expected Output: [[1,7],[2,6],[3,5]]

    // Test 7: k = 4, n = 22
    // Expected Output: [[4,5,6,7]]

    // Test 8: k = 3, n = 6
    // Expected Output: [[1,2,3]]

    // Test 9: k = 2, n = 12
    // Expected Output: [[3,9],[4,8],[5,7]]

    // Test 10: k = 4, n = 25
    // Expected Output: [[4,6,7,8]]

    class CombinationSumIII
    {
        public void Solve(int k, int n)
        {
            Console.WriteLine("Combination Sum III problem called with:");
            Console.WriteLine($"k: {k}, n: {n}");
            
            // Очакван изход:
            // Input: k = 3, n = 7
            // Output: [[1,2,4]]
            // 
            // Input: k = 3, n = 9
            // Output: [[1,2,6],[1,3,5],[2,3,4]]
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combination Sum Problems:");

            // Call Combination Sum Problem
            var combinationSum = new CombinationSum();
            combinationSum.Solve(new int[] { 2, 3, 6, 7 }, 7);
            combinationSum.Solve(new int[] { 2, 3, 5 }, 8);
            combinationSum.Solve(new int[] { 2 }, 1);

            // Call Combination Sum II Problem
            var combinationSumII = new CombinationSumII();
            combinationSumII.Solve(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
            combinationSumII.Solve(new int[] { 2, 5, 2, 1, 2 }, 5);

            // Call Combination Sum III Problem
            var combinationSumIII = new CombinationSumIII();
            combinationSumIII.Solve(3, 7);
            combinationSumIII.Solve(3, 9);
            combinationSumIII.Solve(4, 1);
        }
    }
}
