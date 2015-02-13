module EulerProject.Tests.PrimeCalculatorTest

open EulerProject.Core.PrimeCalculator
open NUnit.Framework
open FsUnit

[<TestCase(0, Result=false)>]
[<TestCase(1, Result=false)>]
[<TestCase(2, Result=true)>]
[<TestCase(3, Result=true)>]
[<TestCase(4, Result=false)>]
[<TestCase(5, Result=true)>]
[<TestCase(9, Result=false)>]
let isPrime_with x =
    isPrime x

