using ListaAtividades.Repositorio;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()
        {
            if (!ValidarTitulo())
            {
                return false;

            }
            repositorio.criar(Titulo);
            return true;
        }
         public bool AtualiizarSituacao()
        {
            if (ValidarId())
            { 
                return false;    
        
            }
            if(ValidarSituacao())
            {
                return false;
            }
            Atividade atividadeemAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if(atividadeemAndamento.ID>0 && atividadeemAndamento.Situacao == novaSituacao)
            {
                return false;   
            }
            repositorio.AtualizarSituacao(ID,(int)novaSituacao);
            return true;
        }
        public Atividade BuscarAtividadeEmAndamento()
        {
            return repositorio.buscarAtividadeEmAndament();
        }

        public List<Atividade> ListaAtividadePendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }

            public bool ValidarId()
        {
            return ID > 0;
        }

        private bool ValidarTitulo()
        {
            return
        }
        public bool validarSituacao();

        private Situacao BuscarProximaSituacao();

            

        
    }


}
