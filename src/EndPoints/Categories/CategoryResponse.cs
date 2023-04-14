namespace IWantApp.EndPoints.Categories;

internal class CategoryResponse
{
    public string Name { get; set; }
    public bool Active { get; set; }
    public Guid Id { get; internal set; }
}