using Universiade01;

public class Program
{
    public static void Main()
    {
        Docente resp = new Titular(1, "Dra. Marta Silva", "Engenharia Informática");

        var uc = new UnidadeCurricular("POO101", "Programação Orientada a Objetos", resp);

        var e1 = new Estudante(10, "Ana Costa", "2024001");
        var e2 = new Estudante(11, "Bruno Reis", "2024002");

        uc.InscreverEstudante(e1);
        uc.InscreverEstudante(e2);

        // Pesos típicos: Teste 30%, Projecto 30%, Exame 40% (total 100%)
        uc.RegistarAvaliacao(e1, new Teste(16, 0.30));
        uc.RegistarAvaliacao(e1, new Projecto(18, 0.30));
        uc.RegistarAvaliacao(e1, new ExameFinal(15, 0.40));

        uc.RegistarAvaliacao(e2, new Teste(12, 0.30));
        uc.RegistarAvaliacao(e2, new Projecto(14, 0.30));
        uc.RegistarAvaliacao(e2, new ExameFinal(10, 0.40));

        Console.WriteLine(uc.EmitirPautaEmTexto());
    }
}