using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat1 = new Cat();
        Cat cat2 = new Cat();
        cat1.Damage=2;
        cat2.Damage=5;
        int ketqua = cat1.CompareTo(cat2);
        if(ketqua>0)
        {
            Console.WriteLine("meo 1 khoe hon");
        }else if(ketqua==0)
        {
            Console.WriteLine("khoe bang nhau");
        }else
        {
            Console.WriteLine("meo 2 khoe hon");
        }
    }
}
public class Cat : IComparable<Cat>
{
    public int Damage =3;
    public int CompareTo(Cat other)
    {
        return this.Damage.CompareTo(other.Damage);
    }
}
