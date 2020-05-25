namespace Exercicio_19
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void incrementarSalario(double porcentagem)
        {
            Salario *= porcentagem;
        }
    }
}
