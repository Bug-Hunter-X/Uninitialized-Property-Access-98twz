public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod()
    {
        int value = MyProperty * 2;
    }

    //or
    public int MyProperty { get; private set; }
    public ExampleClass(int myProperty) { MyProperty = myProperty;}
    public void MyMethod()
    {
        int value = MyProperty * 2;
    }
} 