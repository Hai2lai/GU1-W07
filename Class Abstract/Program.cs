class Program
{
    public static void Main(string[] args)
    {
        
    }
}
public interface IDamage
{
    public void Health();
    public void Death();
}
public interface IAtack
{
    public void Fire();
    public void Chem();
}
public abstract class Animal
{
    public abstract void Eat();
    public abstract void Sleep();
}

public class Cat : Animal,IDamage,IAtack
{
    public void Chem()// interface
    {
        
    }

    public void Death()// interface
    {
        
    }

    public override void Eat()//abstract
    {
        
    }

    public void Fire()// interface
    {
        
    }

    public void Health()// interface
    {
        
    }

    public override void Sleep()//abstract
    {
        
    }
}

public class Tiger : IDamage
{
    int health = 1000;
    bool isDead=false;
    public void Health()
    {
        health-=1;
    }

    public void Death()
    {
        if(health<0)
        {
            isDead = true;
        }

    }

}
public class Chicken : IDamage
{   
    int health = 200;
    bool isStar=true;
    bool isDead=false;
    public void Death()
    {
        if(health<0 && !isStar)
        {
            isDead=true;
        }
    }

    public void Health()
    {
        health -= 10;
    }
}
public interface Effect
{
    void Effect();
}
public class Water : Effect
{
    public void Effect()
    {
       Console.WriteLine("ban nuoc len");
    }
}
public class Steel : Effect
{
    public void Effect()
    {
        Console.WriteLine("toe lua ");
    }
}