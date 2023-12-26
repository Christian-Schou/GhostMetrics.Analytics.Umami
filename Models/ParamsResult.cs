namespace UmamiNet.Models;

public class ParamsResult<T>
{
    public T Data { get; set; }
    public int Count { get; set; }
    public int PageSize { get; set; }
    public int Page { get; set; }
    public string OrderBy { get; set; }
}