using NetCore.DesignPattern.FactoriesPattern.AbstractFactory.Interface;

namespace NetCore.DesignPattern.FactoriesPattern.AbstractFactory
{
    public class Application
    {
        private GUIFactory factory;
        private Button button;

        public Application(GUIFactory _factory)
        {
            this.factory = _factory;
        }

        void createUI()
        {
            this.button = this.factory.createButton();
        }

        void paint()
        {
            button.paint();
        }
    }
}
