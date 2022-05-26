namespace DPMidTerm.DesignPattern
{
    public class PeachTeaBuilder : DrinkBuilder
    {
        public override void addTea()
        {
            _orderItem.ProductId = 2;
        }
    }
}