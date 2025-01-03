using NetCore.DesignPattern.FactoriesPattern.AbstractFactory.Interface;

namespace NetCore.DesignPattern.FactoriesPattern.AbstractFactory
{
    public class ApplicationConfigurator
    {
        static void Main(string[] args)
        {
            var config = new ReadApplicationConfigFile();
            GUIFactory factory;

            if (config.Os == "Windows")
            {
                factory = new WinFactory();
            } else if (config.Os == "Mac")
            {
                factory = new MacFactory();
            } else
            {
                throw new Exception("Error! Unknown operating system.");
            }

            Application app = new Application(factory);
        }

        //https://refactoring.guru/design-patterns/abstract-factory
    }
}
