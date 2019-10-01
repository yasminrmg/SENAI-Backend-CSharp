using ex2.Model;
using System;

namespace ex2.Controller
{
    public class CelularController
    {
        CelularModel celular = new CelularModel();

        public void novoCelular(){
            try{
                System.Console.WriteLine("Informe a cor do celular");
                celular.cor = Console.ReadLine();
                
                System.Console.WriteLine("Modelo: ");
                celular.modelo = Console.ReadLine();

                System.Console.WriteLine("Tamanho: ");
                celular.tamanho = double.Parse(Console.ReadLine());
            }catch(Exception ex){
                System.Console.WriteLine("Ops... Houve um problema. Tente novamente mais tarde");
                System.Console.WriteLine(ex.Message);
            }
        }

        public void statusCelular(){
            System.Console.WriteLine();
            System.Console.WriteLine("Cor: "+celular.cor);
            System.Console.WriteLine("Modelo: "+celular.modelo);
            System.Console.WriteLine("Tamanho: "+celular.tamanho);
            System.Console.WriteLine("Esta ligado: "+celular.ligado);
            System.Console.WriteLine();
        }

        public void ligarCelular(){
            try{
                if(!celular.ligado){
                    celular.ligado = true;
                }
            }catch(Exception ex){
                System.Console.WriteLine("Ops... Houve um problema. Tente novamente mais tarde");
                System.Console.WriteLine(ex.Message);
            }
        }
        public void desligarCelular(){
            try{
                if(celular.ligado){
                    celular.ligado = false;
                }
            }catch(Exception ex){
                System.Console.WriteLine("Ops... Houve um problema. Tente novamente mais tarde");
                System.Console.WriteLine(ex.Message);
            }
        }

        public void enviaMensagem(){
            try{
                if(celular.ligado){
                    System.Console.WriteLine("Mensagem esta sendo enviada...");
                }else{
                    System.Console.WriteLine("Impossivel enviar mensagem. O celular esta desligado");
                }
            }catch(Exception ex){
                System.Console.WriteLine("Ops... Houve um problema. Tente novamente mais tarde");
                System.Console.WriteLine(ex.Message);
            }
        }

        public void realizarLigacao(){
            try{
                if(celular.ligado){
                    System.Console.WriteLine("Realizando ligação...");
                }else{
                    System.Console.WriteLine("Impossível. Ligue o celular!");
                }
            }catch(Exception ex){
                System.Console.WriteLine("Ops... Houve um problema. Tente novamente mais tarde");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}