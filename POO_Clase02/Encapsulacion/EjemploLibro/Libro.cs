namespace POO_Clase02.Encapsulacion.EjemploLibro
{
    public class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public bool Prestado { get; private set; }

        //private string Titulo;
        //private string Autor;
        //private bool Prestado;

        public Libro( string titulo, string autor )
        {
            Titulo = titulo;
            Autor = autor;
            Prestado = false;
        }

        //public string GetTitulo()
        //{
        //    if (true)
        //    {
        //        return Titulo;
        //    }
        //}

        //public string GetAutor()
        //{
        //    return Autor;
        //}

        //public bool GetPrestado()
        //{
        //    return Prestado;
        //}

        //public void SetTitulo( string titulo )
        //{
        //    Titulo = titulo;
        //}
    }
}
