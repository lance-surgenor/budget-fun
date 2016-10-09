namespace Tegdub.Infrastructure
{
    public class Entity<TId>
    {
        private TId _id;

        public TId Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                IsNew = true;
            }
        }

        public bool IsNew { get; private set; }
    }
}
