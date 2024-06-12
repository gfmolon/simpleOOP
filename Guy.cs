namespace TesteOOP
{

    public class Guy
    {
        public string? name;
        public int cash;

        public void GiveCash(int amount, Guy guyToGiveMoney)
        {
            if (amount >= cash)
            {
                Console.WriteLine("Você não tem grana.");
            }
            else
            {
                cash -= amount;
                guyToGiveMoney.cash += amount;
            }
        }


        public static void mostrarLista(List<Guy> listaUsuarios)
        {
            foreach (Guy usuario in listaUsuarios)
            {
                Console.WriteLine(usuario.name);
                Console.WriteLine(usuario.cash);
            }
        }

        public static void temGrana(Guy nomeUsuario)
        {
            if (nomeUsuario.cash > 0)
            {
                Console.WriteLine("Tem grana");
            }
        }

    }
}
