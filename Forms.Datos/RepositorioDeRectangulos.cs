using forms.Entidades;

namespace Forms.Datos
{
    public class RepositorioDeRectangulos
    {
        private readonly string _archivo = Environment.CurrentDirectory + "//Rectangulos.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "//Rectangulos.bak";

        private List<Rectangulo> listaRectangulo;
        public RepositorioDeRectangulos()
        {
            listaRectangulo = new List<Rectangulo>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            listaRectangulo.Clear();
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Rectangulo rectangulo = ConstruirRectangulo(lineaLeida);
                    listaRectangulo.Add(rectangulo);
                }
                lector.Close();
            }
        }
        public void Editar(Rectangulo rectanguloViejo, Rectangulo rectanguloEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Rectangulo rectangulo = ConstruirRectangulo(lineaLeida);
                        if (rectangulo.GetLadoA() == rectanguloViejo.GetLadoA() && rectangulo.GetLadoB() == rectanguloViejo.GetLadoB())
                        {
                            lineaLeida = ConstruirLinea(rectanguloEditar);
                            escritor.WriteLine(lineaLeida);

                        }
                        else
                        {
                            escritor.WriteLine(lineaLeida);

                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }
        private Rectangulo ConstruirRectangulo(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            int ladoA = int.Parse(campos[0]);
            int ladoB = int.Parse(campos[1]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[2]);
            ColorRelleno color = (ColorRelleno)int.Parse(campos[3]);
            Rectangulo r = new Rectangulo(ladoA, ladoB, borde, color);

            return r;
        }
        public void Agregar(Rectangulo rectangulo)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(rectangulo);
                escritor.WriteLine(lineaEscribir);
            }
            listaRectangulo.Add(rectangulo);
        }

        private string ConstruirLinea(Rectangulo rectangulo)
        {
            return $"{rectangulo.GetLadoA()}|" +
               $"{rectangulo.GetLadoB()}|" +
               $"{rectangulo.TipoDeBorde.GetHashCode()}|" +
               $"{rectangulo.TipoDeBorde.GetHashCode()}";
        }
        public int GetCantidad(int? valorFiltro = 0)
        {
            if (valorFiltro > 0)
            {
                return listaRectangulo.Count(c => c.LadoA > valorFiltro);
            }
            return listaRectangulo.Count();
        }
        public void Borrar(Rectangulo rectanguloBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Rectangulo trianguloLeido = ConstruirRectangulo(lineaLeida);
                        if (rectanguloBorrar.GetLadoA() != trianguloLeido.GetLadoA())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaRectangulo.Remove(rectanguloBorrar);
        }
        public List<Rectangulo> GetLista()
        {
            LeerDatos();
            return listaRectangulo;
        }
        public List<Rectangulo> Filtrar(int valorFiltro)
        {
            return listaRectangulo.Where(l => l.GetLadoA() >= valorFiltro).ToList();
        }

        public List<Rectangulo> OrdenarAscL1()
        {
            return listaRectangulo.OrderBy(l => l.GetLadoA()).ToList();
        }

        public List<Rectangulo> OrdenarDescL1()
        {
            return listaRectangulo.OrderByDescending(l => l.GetLadoA()).ToList();
        }

        public List<Rectangulo> OrdenarAscL2()
        {
            return listaRectangulo.OrderBy(l => l.GetLadoB()).ToList();
        }

        public List<Rectangulo> OrdenarDescL2()
        {
            return listaRectangulo.OrderByDescending(l => l.GetLadoB()).ToList();
        }
        public bool Existe(Rectangulo rectangulo)
        {
            listaRectangulo.Clear();
            LeerDatos();
            bool existe = false;
            foreach (var itemRectangulo in listaRectangulo)
            {
                if (itemRectangulo.GetLadoA() == rectangulo.GetLadoA() && itemRectangulo.GetLadoB() == rectangulo.GetLadoB())
                {
                    return true;
                }
            }
            return false;
        }
    }
}