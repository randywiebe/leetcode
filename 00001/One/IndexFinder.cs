namespace One
{
    public static class IndexFinder
    {
        public static int[] FindIndices(int[] nums, int target)
        {
            int firstInteger = 0;
            int secondInteger = 0;

            int firstIndex = -1;
            int secondIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (firstIndex >= 0)
                {
                    break;
                }

                firstInteger = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    secondInteger = nums[j];

                    if (firstInteger + secondInteger == target)
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }

            return new int[] { firstIndex, secondIndex };
        }
    }
}
