module OpeningMentor.Chess.Pgn.Test.TestBase

open FParsec
open OpeningMentor.Chess.Model.ChessException

open Xunit.Sdk

let parse p str =
    match run p str with
    | Success(result, _, _)   -> result
    | Failure(errorMsg, _, _) -> raise (PgnFormatException errorMsg)


let tryParse p str =
    match run p str with
    | Success(result, _, _)   -> ()
    | Failure(errorMsg, _, _) -> raise (PgnFormatException errorMsg)

let shouldFail p str =
    match run p str with
    | Success(result, _, _)   -> raise (XunitException "Expected parser did not fail")
    | Failure(errorMsg, _, _) -> ()