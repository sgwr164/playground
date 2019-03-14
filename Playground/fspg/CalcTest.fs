module CalcTest

open NUnit.Framework

[<TestCase(0,0)>]
[<TestCase(1,1)>]
[<TestCase(2,2)>]
[<TestCase(3,6)>]
[<TestCase(4,24)>]
[<TestCase(5,120)>]
let factorialTest(value: int, expected: int) :unit =
    Assert.AreEqual(Calc.factorial value, expected)