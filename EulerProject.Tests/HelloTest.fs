module EulerProject.Tests.HelloTest

open EulerProject.Core.Hello
open NUnit.Framework
open FsUnit

[<Test>]
let ``should say hello`` () =
    sayHello ("world") |> should equal ("Hello world!")

[<TestCase("world", Result="Hello world!")>]
[<TestCase("Trogger", Result="Hello Trogger!")>]
let ``sayHello -> with name -> says hallo with name`` name =
    sayHello name