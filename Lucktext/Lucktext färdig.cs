using System;

string name = "";
string favoritkaraktär = "";
string favoritserie = "";

Console.WriteLine("Skriv ditt namn");
name = Console.ReadLine();


Console.WriteLine("Skriv in din favorit animekaraktär");
favoritkaraktär = Console.ReadLine();

Console.WriteLine("Skriv in din favorit anime");
favoritserie = Console.ReadLine();



Console.WriteLine($"Ey {name}, tänk att ha ett lika litet liv som dig som kollar på anime, speciellt om du kollar på {favoritserie}");
Console.WriteLine($"Du tror säkert till och med att {favoritkaraktär} finns på riktigt");


Console.WriteLine("Du borde dra och röra gräs");
Console.ReadLine();