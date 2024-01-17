internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animal1 = new Animal[2];
        animal1[0] = new Tiger();
        animal1[1] = new Chickens();
        foreach(var item in animal1)
        {
            if(item is Chickens)
            {

            }
        }
        Fuit[] fuit1 = new Fuit[2];
        fuit1[0] = new Apple();
        fuit1[1] = new Orange();
        foreach (var item in fuit1)
        {
            if(item is Apple)
            {
                
            }
        } 
    }
}
public abstract class Animal
{
    public abstract string MakeSound();
}
public interface IEdiable
{
    public string HowToEat();
}
public abstract class Fuit : IEdiable
{
    public abstract string HowToEat();
 
}
public class Chickens : Animal, IEdiable
{
    public string HowToEat()
    {
        return "Cound something";
    }

    public override string MakeSound()
    {
        return "chickens : Cluck Cluck...";
    }
}
public class Tiger : Animal
{
    public override string MakeSound()
    {
        return " Tiger: Grower...";
    }
}
public class Apple : Fuit
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
public class Orange : Fuit
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
// vitual --> có thể  có overide hay không vẫn chạy
// abstract --> phải có override
// 1 lớp chỉ có thể kế thừa từ 1 lớp
// 1 lopwskl có thể kế thwuaf từ nhiều interface
// nếu 1 lớp trước có thể kế thwauf từ interface , thi lớp dẫn xuất không thực hiện intelemant của interface đó