namespace Balta.ContentContext
{
    public abstract class ContextBase
    {
        public ContextBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}