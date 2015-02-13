module EulerProject.Test.Problem26Test

open EulerProject.Core.Problem26
open NUnit.Framework
open FsUnit

[<TestCase(1, Result=0)>]
[<TestCase(2, Result=0)>]
[<TestCase(3, Result=1)>]
[<TestCase(6, Result=1)>]
[<TestCase(7, Result=6)>]
[<TestCase(983, Result=982)>]
let recurringDecimalPatternLength_withDivisor divisor =
    recurringDecimalPatternLength divisor


//module EulerProject.Test.Problem26TestOld
//
//open EulerProject.Core.Problem26
//open NUnit.Framework
//open FsUnit
//[<TestCase(1, Result="")>]
//[<TestCase(2, Result="")>]
//[<TestCase(3, Result="3")>]
//[<TestCase(6, Result="6")>]
//[<TestCase(7, Result="142857")>]
//[<TestCase(9, Result="1")>]
//let reccuringDecimalPattern_withDivisor divisor =
//    reccuringDecimalPattern divisor
//
//[<Test>]
//let decimalString_noDecimals_emptyString () =
//    decimalString 0I |> should equal ""
//
//[<Test>]
//let decimalString_finiteDecimals_decimals () =
//    50000I |> decimalString |> should equal "5"
//
//[<Test>]
//let decimalString_infiniteDecimals_decimals () =
//    333333I |> decimalString |> should equal "333333"
//
//[<TestCase("", Result="")>]
//[<TestCase("A", Result="")>]
//[<TestCase("AB", Result="")>]
//[<TestCase("AA", Result="A")>]
//[<TestCase("BAA", Result="A")>]
//[<TestCase("ABAB", Result="AB")>]
//[<TestCase("AABAAB", Result="AAB")>]
//[<TestCase("BACAACA", Result="ACA")>]
//[<TestCase("CBAABAAB", Result="AAB")>]
//[<TestCase("CBAABAABX", Result="")>]
//[<TestCase("AAAA", Result="A")>]
//let recurringPattern_withInput (s:string) =
//    recurringPattern s
