
namespace DPMidTerm.DesignPattern
{
    public class OlongBuilder : DrinkBuilder
    {
        public override void addTea()
        {
            _orderItem.ProductId = 1;
        }
    }
}