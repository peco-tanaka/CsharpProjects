// 配列palletsを初期化（パレット名のリスト）
string[] pallets = ["B14", "A11", "B12", "A13"];

// 配列を昇順（アルファベット順）にソート
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    // ソート後の各要素を表示
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// 配列を逆順（降順）に並べ替え
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    // 逆順にした各要素を表示
    Console.WriteLine($"-- {pallet}");
}