using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext
{
    //Deriva mas não implementa um novo.
    public abstract class Content : Base
    {
        //Construtor - ctor
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        //Propriedades/Atributos - prop
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Url { get; set; }

    }
}