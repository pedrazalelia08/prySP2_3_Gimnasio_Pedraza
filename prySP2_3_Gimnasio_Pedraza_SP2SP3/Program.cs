namespace prySP2_3_Gimnasio_Pedraza_SP2SP3;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmInscripcion());
    }
}
