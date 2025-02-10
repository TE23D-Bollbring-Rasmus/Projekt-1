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

Console.WriteLine(rummen[0]);
Console.WriteLine("När du fått 150 eller mer i varje stat kommer du till det sista rummet");

void story() {
    while (room < 4 && hp > 0 && energi > 0 && hunger > 0) {
        Console.WriteLine($"HP: {hp}, Hunger: {hunger}, Energi: {energi}");
        Console.WriteLine("Du är i startrummet. Åt vilket håll vill du gå? (vänster, höger, framåt)");
        string riktning = Console.ReadLine().ToLower();

        if (room == 0) {
            if (riktning == "vänster") {
                room = 1;
            } else if (riktning == "höger") {
                room = 2;
            } else if (riktning == "framåt") {
                room = 3;
            }
        }
        if (hp >= 150 && energi >= 150 && hunger >= 150) {
            room = 4;
        }

        // Anropa rätt händelsemetod baserat på vilket rum spelaren är i
        if (room == 1) {
            HändelseIRum1();
        } else if (room == 2) {
            HändelseIRum2();
        } else if (room == 3) {
            HändelseIRum3();
        } else if (room == 4) {
            HändelseIRum4();
        }
    }
}

// Metod för biblioteket
void HändelseIRum1() {
    Console.WriteLine($"{rummen[room]}");
    Console.WriteLine("Du hittar en gammal bok. Läser du den? (ja/nej)");
    if (Console.ReadLine().ToLower() == "ja") {
        Console.WriteLine("Boken förbättrar ditt sinne, men du blir trött.");
        energi -= 30;
    } else {
        Console.WriteLine("Boken gör en besvärjelse på dig och du blir hungrigare.");
        hunger -= 50;
    }
    room = 0;
}

// Metod för vapenkammaren
void HändelseIRum2() {
    Console.WriteLine($"{rummen[room]}");
    Console.WriteLine("Du ser ett svärd. Tar du upp det? (ja/nej)");
    if (Console.ReadLine().ToLower() == "ja") {
        Console.WriteLine("Svärdet är tungt, men du känner dig starkare.");
        hp += 30;
    } else {
        Console.WriteLine("Du blir allierad med svärdet som ger dig mat.");
        hunger += 30;
    }
    room = 0;
}

// Metod för fängelsehålan
void HändelseIRum3() {
    Console.WriteLine($"{rummen[room]}");
    Console.WriteLine("Du hör någon viska. Undersöker du? (ja/nej)");
    if (Console.ReadLine().ToLower() == "ja") {
        Console.WriteLine("En skugga attackerar dig!");
        hp -= 45;
    } else {
        Console.WriteLine("Du undviker skuggan och vilar, du får mer energi.");
        energi += 25;
    }
    room = 0;
}

// Metod för kungens sal
void HändelseIRum4() {
    Console.WriteLine($"{rummen[room]}");
    Console.WriteLine("Väljer du att gå i en allians med honom eller trotsar du honom och hans kungarike? (allians/trotsa)");
    if (Console.ReadLine().ToLower() == "allians") {
        Console.WriteLine("Du och kungen blir allierade och ni väljer att ta över riket tillsammans (se del 2).");
    } else {
        Console.WriteLine("Du väljer att trotsa kungen och därmed måste du bygga ett eget imperium för att ta över riket. (se del 2).");
    }
}

story();
Console.WriteLine("Spelet är slut.");
Console.ReadLine();

