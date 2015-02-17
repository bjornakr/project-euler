module EulerProject.Tests.NumberUtilitiesTest

open EulerProject.Core.NumberUtilities
open NUnit.Framework
open FsUnit

[<TestCase(0, 0, Result=0)>]
[<TestCase(1, 2, Result=12)>]
[<TestCase(2, 1, Result=21)>]
[<TestCase(18, 14, Result=1814)>]
[<TestCase(1, 0, Result=10)>]
[<TestCase(0, 1, Result=1)>]
let concatenate_with x y =
    concatenate x y

[<Test>]
let ``concatenateA_with([123; 789; 456])`` () =
    concatenateA([123; 789; 456]) |> should equal 123789456

[<Test>]
let ``concatenateA_with([123])`` () =
    concatenateA([123]) |> should equal 123
