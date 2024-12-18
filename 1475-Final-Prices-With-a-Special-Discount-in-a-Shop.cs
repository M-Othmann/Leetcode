public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] newArr = new int[prices.Length];
        for (int i = 0; i < prices.Length; i++)
        {
            int discount = 0;

            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    discount = prices[j];
                    break; // Found the minimum qualifying price
                }
            }

            newArr[i] = prices[i] - discount;
        }

        return newArr;
    }
}