namespace PoojaProject.Dto
{
    /// <summary>
    /// DTO for reading product (-s)
    /// </summary>

    public class Product
    {
        /// <summary>
        /// Product id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        /// <example>lime</example>
        public string Name { get; set; }

        public int Op1 { get; set; }

        public int Op2 { get; set; }

        public int Op3 { get; set; }
    }
}
