namespace ProductManager.Models;

public class Productos
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public DateTime FechaCreacion { get; set; }
    public required string Estado { get; set; }
}
