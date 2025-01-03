using NetCore.DesignPattern.FactoriesPattern.AbstractFactory.Interface;

namespace NetCore.DesignPattern.FactoriesPattern.AbstractFactory
{
    public class WinFactory : GUIFactory
    {
        public Button createButton()
        {
            return new WinButton();
        }

        public Checkbox createCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
