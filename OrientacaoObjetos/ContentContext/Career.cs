namespace OrientacaoObjetos.ContentContext
{
    public class Career: Content
    {
        
        public Career(string title, string url):base(title,url)
        {
            Items = new List<CareerItem>();
        }
        
        public IList<CareerItem> Items { get; set; }

        //Sempre uma contagem get.
        public int TotalCourses 
        => Items.Count;
        
    }
}