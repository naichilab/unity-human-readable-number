# unity-human-readable-number
桁の多い数値(double)を人間が読める形に変換する拡張メソッド

# 機能

* double型に `ToReadableString()` というメソッドが増えます。
* 桁数に応じて、下記サフィックスを付与した文字列に変換します。

| 数値 | サフィックス |
| --- | --- |
| `0〜` | なし |
| 1,000 `10^3〜` | k - killo |
| 1,000,000 `10^6〜` | m - million | 
| 1,000,000,000 `10^9〜` | b - billion | 
| 1,000,000,000,000 `10^12〜` | t - trillion |
| （省略） `10^15〜` | A |
| （省略） `10^18〜` | B |
| （省略） `10^21〜` | C |
| ・・・  | ・・・ |
| ・・・ | Z |
| ・・・ | AA |
| ・・・ | AB |
| ・・・  | ・・・ |

# 使い方の例

```cs
//using naichilab.Scripts.Extensions;

double coin;
coin = 12345;
Debug.Log(coin.ToReadableString()); // 12.3k

coin = 8454645;
Debug.Log(coin.ToReadableString()); // 8.45m

coin = 4.25e10; //42,500,000,000
Debug.Log(coin.ToReadableString()); // 42.5b

coin = 7.342e60; //7,342,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000
Debug.Log(coin.ToReadableString()); // 7.34P
```


# 紹介記事

[Unity、インフレクリッカー系ゲームによくある200kとか4.21mみたいな数値表示をしてみた](https://blog.naichilab.com/entry/double-unit-string)
