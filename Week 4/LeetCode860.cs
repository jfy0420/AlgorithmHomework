using System.Collections.Generic;

namespace algorithmHomework{
    /*
    860. 柠檬水找零
    */

    public class LeetCode860{
        public bool LemonadeChange(int[] bills) {
            int change5=0, change10=0;

            for(int i=0;i<bills.Length;i++)
            {
                if(bills[i]==5)
                    change5++;             
                else if(bills[i]==10){
                    if(change5==0)
                        return false;
                    else{
                        change5--;
                        change10++;
                    }
                }
                else
                {
                    //需要优先用掉10的零钱
                    if(change5>=1&&change10>=1){
                        change5--;
                        change10--;
                    }
                    else if(change5>=3){
                        change5-=3;
                    }
                    else{
                        return false;
                    }
                        
                }  
            }
            return true;
        }

        //最后判断5/10的数量是否为负
        /*if (customer pays with $5) five++;
        if (customer pays with $10) ten++, five--;
        if (customer pays with $20) ten--, five-- or five -= 3;
        Check if five is positive, otherwise return false.*/

        public bool LemonadeChange2(int[] bills) {
            int change5=0, change10=0;
            for(int i=0;i<bills.Length;i++)
            {
                if(bills[i]==5)
                    change5++;
                else if(bills[i]==10){
                    change10++;
                    change5--;
                }
                else{
                    if(change10>0){
                        change10--;
                        change5--;
                    }
                    else{
                        change5-=3;
                    }
                }

                if(change5<0) return false;
            }
            return true;
        }
    }
}