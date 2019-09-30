namespace POO.Heranca_Composicao_Encapsulamento.Models
{
    public class CarroModel
    {
        public string marca{get;set;}
        public string modelo{get;set;}
        public string cor{get;set;}
        public string placa{get;set;}
        public bool ligado{get;set;}
        
        public MotorModel motor {get;set;}

    }
}