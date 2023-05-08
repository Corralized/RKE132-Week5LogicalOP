
// AND - &&  , kontroll peab tagastama true väärtuse, kahe tingimusega true && true ---> true või false && ture ---> false
//mõlemad tingimused peavad olema täidetud


// OR ||  üks tingimustest peab olema täidetud  true || false --> true

Console.WriteLine("Enter the first letter of your first name:");
char userLetter = Char.Parse(Console.ReadLine().ToLower());

if (userLetter == 'a' || userLetter == 'e' || userLetter == 'i' || userLetter == 'o' || userLetter == 'u')
{
    Console.WriteLine("I can sing it.");
}
else
{
    Console.WriteLine("There is no way I can sing it.");
}