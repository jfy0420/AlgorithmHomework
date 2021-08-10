namespace algorithmHomework
{
    public static class LeetCode66{
        public static int[] PlusOne(int[] digits) {
                int length=digits.Length;
                for(int i=length-1;i>=0;i--)
                {
                    if(digits[i]<9)
                    {
                        digits[i]++;
                        return digits;
                    }
                    digits[i]=0;           
                }

                int[] newDigits= new int[length+1];
                newDigits[0]=1;
                
                return newDigits;
            }
    }
}