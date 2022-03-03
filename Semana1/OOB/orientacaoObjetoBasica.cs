namespace semana1gh
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sobre classes, herança, métodos.
            // O que é uma classe abstrata e o que é uma interface?
            // quando devemos usar um ou outro?
            
/*          Classe
            Classe é um modelo de um objeto do mundo real. É o bloco de construção básico da programação orientada a objetos e é reutilizável.
            Uma classe C# define propriedades, campos, eventos, métodos, etc. Um objeto é uma instância de uma classe.
            Modificadores de acesso definem a acessibilidade de uma classe: public, private, protected ou internal.
            Um Namespace pode incluir uma ou mais classes.
*/

/*          Herança
            Herança é um recurso das linguagens de programação orientadas a objeto que permite a definição de uma classe base que, por sua 
            vez, fornece uma funcionalidade específica (dados e comportamento), e a definição de classes derivadas que herdam ou substituem 
            essa funcionalidade.
*/

/*          Métodos
            Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o 
            método e especificando os argumentos de método necessários. No C#, todas as instruções executadas são realizadas no contexto de um método. 
            O método Main é o ponto de entrada para todos os aplicativos C# e é chamado pelo CLR (Common Language Runtime) quando o programa 
            é iniciado.
*/

/*
            Classe abstrata
            É um tipo de classe que somente pode ser herdada e não instanciada. De certa forma, pode-­se dizer que este tipo de classe é uma 
            classe conceitual que pode definir funcionalidades para que as suas subclasses possam implementá-­las. O conjunto de métodos na 
            classe abstrata é obrigatoriedade, assim como a implementação nas suas subclasses. Em uma classe abstrata, os métodos declarados 
            podem ser abstratos ou não, e suas implementações devem ser obrigatórias na subclasse.

            Interface
            Define as operações que um objeto será obrigado a implementar. É importante lembrar que uma interface nunca contém implementação, 
            ou seja, numa interface não se pode definir campos, pois os mesmos são uma implementação de um atributo objeto. A interface também 
            não permite construtores, pois num construtor temos as instruções usadas para inicializar campos. Para podermos usar uma interface, 
            devemos criar uma classe ou estrutura e herdar da interface. Com isso, é obrigatório implementar todos os métodos da interface.

            Conclusão
            Uma classe abstrata pode conter métodos completos ou incompletos. Uma Interface pode conter apenas a assinatura de um método, mas 
            nenhum corpo ou implementação. Portanto, em uma classe abstrata, pode-­se implementar métodos, mas em uma Interface, não. Uma classe 
            abstrata pode conter campos, construtores, ou destrutores e aplicar propriedades. Uma interface não pode conter campos, construtores, 
            ou destrutores. Pode possuir apenas a propriedade da assinatura, mas não a implementação. Uma classe abstrata não suporta múltiplas 
            herança. Assim, uma classe pode implementar várias interfaces, mas apenas herdar de uma classe abstrata. Uma classe que implementa 
            uma interface tem obrigatoriamente que implementar todos os métodos desta, mas o mesmo não é exigido no caso de uma classe abstrata. 
            As classes abstratas são mais rápidas que as interfaces.
            
            (quando devemos usar um ou outro?)
*/
        }
    }
}