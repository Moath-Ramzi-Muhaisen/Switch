// Switch
//Moath Ramzi
//meme
Console.WriteLine("Plesae Enter number 1 :");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Plesae Enter number 2 :");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Plesae Enter opretor :");
char @opretor = Convert.ToChar(Console.ReadLine());
int sum = 0;

switch (@opretor)
{
    case  '+' : 
        sum = num_1 + num_2;
        break;

    case '-' :
        sum = num_1 - num_2;
        break;

    case '*' :
        sum = num_1 * num_2;
        break;

    case '/' :
        sum = num_1 / num_2;
        break;

     default :
        Console.WriteLine("Invalid Input");
        break;
}
Console.WriteLine($"The Result of {num_1} {@opretor} {num_2} = {sum}");
