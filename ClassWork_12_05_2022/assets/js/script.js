let redElement = document.getElementById("red");
let greenElement = document.getElementById("green");
let blueElement = document.getElementById("blue");
let blackWhite  = document.getElementById("black-white");


let elements = document.querySelectorAll(".color")

let g;
elements.forEach((element) => {
    element.ondragstart = function (e) {
        g = e.target;
    }
})

blackWhite.ondragover = function (e) {
    e.preventDefault();
}

blackWhite.ondrop = function (e) {
    e.style.backgroundColor = g.id;
}