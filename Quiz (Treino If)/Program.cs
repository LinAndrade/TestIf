using System.Security.AccessControl;

int pontuacao = 0;
Console.WriteLine("Qual autor criou o Absurdismo?");
string resposta = Console.ReadLine();
if (resposta.ToLower() == "Albert Camus".ToLower())
{
    pontuacao++;
    Console.WriteLine("Resposta correta! Sua pontuação agora é:");
    Console.WriteLine(pontuacao);
}
else
{
    Console.WriteLine("Resposta errada.");
    Console.WriteLine("Seus pontos foram:");
    Console.WriteLine(pontuacao);
    return;
}
Console.WriteLine("Qual a outra ocupação que Camus teve?");
resposta = Console.ReadLine();
if (resposta.ToLower() == "Jornalista".ToLower())
{
    pontuacao++;
    Console.WriteLine("Você está indo bem! Sua pontuação agora é:");
    Console.WriteLine(pontuacao);
}
else
{
    Console.WriteLine("Resposta errada.");
    Console.WriteLine("Seus pontos foram:");
    Console.WriteLine(pontuacao);
    return;
}
Console.WriteLine("Qual o livro romancista mais famoso de Camus?");
resposta = Console.ReadLine();
if (resposta.ToLower() == "O Estrangeiro".ToLower())
{
    pontuacao++;
    Console.WriteLine("Mais um acerto! Sua pontuação agora é:");
    Console.WriteLine(pontuacao);
}
else
{
    Console.WriteLine("Resposta errada.");
    Console.WriteLine("Seus pontos foram:");
    Console.WriteLine(pontuacao);
    return;
}
Console.WriteLine("Qual o livro filosofico mais famoso de Camus?");
resposta = Console.ReadLine();
if (resposta.ToLower() == "O Mito de Sísifo".ToLower())
{
    pontuacao++;
    Console.WriteLine("Você é brilhante! Sua pontuação agora é:");
    Console.WriteLine(pontuacao);
}
else
{
    Console.WriteLine("Resposta errada.");
    Console.WriteLine("Seus pontos foram:");
    Console.WriteLine(pontuacao);
    return;
}
if (pontuacao == 4)
{ 
    Console.WriteLine("Parabéns você é um verdadeiro absurdista!");
}