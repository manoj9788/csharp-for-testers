using System;
class MyGenericClss<T>
{
    private T genericMemberVariable;
       public MyGenericClss(T value)
    {
        genericMemberVariable = value;
    }

    public T genericMethod(T genericParameter){

        Console.WriteLine("parameter type:{0}, value:{1}",typeof(T).ToString(),genericMemberVariable);
        Console.WriteLine("parameter type:{0}, value:{1}",typeof(T).ToString(),genericParameter);
            return genericParameter;
    }
}
public class driverclass{
    public static void Main(string[] args){
        MyGenericClss<int> mgc = new MyGenericClss<int>(10);
        mgc.genericMethod(100);
    }
}