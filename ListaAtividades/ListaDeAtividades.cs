using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();
            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.ID > 0)
            {
                textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.ID} - {atividadeEmAndamento.Titulo}";
            }

            var atividadesPendentes= atividade.ListaAtividadePendentes();  
            dataGridViewAtividades.DataSource = atividadesPendentes;   

        }
    }
}
