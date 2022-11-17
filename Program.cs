using System;

Main();



void Main()
{
    
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    bool isActive = true;
    while(isActive) {
    // Let the moose speak!
        MooseSays("Please ask a question: ");
        string userQuestion = Console.ReadLine();
        if(userQuestion == "") {
            isActive = false;
            return;
        }
        questionResponse(userQuestion);



    }

}

void questionResponse(string question) {
    string[] answers = {"As I see it, yes", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "It is certain", "It is decidedly so"};
    Random r = new Random();
    int selectNum = r.Next(0, answers.Length);
    string answer = answers[selectNum];
    MooseSays(answer);
}


void askQuestion(string question, string yesResponse, string noResponse)
{
    bool isTrue = MooseAsks($"{question}");
    if (isTrue)
    {
        MooseSays($"{yesResponse}");
    }
    else
    {
        MooseSays($"{noResponse}");
    }
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
};