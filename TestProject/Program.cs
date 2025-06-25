string message = "(What if) I am (only interested) in the last (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf("(");
    if (openingPosition == -1) break; // No more opening parentheses found

    openingPosition += 1;
    int closingPosition = message.IndexOf(")");
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}