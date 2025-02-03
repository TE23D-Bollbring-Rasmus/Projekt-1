int hp = 100;
int hunger = 100;
int energi = 100;

int room = 0;

string[] roomDescriptions = {"Du har precis vaknat på en äng", "You are in the engine room"};
Console.WriteLine("Du vaknar upp i ett gammalt, övergivet slott. Väggarna är täckta av damm och spindelnät, och en svag vind ekar genom korridorerna. Framför dig finns fyra dörrar, var och en leder till ett annat rum. Ditt öde beror på vilket rum du väljer att utforska.");
while (room != 4) {
Console.WriteLine(roomDescriptions[room]);
Console.WriteLine("Åt vilket håll vill du gå?");
string riktning = Console.ReadLine();

if (room == 0) {
if (riktning == "vänster") {
room = 1;
} else if (riktning == "höger"){
room = 2;
}
 else if (riktning == "framåt"){
room = 3;
}
 else if (riktning == "bakåt"){
room = 4;
}
}
}
Console.WriteLine(roomDescriptions[room]);
Console.ReadLine();