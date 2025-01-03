using NetCore.DesignPattern.FactoriesPattern.AbstractFactory.Interface;

namespace NetCore.DesignPattern.FactoriesPattern.AbstractFactory
{
    public class MacFactory : GUIFactory
    {
        public Button createButton()
        {
            return new MacButton();
        }

        public Checkbox createCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
