namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Peojeto web - LH Pets versão 1");

        app.useStaticFiles();
        app.MapGet("/index",(httpContext contexto)=> {
                contexto.response.redirect("index.html",false);

        });
        banco dba=new banco();
        app.Mapget("/listaclientes", (httpConstext contexto) =>{

            constexto.response.writeAsync(dba.GetListaString());
        });
        
        app.Run();
    }
}
