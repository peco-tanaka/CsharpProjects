// C# 値型 vs 参照型 学習サンプル

// 配列の宣言と初期化例
int[] data;              // 配列変数の宣言（まだnull）
data = new int[3];       // メモリ上にint型3要素の配列を作成

int[] data2 = new int[3]; // 宣言と初期化を同時に

string shortenedString = "Hello World";
Console.WriteLine(shortenedString);

// ========================================
// 1. 値型（Value Types）の動作
// ========================================
// 値型は値そのものをコピーする

int val_A = 2;           // val_Aに値2を格納
int val_B = val_A;       // val_Bにval_Aの値（2）をコピー
val_B = 5;               // val_Bのみを5に変更（val_Aには影響しない）

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}"); // 結果: 2（変更されない）
Console.WriteLine($"val_B: {val_B}"); // 結果: 5

// ========================================
// 2. 参照型（Reference Types）- string型の特殊な動作
// ========================================
// stringは参照型だが「イミュータブル（不変）」なので値型のような動作をする

string str_A = "2";      // str_Aが"2"を参照
string str_B = str_A;    // str_Bも同じ"2"を参照
str_B = "5";             // str_Bは新しい"5"オブジェクトを参照（str_Aは変わらず"2"を参照）

Console.WriteLine("--Reference Types (String - Immutable)--");
Console.WriteLine($"str_A: {str_A}"); // 結果: "2"（変更されない）
Console.WriteLine($"str_B: {str_B}"); // 結果: "5"

// ========================================
// 3. 参照型（Reference Types）- 配列の一般的な動作
// ========================================
// 配列は参照型で「ミュータブル（可変）」なので参照を共有する

int[] ref_A = new int[1]; // ref_Aが新しい配列オブジェクトを参照
ref_A[0] = 2;            // 配列の最初の要素に2を代入
int[] ref_B = ref_A;     // ref_Bも同じ配列オブジェクトを参照（参照のコピー）
ref_B[0] = 5;            // 配列の中身を変更（ref_Aからも同じ変更が見える）

Console.WriteLine("--Reference Types (Array - Mutable)--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}"); // 結果: 5（影響を受ける）
Console.WriteLine($"ref_B[0]: {ref_B[0]}"); // 結果: 5