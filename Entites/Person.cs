

namespace TestMinimal.Entites
{

    /// Representa una persona con un identificador, nombre y edad.
    public class Person
    {
        /// Identificador Unico de la persona 
        public int Id { get; set; }
        /// Nombre de la persona
        public required string Name { get; set; }
        /// Apellido de la persona
        public required string LastName { get; set; }
        /// Edad de la persona
        public int Age { get; set; }
    }
}