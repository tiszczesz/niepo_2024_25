const inputs = document.querySelectorAll("li input");
for(let input of inputs) {
    input.onclick = function(event) {
      const span = event.target.previousElementSibling;
      span.style.textDecoration = event.target.checked ? "line-through": "none";
    }
    
}