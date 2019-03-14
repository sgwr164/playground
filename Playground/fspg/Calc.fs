module Calc

let rec factorial = function
    | 1 -> 1
    | n when n <= 0 -> 0
    | n -> n * factorial (n - 1)