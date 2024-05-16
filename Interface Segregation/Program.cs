// See https://aka.ms/new-console-template for more information

#region Before
//public interface IWorker
//{
//    void Work();
//    void Eat();
//    void Sleep();
//}
//public class HumanWorker : IWorker
//{
//    public void Work() { /*...*/ }
//    public void Eat() { /*...*/ }
//    public void Sleep() { /*...*/ }
//}

//public class RobotWorker : IWorker
//{
//    public void Work() { /*...*/ }
//    public void Eat() { /*...*/ } // Not applicable to robots
//    public void Sleep() { /*...*/ } // Not applicable to robots
//}
#endregion

#region After
//public interface IWorkable
//{
//    void Work();
//}

//public interface IEatable
//{
//    void Eat();
//}

//public interface ISleepable
//{
//    void Sleep();
//}

//public class HumanWorker : IWorkable, IEatable, ISleepable
//{
//    public void Work() { /*...*/ }
//    public void Eat() { /*...*/ }
//    public void Sleep() { /*...*/ }
//}

//public class RobotWorker : IWorkable
//{
//    public void Work() { /*...*/ }
//}
#endregion