module SampleTest

open NUnit.Framework
 
[<Test>]
let simpleTest() =
    Assert.AreEqual(2.0**10.0, 1024.0)
 
[<TestCase("",      0)>]
[<TestCase("ab",    2)>]
[<TestCase("ABC",   3)>]
[<TestCase("ABCD",  4)>]
[<TestCase("12345", 5)>]
let parameterizedTest(str: string, expected: int) :unit =
    Assert.AreEqual(str.Length, expected)
