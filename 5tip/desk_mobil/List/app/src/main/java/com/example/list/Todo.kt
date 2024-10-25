package com.example.list

class Todo(content:String, priority:MyPriority) {
    private var content: String;
    private var priority:MyPriority;
    var Content:String
        get() = if(priority==MyPriority.ALERT) content.toString().uppercase() else content
        set(value) {
            content = value.toString().trim()
        }
    var Priority:MyPriority
        get() = priority
        set(value) {
            priority = value
        }
    init {
        this.content = content;
        this.priority = priority;
    }
    override fun toString():String {
        return "$Content, priorytet: $Priority"
    }
}

enum class MyPriority(private var value: String) {
    HIGH("wysoki"),
    MEDIUM("średni"),
    LOW("niski"),
    ALERT("alert");

    override fun toString(): String {
        return value
    }
}