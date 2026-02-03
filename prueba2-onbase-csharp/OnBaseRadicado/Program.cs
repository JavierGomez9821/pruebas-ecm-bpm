using OnBase.Sdk.Simulado;

namespace OnBaseRadicado;

internal class Program
{
    static void Main(string[] args)
    {
        var app = new OnBaseApplicationSimulada();

        Console.WriteLine("Simulación de asignación de número de radicado en OnBase.");
        Console.WriteLine("Si ves este mensaje, el proyecto compiló y corrió correctamente.");

        // Aquí es donde el candidato luego implementará algo como:
        //
        // var servicio = new RadicadoService(app);
        // servicio.AsignarNumeroRadicado(1001);
        // servicio.AsignarNumeroRadicado(1002);
        // servicio.AsignarNumeroRadicado(1003);
    }
}
