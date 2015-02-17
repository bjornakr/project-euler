module EulerProject.Test.Problem32Test

open EulerProject.Core.Problem32
open NUnit.Framework
open FsUnit

[<Test>]
//[<Ignore>]
let findPandigitalProducts_CorrectValue () =
    findPandigitalProducts () |> should equal 10

[<Test>]
let ``isPandigital -> with [] -> False`` () =
    isPandigitalA [] |> should be False

[<Test>]
let ``isPandigital -> with [1] -> True`` () =
    isPandigitalA [1] |> should be True

[<Test>]
let ``isPandigital -> with [12] -> True`` () =
    isPandigitalA [12] |> should be True

[<Test>]
let ``isPandigital -> with [1, 2] -> True`` () =
    isPandigitalA [1; 2] |> should be True

[<Test>]
let ``isPandigital -> with [13] -> False`` () =
    isPandigitalA [13] |> should be False

[<Test>]
let ``isPandigital -> with [1, 3] -> False`` () =
    isPandigitalA [1; 3] |> should be False

[<Test>]
let ``isPandigital -> with [13, 2] -> True`` () =
    isPandigitalA [13; 2] |> should be True

[<Test>]
let ``isPandigital -> with [1357, 2468, 9] -> True`` () =
    isPandigitalA [1357; 2468; 9] |> should be True

[<Test>]
let ``isPandigital -> with [11] -> False`` () =
    isPandigitalA [11] |> should be False
