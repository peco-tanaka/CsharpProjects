Console.WriteLine("5から10までの整数を入力してください。");

int number;
while (true)
{
    // 入力を取得
    string? input = Console.ReadLine();

    // 入力が整数かどうかを判定
    if (int.TryParse(input, out number))
    {
        // 5から10の範囲かどうかを判定
        if (number >= 5 && number <= 10)
        {
            break; // 条件を満たしたらループ終了
        }
        else
        {
            // 範囲外の場合
            Console.WriteLine("5から10までの整数を入力してください。");
        }
    }
    else
    {
        // 数値以外の入力の場合
        Console.WriteLine("数値を入力してください。");
    }
}

// 入力値が受け入れられたことを通知
Console.WriteLine($"入力値 {number} は受け入れられました。");

