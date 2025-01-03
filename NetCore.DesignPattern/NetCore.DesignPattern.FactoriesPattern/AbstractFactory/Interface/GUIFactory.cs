using NetCore.DesignPattern.FactoriesPattern.Logitic_FacetoryMethod;

namespace NetCore.DesignPattern.FactoriesPattern.AbstractFactory.Interface
{
    public interface GUIFactory
    {
        Button createButton();
        Checkbox createCheckbox();
    }
}
