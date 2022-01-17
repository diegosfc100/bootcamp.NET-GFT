namespace revisao
{
    public struct Aluno
    {
        public string nome { get; set; }

        public decimal nota { get; set; }


        public Aluno(string nome, decimal nota){
            this.nome = nome;
            this.nota = nota;
        }

    }
}