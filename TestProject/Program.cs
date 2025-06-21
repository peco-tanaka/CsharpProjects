/* // 拡大変換により暗黙的な変換が実行される
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

 */


/* // キャストを使用して明示的に変換する例
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
 */


// 明示的なキャストを使用して decimal から float への変換を行う例
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal; // 明示的なキャスト

Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"float: {myFloat}");