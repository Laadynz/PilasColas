namespace Arreglos
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;

        public Pilas(int tamaño) 
        {
            this.array = new string[tamaño];
            this.tope = 0;
            this.max = array.Length - 1;

        }

    }
}