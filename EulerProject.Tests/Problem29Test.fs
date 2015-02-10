module EulerProject.Test.Problem29Test

open EulerProject.Core.Problem29
open NUnit.Framework
open FsUnit

[<TestCase(2)>]
[<TestCase(3)>]
[<TestCase(4)>]
[<TestCase(5)>]
let ``distinctTerms -> gets correct terms for `` limit =
    match limit with
    | 2 -> distinctTerms limit |> should equal [4I]
    | 3 -> distinctTerms limit |> should equal [4I; 8I; 9I; 27I]
    | 4 -> distinctTerms limit |> should equal [4I; 8I; 9I; 16I; 27I; 64I; 81I; 256I;]
    | 5 -> distinctTerms limit |> should equal [4I; 8I; 9I; 16I; 25I; 27I; 32I; 64I; 81I; 125I; 243I; 256I; 625I; 1024I; 3125I]
    | _ -> Assert.Fail ()

[<Test>]
let ``distinctTerms -> with large n -> verify biggest number`` () =
    Seq.max (distinctTerms 100) |> should equal (pown 100I 100)

[<Test>]
let ``Verify answer to problem 29`` () =
    distinctTerms 100 |> Seq.length |> should equal 9183