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
