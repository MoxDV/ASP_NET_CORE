document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "Этот элемент из файла fourth.js";
    document.querySelector("body").appendChild(element);
});
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "Этот элемент из файла third.js";
    document.querySelector("body").appendChild(element);
});