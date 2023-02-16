namespace Sales.Shared.DTOs
{
    public class PaginationDTO
    {
        public int Pagina { get; set; } = 1;
        
        public int CantidadRegistros { get; set; } = 10;
    }
}
