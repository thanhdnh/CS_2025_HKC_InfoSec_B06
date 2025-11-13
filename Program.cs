internal class Program
{
    //Hoặc viết hàm ở đây
    static void Swap1(int a, int b)
    {
        int t = a;
        a = b;
        b = t;
        Console.WriteLine($"Trong Swap: a={a}, b={b}");
    }
    static void Swap2(ref int a, ref int b)
    {
        int t = a;
        a = b;
        b = t;
        Console.WriteLine($"Trong Swap: a={a}, b={b}");
    }
    static void Swap3(out int a, out int b)
    {
        int t = a = 1;
        a = b = 1;
        b = t;
        Console.WriteLine($"Trong Swap: a={a}, b={b}");
    }
    static void TinhDTCV_HinhTron(double R, out double C,
                                                out double S)
    {
        C = 2 * Math.PI * R;
        S = Math.PI * R * R;
    }
    static void TinhDTCV_HinhTron2(double R, ref double C,
                                                ref double S)
    {
        C = 2 * Math.PI * R;
        S = Math.PI * R * R;
    }
    static void KT_NT_CP_DX(int n, out bool NT, out bool CP,
                                                    out bool DX)
    {
        NT = KTNT(n);
        CP = KTCP(n);
        DX = KTDX(n);
    }
    static bool KTNT(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }
    static bool KTCP(int n)
    {
        return ((int)Math.Pow(Math.Floor(Math.Sqrt(n)), 2)==n);
    }
    static bool KTDX(int n)
    {
        string s = n + "";
        string r = "";  //xâu đảo ngược của xâu s
        for (int i = s.Length - 1; i >= 0; i--)
            r = r + s[i];
        return s==r;
    }
    private static void Main(string[] args)
    {
        int so = 131;
        bool NT, CP, DX;
        KT_NT_CP_DX(so, out NT, out CP, out DX);
        Console.WriteLine(NT ? $"{so} là NT" : $"{so} không là NT");
        Console.WriteLine(CP ? $"{so} là CP" : $"{so} không là CP");
        Console.WriteLine(DX ? $"{so} là DX" : $"{so} không là DX");
        /*
        double R = 4;
        double C = 0, S = 0;
        TinhDTCV_HinhTron(R, out C, out S);
        //TinhDTCV_HinhTron2(R, ref C, ref S);
        Console.WriteLine($"Chu vi HT ban kinh {R}: {C}");
        Console.WriteLine($"Dien tich HT ban kinh {R}: {S}");
        */
        /*
        int a = 3, b = 5;
        Console.WriteLine($"Ngoài Swap: a={a}, b={b}");
        Swap3(out a, out b);
        Console.WriteLine($"Ngoài Swap: a={a}, b={b}");
        */

        /*
        double m = 5, n = 4;
        Console.WriteLine($"{m}+{n}={TinhTong(m, n)}");

        InCapSoCong(1, 0.5, 10);

        double a = 1, b = 2, c = 5, d = 11;
        Console.WriteLine($"GTTB cua {a}, {b}, {c}, {d} là: {TinhGTTB(a, b, c, d)}");

        double R = 4;
        TinhCV_DTHinhTron(R);

        int p = 9, q = 7;
        Console.WriteLine(KiemTranSoNT(p));
        Console.WriteLine(KiemTranSoNT(q));
        */
    }
    static bool KiemTranSoNT(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }
    static void TinhCV_DTHinhTron(double R)
    {
        double cv = 2 * Math.PI * R;
        double dt = Math.PI * R * R;
        Console.WriteLine($"Chu vi HT ban kinh {R} la: {cv}");
        Console.WriteLine($"Dien tich HT ban kinh {R} la: {dt}");
    }
    static double TinhGTTB(double a, double b, double c, double d)
    {
        double sum = a + b + c + d;
        double avg = sum / 4;
        return avg;
    }
    //Viết hàm ở đây
    static double TinhTong(double a, double b)
    {
        double sum = a + b;
        return sum;
    }
    static void InCapSoCong(double a0, double a, int n)
    {
        Console.WriteLine("Cấp số cộng với số hạng đầu {a0} và công sai {a}: ");
        for(int i=1; i<=n; i++)
            Console.WriteLine($"a[{i}]={a0+i*a}");
    }
}