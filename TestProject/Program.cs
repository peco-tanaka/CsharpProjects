// 文字列を逆順に並べ替え、カンマ区切りで表示するサンプルコード

// 元の文字列を定義
string value = "abc123";

// 文字列を1文字ずつの配列に変換
char[] valueArray = value.ToCharArray();

// 配列を逆順に並べ替え
Array.Reverse(valueArray);

/*
// 逆順にした配列から新しい文字列を作成し、表示
string result = new string(valueArray);
Console.WriteLine(result); // 出力例: "321cba"
*/

// 逆順にした配列をカンマ区切りの文字列に変換
string result = String.Join(",", valueArray);

// カンマ区切りの文字列を表示
Console.WriteLine(result); // 出力例: "3,2,1,c,b,a"

// カンマで分割して配列に戻す
string[] items = result.Split(',');

// 配列の各要素を1行ずつ表示
foreach (string item in items)
{
    Console.WriteLine(item);
}