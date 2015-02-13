module EulerProject.Test.Problem30Test

open EulerProject.Core.Problem30
open NUnit.Framework
open FsUnit

//[<Test>]
let equalSumAndDigits_powerOfFour_returnsCorrectSums () =
    equalSumAndDigits 4 |> should equal [1634; 8208; 9474]
