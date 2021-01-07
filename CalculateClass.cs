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