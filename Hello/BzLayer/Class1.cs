using Entity;
using DataLayer;
namespace BzLayer;
public class Class1
{
public List<Movie> GetMovies(){
    DataAccess dataAccess = new DataAccess();
    return dataAccess.GetMovies();
}
}
