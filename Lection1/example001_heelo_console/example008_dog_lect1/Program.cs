int count = 0;
double distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int Friend = 2;
double time = 0;
int MinDistance = 10;

while (distance > MinDistance)
{
    if (Friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count += 1;
}

Console.WriteLine("Dog will run {0} times", count);