function addIsDone() {
  const inputs = document.querySelectorAll("li input");
  console.log(inputs);

  for (let input of inputs) {
    input.checked = false;
    input.onclick = function (event) {
      const span = event.target.previousElementSibling;
      span.style.textDecoration = event.target.checked ? "line-through" : "none";
    }

  }
}
addIsDone();
document.querySelector("#btnAdd").onclick = function () {
  const text = document.querySelector("#task").value;
  if (text.trim() === "") return;
  const li = document.createElement("li");
  li.innerHTML = `<span>${text}</span> <input type="checkbox">`;
  // li.innerHTML = '<span>' + text + '</span> <input type="checkbox">';
  const ol = document.querySelector("ol");
  ol.appendChild(li);
  addIsDone();
  document.querySelector("#task").value = "";
};