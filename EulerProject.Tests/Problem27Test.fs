module EulerProject.Test.Problem27Test

open EulerProject.Core.Problem27
open NUnit.Framework
open FsUnit

[<Test>]
//[<Ignore>]
let solve () =
    printf "%A" <| solve 1000

[<TestCase(1, 41)>]
[<TestCase(-79, 1601)>]
let primes_with a b =
    let x = primes 0 a b
//    printfn("%A") x
    match (a, b) with
    | (1, 41) -> List.length x |> should equal 40 // ((1, 41), 40, 41)
    | (-79, 1601) -> List.length x |> should equal 80 //((-79, 1601), 80, -126479)
    | _ -> Assert.Fail ()


   