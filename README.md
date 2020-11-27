# csharp-regex
## Javascript RegExp
```
const regex1 = RegExp('foo*', 'g');
const str1 = 'table football, foosball';
let array1;

while ((array1 = regex1.exec(str1)) !== null) {
  console.log(`Found ${array1[0]}. Next starts at ${regex1.lastIndex}.`);
  // expected output: "Found foo. Next starts at 9."
  // expected output: "Found foo. Next starts at 19."
}

```
传入字符串，返回字符串arr或者null
RegExp.prototype.exec(string str) return [匹配到的字符串,[括号]]
RegExp.prototype.test(string str) return boolean

lastIndex 表示了re从哪个位置开始下一次匹配  
- lastIndex > str.length 时 test() exec() 失败，lastIndex重置为0
- lastIndex <= str.length 时 如果re允许匹配空字符串,exec() 返回["",undefined] lastIndex位置不变。
- lastIndex = str.length 时 且匹配不到，lastIndex重置为0

## c# System.Test.RegularExpressions
```
// Define a regular expression for repeated words.
Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
    RegexOptions.Compiled | RegexOptions.IgnoreCase);

// Define a test string.
string text = "The the quick brown fox  fox jumps over the lazy dog dog.";

// Find matches.
MatchCollection matches = rx.Matches(text);

// Report the number of matches found.
Console.WriteLine("{0} matches found in:\n   {1}",
                    matches.Count,
                    text);

// Report on each match.
foreach (Match match in matches)
{
    GroupCollection groups = match.Groups;
    Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                        groups["word"].Value,
                        groups[0].Index,
                        groups[1].Index);
}
// The example produces the following output to the console:
//       3 matches found in:
//          The the quick brown fox  fox jumps over the lazy dog dog.
//       'The' repeated at positions 0 and 4
//       'fox' repeated at positions 20 and 25
//       'dog' repeated at positions 50 and 54
```