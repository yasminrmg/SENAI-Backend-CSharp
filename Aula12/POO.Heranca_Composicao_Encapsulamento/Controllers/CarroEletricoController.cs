using POO.Heranca_Composicao_Encapsulamento.Models;

namespace POO.Heranca_Composicao_Encapsulamento.Controllers
{
    public class CarroEletricoController : CarroController
    {
        CarroEletricoModel carroEletrico = new CarroEletricoModel();
        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga){
            if(carroEletrico.bateria < 100){
                carroEletrico.bateria += carga;
            }else{
                System.Console.WriteLine("A bateria já esta completa! Pode viajar!");
            }
        }
        public float statusBateria(){
            return carroEletrico.bateria;
        }        
    }
}