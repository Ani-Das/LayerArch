// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;

MovieBz bz = new MovieBz();
List<Movie> movie = bz.GetMovies();
if(movie!= null){
    foreach(var m in movie){
        Console.WriteLine($"{m.Id} {m.Name} {m.Ratings} {m.Ryear}");
    }
}
else{
    {
        Console.WriteLine("No Movies Present!");
    }
}

