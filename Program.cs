using System;

namespace Min_Cost_Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cost = new int[] { 2, 4, 3, 100, 7, 3, 122 };
            Console.WriteLine(minCostClimbingStairs(cost, cost.Length));
        }

        public static int minCostClimbingStairs(int[] cost, int n)
        {
            int[] dp = new int[n];

            if (n == 1)
                return cost[0];
                
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
            }
            return Math.Min(dp[n - 2], dp[n - 1]);
        }
    }
}
