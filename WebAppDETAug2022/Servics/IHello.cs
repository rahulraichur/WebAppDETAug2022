namespace WebAppDETAug2022.Servics
{
    public interface IHello
    {
        string SayHello(string name);
    }
    public class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello {name}, Welcome";
        }
    }
    public class Hello2 : IHello
    {
        public string SayHello(string name)
        {
            return $"Halo {name}, Wilkomen";
        }
    }

}
