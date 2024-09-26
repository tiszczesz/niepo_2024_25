package com.example.cw4

class Nwd {
    fun nwdIter(a:Int,b:Int):Int{
        var temp = a;
        var _a = a;
        var _b = b;
        while(_b != 0){
            temp = _a;
            _a = _b;
            _b = temp % _b;
        }
        return _a;
    }
}