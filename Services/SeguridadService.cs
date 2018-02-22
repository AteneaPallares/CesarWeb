namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            clave=clave*(-1);
            if(clave>26){
                clave=clave%27;
                }
            if(clave<-26){
                clave=clave%27;
            }
            int i=0,h=0;
            string palabra=Mensaje;
            char[] comparacion = new char[Mensaje.Length];
            for(int x=0;x<Mensaje.Length;x++){
                    comparacion[x]=Mensaje[x];
                }
            for(i=0;i<Mensaje.Length;i++){
                for(int f=0;f<2;f++){
                    if(f==0){
                        ABECEDARIO=ABECEDARIO.ToUpper();
                    }
                    if(f==1){
                        ABECEDARIO=ABECEDARIO.ToLower();
                    }
                for(h=0;h<=26;h++){
                    if(palabra[i]==ABECEDARIO[h]){
                        if(h+clave>26){

                            
                            int x=clave;
                            int res=26-h;
                            x=clave-res-1;
                            comparacion[i]=ABECEDARIO[x];
                        }
                        if(h+clave>0 && h+clave<=26){
                            comparacion[i]=ABECEDARIO[h+clave];
                        }
                        if(h+clave==0){
                            comparacion[i]=ABECEDARIO[0];
                        }
                        if(h+clave<0){
                            int re=h+clave;
                            int solucion=27+re;
                            comparacion[i]=ABECEDARIO[solucion];
                        }
                    }  
                }}
                }
             string codigo=new string(comparacion);
             
            Mensaje=codigo;
            
            return Mensaje;
        }

        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje

        public string Encriptar(string Mensaje, int clave)
        {
            if(clave>26){
                clave=clave%27;
                }
            if(clave<-26){
                clave=clave%27;
            }
            int i=0,h=0;
            string palabra=Mensaje;
            char[] comparacion = new char[Mensaje.Length];
            for(int x=0;x<Mensaje.Length;x++){
                    comparacion[x]=Mensaje[x];
                }
            for(i=0;i<Mensaje.Length;i++){
                for(int f=0;f<2;f++){
                    if(f==0){
                        ABECEDARIO=ABECEDARIO.ToUpper();
                    }
                    if(f==1){
                        ABECEDARIO=ABECEDARIO.ToLower();
                    }
                for(h=0;h<=26;h++){
                    if(palabra[i]==ABECEDARIO[h]){
                        if(h+clave>26){

                            
                            int x=clave;
                            int res=26-h;
                            x=clave-res-1;
                            comparacion[i]=ABECEDARIO[x];
                        }
                        if(h+clave>0 && h+clave<=26){
                            comparacion[i]=ABECEDARIO[h+clave];
                        }
                        if(h+clave==0){
                            comparacion[i]=ABECEDARIO[0];
                        }
                        if(h+clave<0){
                            int re=h+clave;
                            int solucion=27+re;
                            comparacion[i]=ABECEDARIO[solucion];
                        }
                    }  
                }}
                }
             string resultado=new string(comparacion);
            Mensaje=resultado;
            return Mensaje;
        
        }
    }


}