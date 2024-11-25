namespace DemoConcurrencia
{
    public sealed class Singleton
    {
        public static Singleton Instancia = null;
        private static readonly object bloqueo = new object();

        public string cadenaConexion;
        public Singleton()
        {
            cadenaConexion = "";
        }
        public static Singleton Instance
        {
            get
            {
                lock (bloqueo)
                {
                    if (Instancia == null)
                    {
                        Instancia = new Singleton();
                    }
                    return Instancia;
                }
            }
        }
    }
}

