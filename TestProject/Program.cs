// 請求書番号を整数で定義
int invoiceNumber = 1201;
// 商品のシェア数（小数点以下4桁）
decimal productShares = 25.4568m;
// 小計（通貨型）
decimal subtotal = 2750.00m;
// 税率（小数）
decimal taxPercentage = .15825m;
// 合計金額（通貨型）
decimal total = 3185.19m;

// 複合書式設定を使って各値をフォーマットして出力
Console.WriteLine($"Invoice Number: {invoiceNumber}"); // 通常の整数表示
Console.WriteLine($"   Shares: {productShares:N3} Product"); // 小数点以下3桁で3桁区切り
Console.WriteLine($"     Sub Total: {subtotal:C}"); // 通貨書式
Console.WriteLine($"           Tax: {taxPercentage:P2}"); // パーセント書式（小数点以下2桁）
Console.WriteLine($"     Total Billed: {total:C}"); // 通貨書式