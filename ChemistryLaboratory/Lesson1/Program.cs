Console.WriteLine("Please enter the max number of substances on the shelf:");


string N = Console.ReadLine();
int MAX = int.Parse(N);


int cnt_of_substance = 0;

while(true)
{

    string com = Console.ReadLine();    
    if (com == "add")
    {
        if(cnt_of_substance < MAX) 
            cnt_of_substance++;
        else
            Console.WriteLine("Number of substances on the shelf is max.");
    }
    else if (com == "div")
    {
        if (cnt_of_substance > 0)
            cnt_of_substance--;
        else
            Console.WriteLine("Error");

    }
    else
        Console.WriteLine("Your command is incorrect.");
    Console.WriteLine(cnt_of_substance);
}