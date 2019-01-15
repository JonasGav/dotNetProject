namespace dotNetProject
{
    public interface IRestClientCall
    {
        dynamic callApi(bool parameters = false, string parLong = null, string parLat = null);
    }
}