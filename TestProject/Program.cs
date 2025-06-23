// 文字列の配列を用意。数値として解釈できるものとできないものが混在している
string[] values = ["12.3", "45", "ABC", "11", "DEF"];

// 数値に変換できなかった文字列を格納する変数
string message = "";
// 数値の合計を格納する変数
decimal total = 0;

// 配列の各要素を順に処理
foreach (var value in values)
{
    decimal number;
    // 文字列をdecimal型に変換できるか判定
    if (decimal.TryParse(value, out number))
    {
        // 変換できた場合は合計に加算
        total += number;
    }
    else
    {
        // 変換できなかった場合はmessageに追加
        message += value;
    }
}

// 数値に変換できなかった文字列と合計値を出力
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");