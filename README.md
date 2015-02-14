# Série de artigos "Hello ASP.NET/5"

```csharp
public class Artigo
{
    public string Autor { get; set; }
    public string Canal { get; set; }
    public DateTime Data { get; set; }
    
    public static void Main()
    {
        new Artigo()
        {
            Autor = "Erlimar Silva Campos",
            Canal = "http://erlimar.wordpress.com",
            Data = new DateTime(2015, 2, 13)
        };
    }
}
```

Este repositório contém o código fonte construído na série de artigos sobre ASP.NET/5 (acesse a série [clicando aqui](http://goo.gl/ocH82S)), além de materiais e outras informações complementares.

## Tópicos

1. Introdução
2. Preparando o ambiente
3. Peças fundamentais de um projeto
4. Um projeto web, OWIN e o Startup
5. MVC, Controllers
6. MVC, Views
7. MVC, Models
8. Injeção de dependências
9. Organização do código fonte, Básico
10. Organização do código fonte, Componentes
11. Organização do código fonte, Produtos
12. Runtime, CLR e CoreCLR
13. Project.JSON, Dependências
14. Project.JSON, Diretivas
15. Project.JSON, Comandos
16. Empacotando componentes e publicando no NuGet.org
17. Boas práticas, Code Standards e Extensão de métodos
18. No Visual Studio
19. Middleware
20. Recursos
21. Deploy

## Encontrando o material correto

A série de artigos pretende construir um conteúdo, que vai evoluindo de acordo com que os tópicos são apresentados, de forma que este repositório conterá o conteúdo final.

Mas você poderá encontrar uma [TAG](https://github.com/e5r-learning/serie-helloaspnet5/tags) correspondente a cada tópico relevante nos artigos, assim você poderá obter o material exatamente como estava na época que foi apresentado.
