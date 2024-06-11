namespace CursoNelioAula1410.Entities
{
    internal class OutsourceEmployee : Employee    
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee
        {
        }



        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
              
        }
    }
}
