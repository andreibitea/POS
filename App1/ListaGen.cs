namespace App1
{
    class ListaGen<T>
    {
        private class Nod
        {
            public ListaGen<T>.Nod Next { get; set; }
            public T Data { get; set; }
            // constructor clasa interna Nod
            public Nod(T t)
            {
                Next = null;
                Data = t;
            }
        }

        public uint Count { get; set; }
        private ListaGen<T>.Nod Inceput { get; set; }
        // constructor
        public ListaGen()
        {
            Inceput = null;
            Count = 0;
        }
    }
}
