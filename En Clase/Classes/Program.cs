public class Operaciones{
    private int Valor1 { get; set; }

    private int Valor2 { get; set; }

    public Operaciones( int Valor1, int Valor2 ){
        this.Valor1 = Valor1;
        this.Valor2 = Valor2;
    }

        public int Sumar(){
            return Valor1 + Valor2;
        }

        public int Restar(){
            return Valor1 - Valor2;
        }

        public int Multiplicar(){
            return Valor1 * Valor2;
        }

        public int Dividir(){
            return Valor1 / Valor2;
        }
}