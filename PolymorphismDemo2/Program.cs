



public class parent
{
    public void show () 
    { 
        Console.WriteLine("parent class show method");
    }

    public virtual void Display()
    {
        Console.WriteLine("parent class display method");
    }  

    public void putdata() 
    { 
      Console.WriteLine( "parent class putdata method");
    }

}

public class child : parent 
{
    public void show (int a)
    {
        Console.WriteLine("child class show method"); // method overloading
    }  

    public override void Display()  //Method overridding
    {
        Console.WriteLine("child class display method");
        parent p = new parent();
        p.Display();  // calling to parent class method 
        p.putdata();  // calling to parent class methods
    }

    public new void putdata()  // Method hiding
    {
        Console.WriteLine("child class putdata method");
        base.Display();  // calling to parent class methods
        base.putdata();  // calling to parent class methods
    }    
}
 
public class program
{
    public static void Main() 
    {
        child c= new child();
        c.show();     // parent class show method 
        c.show(10);   // child class show method 
        c.Display();   // child class display method 
        c.putdata();   // child class putdata method


        parent p = new parent ();
        p.show();  // parent class show method 
        p.Display ();  // parent class show method 
        p.putdata();   // parent class show methd 

        // p.show(10)  // invalid
        parent parent;

            parent = c; 
        // child = p; invalid 

        parent.Display();
        parent.Display();

        parent .Display(); // child class method
        parent.putdata();  // child class method 

        parent = p;
        parent.Display();   // parent class method 
        parent.putdata ();  // parent class method  


    }  
}
