namespace A_Sample_API_In_DotNetCore.DataTransferObject
{
    public interface ICatalogueItem
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}