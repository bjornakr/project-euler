module EulerProject.Tests.Problem31Test

open EulerProject.Core.Problem31
open NUnit.Framework
open FsUnit

[<Test>]
let ``solve -> with max=1 [1] -> has one solution`` () =
    solve 1 [1] |> should equal 1

[<Test>]
let ``solve -> with max=2 [2] -> has one solution`` () =
    solve 2 [2] |> should equal 1

[<Test>]
let ``solve -> with max=1 [2] -> has no solution`` () =
    solve 1 [2] |> should equal 0

[<Test>]
let ``solve -> with max=2 [1] -> has one solution`` () =
    solve 2 [1] |> should equal 1

[<Test>]
let ``solve -> with max=2 [1; 2] -> has two solutions`` () =
    solve 2 [1; 2] |> should equal 2

[<Test>]
let ``solve -> with max=4 [1; 2] -> has three solutions`` () =
    solve 4 [1; 2] |> should equal 3

[<Test>]
let ``solve -> with max=10 [1; 2; 5] -> has 10 solutions`` () =
    solve 10 [1; 2; 5] |> should equal 10

[<Test>]
let ``solve -> with max=10 [5; 2; 1] -> has 10 solutions`` () =
    solve 10 [5; 2; 1] |> should equal 10


[<Test>]
let ``solve -> with max=10 [1; 3; 5] -> has 7 solutions`` () =
    solve 10 [1; 3; 5] |> should equal 7


[<Test>]
[<Ignore>]
let ``solve -> with max=200 [1; 2; 5; 10; 20; 50; 100; 200] -> has x solutions`` () =
    solve 200 [1; 2; 5; 10; 20; 50; 100; 200] |> should equal 73682