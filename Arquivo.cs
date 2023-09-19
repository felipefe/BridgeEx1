namespace Name
{
    public abstract class Arquivo
    {
        private IGeraArquivo iGerarArquivo;

        public Arquivo(IGeraArquivo iGerar)
        {
            iGerarArquivo = iGerar;
        }

        public void GravaArquivo()
        {
            iGerarArquivo.GerarArquivo();
        }

    }
}