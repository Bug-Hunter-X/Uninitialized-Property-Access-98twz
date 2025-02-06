public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This line might throw an exception if MyProperty is not initialized
        int value = MyProperty * 2; 
    }
}