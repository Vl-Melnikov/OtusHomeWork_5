class Program
{
    static void Main(string[] args)
    {
        Quadrocopter myQuadrocopter = new Quadrocopter();
       
        ExecuteGetRobotType(myQuadrocopter);

        List<string> list = myQuadrocopter.GetComponents();
        foreach (var s in list)
        {
            Console.WriteLine(s);
        }

        myQuadrocopter.Charge();
        myQuadrocopter.GetInfo();
    }
    static void ExecuteGetRobotType(IRobot type)
    {
        string robotType = type.GetRobotType();
        Console.WriteLine(robotType);
    }
}

public class Quadrocopter : IChargeable, IFlyingRobot
{
    private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

    public List<string> GetComponents()
    {
        return _components;
    }

    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged!");
    }

    public string GetInfo()
    {
        throw new NotImplementedException();
    }

}
interface IRobot
{
    string GetInfo();
    List<string> GetComponents();
    string GetRobotType()
    {
        return "I am a simple robot.";
    }
}

interface IChargeable
{
    void Charge();
    string GetInfo();
}

interface IFlyingRobot : IRobot
{
    string IRobot.GetRobotType()
    {
        return "I am a flying robot.";
    }
}


