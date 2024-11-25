namespace DemoConcurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void BtnIniciarSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial ya...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                ActualizarResultado($" no Actividad - paso  todavia{i + 1}");
            }
            ActualizarResultado("Fin del proceso secuencial Si...");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now: HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }

        private void BtnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread Hilo1 = new Thread(() =>
            {
                try
                {

                    ActualizarResultado($"Iniciar nuevo thread{Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(1000);
                        ActualizarResultado($"Actividad en hilo {Thread.CurrentThread.ManagedThreadId}- paso {i + 1}");
                    }
                    ActualizarResultado($"thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (Exception)
                {
                    ActualizarResultado("Hilo canselado");
                }

            });
            Hilo1.Start();
        }

        private async void BtnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
             {
                 try
                 {
                     ActualizarResultado($"Iniciando task {Task.CurrentId}...");
                     for (int i = 0; i < 5; i++)
                     {
                         token.ThrowIfCancellationRequested();
                         Thread.Sleep(1000);
                         ActualizarResultado($" Actividad en tarea {Task.CurrentId} - Paso {i + 1}");
                     }
                     ActualizarResultado($"Task {Task.CurrentId} completada.");
                 }
                 catch (OperationCanceledException)
                 {
                     ActualizarResultado("Tarea canselado");
                 }
             });
        }

        private void BtnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void FrmConcurrencia_Load(object sender, EventArgs e)
        {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

