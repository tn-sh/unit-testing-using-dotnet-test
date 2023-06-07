# C#単体テストの練習

## テストの基本

[公式のチュートリアル](https://learn.microsoft.com/ja-jp/dotnet/core/testing/unit-testing-with-dotnet-test)を実践して基本的な内容を理解した。

## カバレッジ

[ここ](https://learn.microsoft.com/ja-jp/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)を見ながらカバレッジも出せるようにしようとしたが、関係なさそうな内容も多かった。

レポート生成するツールのインストールは、一度やっておけばOK。

```sh
dotnet tool install -g dotnet-reportgenerator-globaltool
```

上述のチュートリアルで作ったプロジェクトに対して必要な操作は、以下だけだった。

```sh
dotnet test --collect:"XPlat Code Coverage"
```

上記コマンドが成功すると、出力結果の末尾に`添付ファイル:`と出力され、次の行に`guid`のフォルダ内の`coverage.cobertura.xml`ファイルのフルパスが表示される。これを使って以下のように実行するとレポートが生成される（`{guid}`の部分は適宜変更）。

```sh
reportgenerator -reports:"PrimeService.Tests\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

`coveragereport`フォルダにレポートが生成されるので、そのフォルダの`index.html`をブラウザで開くと下図のように表示される。

![Coverage Report Sample](media/coverage-report-sample.png)
