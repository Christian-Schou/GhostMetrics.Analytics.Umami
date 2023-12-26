namespace UmamiNet.Models;

public class SearchParams
{
    public string Query { get; set; }
    public int? Page { get; set; }
    public int? PageSize { get; set; }
    public string OrderBy { get; set; }
    public bool? SortDescending { get; set; }
}