namespace GameTop.Lib
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Emanuel")
        {
            _Nome = nome;
        }
        
        //Chutar
        public string Chuta()
        {
            return $"{_Nome} Esta Chutando \n";
        }

        //Correr
        public string Corre()
        {
            return $"{_Nome} Esta Correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} Esta Passando \n";
        }
    }
}