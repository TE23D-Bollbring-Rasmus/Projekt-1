int hp = 100;
int hunger = 100;
int energi = 100;

int room = 0;

string[] rummen = {
    "Du vaknar upp i ett gammalt, övergivet slott. Väggarna är täckta av damm och spindelnät, och en svag vind ekar genom korridorerna. Framför dig finns fyra olika håll du kan gå, var och en leder till ett annat rum. Ditt öde beror på vilket rum du väljer att utforska.", 
    "Du går in i ett gammalt bibliotek. Böckerna är täckta av damm, och det känns som att någon viskar mellan hyllorna.",
    "Du befinner dig i en vapenkammare full av rostiga svärd och tunga rustningar.",
    "Du står i en mörk fängelsehåla. Kalla kedjor hänger från väggarna.",
    "Du når en stor sal där en skuggig kung väntar vid sitt bord."
};

void story() {
    while (room != 4) {
        Console.WriteLine(rummen[room]);
        Console.WriteLine($"HP: {hp}, Hunger: {hunger}, Energi: {energi}");
        Console.WriteLine("Åt vilket håll vill du gå? (vänster, höger, framåt, bakåt)");
        string riktning = Console.ReadLine().ToLower();

        if (room == 0) {
            if (riktning == "vänster") {
                room = 1;
            } else if (riktning == "höger") {
                room = 2;
            } else if (riktning == "framåt") {
                room = 3;
            } else if (riktning == "bakåt") {
                room = 4;
            }
        }

        HändelseIRum();
    }
}

void HändelseIRum() {
    if (room == 1) {
        Console.WriteLine("Du hittar en gammal bok. Läser du den? (ja/nej)");
        if (Console.ReadLine().ToLower() == "ja") {
            Console.WriteLine("Boken förbättrar ditt sinne, men du blir trött.");
            energi -= 10;
            room = 0;
        }
    }
    else if (room == 2) {
        Console.WriteLine("Du ser ett svärd. Tar du upp det? (ja/nej)");
        if (Console.ReadLine().ToLower() == "ja") {
            Console.WriteLine("Svärdet är tungt, men du känner dig starkare.");
            hp += 10;
            room = 0;
        }
    }
    else if (room == 3) {
        Console.WriteLine("Du hör någon viska. Undersöker du? (ja/nej)");
        if (Console.ReadLine().ToLower() == "ja") {
            Console.WriteLine("En skugga attackerar dig!");
            hp -= 15;
            room = 0;
        }
    }
    else if (room == 4){
        hp -= 100;
        hunger -= 100;
        energi -= 100;
    }
    if (energi == 0 || hp == 0|| energi == 0){
        Console.WriteLine("Du dog");
    }
}

story();
Console.WriteLine("Spelet är slut.");
Console.ReadLine();
