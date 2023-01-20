// 6 знаков билетик: сумма первых трех равна сумме трех последних
// На входе 6 число, на выходе проверка счастливый или нет


using static System.Console;
Clear();

Write("Input any number ticket number(check for luckyness):");
string ticket = ReadLine();
if (CheckTicket(ticket))
{
    WriteLine("Lucky ticket");
}
else
{
    WriteLine("Not Lucky ticket");
}

bool CheckTicket(string ticket)
{
    int[] ticket_int = new int[ticket.Length];
    for (int i = 0; i < ticket.Length; i++)
    {
        ticket_int[i] = Convert.ToInt32(ticket[i]);  // return ascii code for numbers. Can compare it same as numbers;
        //WriteLine($"ticket{i}({ticket[i]}) = {ticket_int[i]}");
    }
    
    int summ1 = 0;
    int summ2 = 0;
    for (int i = 0; i < ticket.Length/2; i++)
    {
        summ1 += ticket_int[i];
        summ2 += ticket_int[ticket.Length - i-1];
        //WriteLine($"debug: {summ1} += {ticket_int[i]}:  {summ2} += {ticket_int[ticket.Length - i-1] }");
    }
    if (summ1 == summ2)
    { 
        return true;
    }
    else 
    { 
        return false;
    }
}


// bool CheckTicket(string ticket)
// {
//     int[] ticket_int = new int[6];
//     for (int i = 0; i < 6; i++)
//     {
//         ticket_int[i] = Convert.ToInt32(ticket[i]);  // return ascii code for numbers. Can compare it same as numbers;
//         //WriteLine($"ticket{i}({ticket[i]}) = {ticket_int[i]}");
//     }
//     if (ticket[0] + ticket[1] + ticket[2] == ticket[3] + ticket[4] + ticket[5])
//     { 
//         return true;
//     }
//     else 
//     { 
//         return false;
//     }
// }
