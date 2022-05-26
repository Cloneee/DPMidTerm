namespace DPMidTerm.DesignPattern
{
    public class MatchaBuilder : DrinkBuilder
    {
        public override void addTea()
        {
            _orderItem.ProductId = 3;
        }
    }
}