module HelloJavascript

open Fable.Core

type ILib =
    abstract helloJavascript : unit -> string

[<Import("*", from="@zahnom/hello-javascript")>]
let lib: ILib = jsNative