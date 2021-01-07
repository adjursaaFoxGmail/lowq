using System;

namespace lowq
{
    public class CalculateClass: ICalculate
    {
        int l1, l2, l3, l4, l5, l6, l7, l8, l9;
        public CalculateClass(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9)
        {
            l1 = v1;
            l2 = v2;
            l3 = v3;
            l4 = v4;
            l5 = v5;
            l6 = v6;
            l7 = v7;
            l8 = v8;
            l9 = v9;
            if (l1 > l2) // usually false
            {
                if (l8 > l9)
                {
                    l8 += 1;
                    return;
                }
                else
                 return;
            }
            else
            {
                l1 =l1 + 1; 
            }
            if (l2 > l3) // usually false
            {
                if (l7<l8)
                {
                     l7 = l7+1;
                     return;
                }                   
                else
                if(l3> l4)
                {
                    l3 = l3+1;
                    return;
                }
                return;
            }
            else
            {  l2 = l2 + 1; } 
            if (l7 == 87)
                switch(l6)
                {
                    case 66:
                        return;
                        case 6:
                    l6 +=1;
                    break;
                    case 67:
                    l6 +=2;
                    return;
                    case 88:
                    return;
                }           
        }
        public int SumOf9(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9)
        {
            return(v1+v2+v3+v4+v5+v6+v7+v8+v9);
        }
        public int Sum()
        {
            return(l1+l2+l3+l4+l5+l6+l7+l8+l9);
        }
    }
    
}