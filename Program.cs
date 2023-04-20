/*
1.public	The code is accessible for all classes

2.private	The code is only accessible within the same class

3.protected	The code is accessible within the same class,
            or in a class that is inherited from that class.
            You will learn more about inheritance in a later chapter

4.internal	The code is only accessible within its own assembly,
            but not from another assembly. 
            You will learn more about this in a later chapter.


example

public: public string color;

private: 
using System;
namespace MyApplication
{
    class car
    {
        private string model = "maruthi";
        static void Main(string[] args)
        {
            car MyObj=new car(); 
            Console.WriteLine(MyObj.model);
        }
    }
}
protected:
