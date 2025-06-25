// 顧客情報と現在の金融商品のデータ
string customerName = "Ms. Barros";

// 現在の商品情報
string currentProduct = "Magic Yield";
int currentShares = 2975000;        // 保有株式数
decimal currentReturn = 0.1275m;    // 現在のリターン率（12.75%）
decimal currentProfit = 55000000.0m; // 現在の利益

// 新しい商品情報
string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;       // 新商品のリターン率（13.125%）
decimal newProfit = 63000000.0m;    // 新商品での想定利益

// 顧客への挨拶とメッセージの出力
Console.WriteLine($"Dear {customerName},");
// 現在の商品についての説明
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// 現在の保有状況を表示（:Nは数値フォーマット、:Pはパーセント表示）
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// 新商品の提案と想定利益を表示（:Cは通貨フォーマット）
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// 比較テーブルの見出し
Console.WriteLine("Here's a quick comparison:\n");

// 比較テーブルを作成するための文字列変数を初期化
string comparisonMessage = "";

// 現在の商品の行を作成
comparisonMessage = currentProduct.PadRight(20);                            // 商品名を20文字で左詰め
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);   // リターン率をパーセント表示で10文字
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);   // 利益を通貨表示で20文字

// 改行文字を追加
comparisonMessage += "\n";
// 新商品の行を作成
comparisonMessage += newProduct.PadRight(20);                               // 新商品名を20文字で左詰め
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);       // 新リターン率をパーセント表示で10文字
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);       // 新利益を通貨表示で20文字

// 完成した比較テーブルを出力
Console.WriteLine(comparisonMessage);