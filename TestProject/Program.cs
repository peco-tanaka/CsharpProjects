Console.WriteLine("ロール名を入力してください（管理者・マネージャー・ユーザー）：");

string? input;
string[] roles = { "管理者", "マネージャー", "ユーザー" };
bool isValid = false;
do
{
    input = Console.ReadLine()?.Trim();
    if (input != null && Array.Exists(roles, role => role == input))
    {
        isValid = true;
    }
    else
    {
        Console.WriteLine("正しいロール名（管理者・マネージャー・ユーザー）を入力してください。");
    }
} while (!isValid);

Console.WriteLine($"入力値『{input}』は受け入れられました。");

/* 模範解答例
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine(); */