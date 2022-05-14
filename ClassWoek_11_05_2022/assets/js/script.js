let box = document.querySelectorAll(".box");
let img = document.querySelector(".box-img img");

img.ondragstart = function (e) {
    e.dataTransfer.setData("id", this.id);
}

box.forEach(item=>{
    item.ondragover = function (e) {
        e.preventDefault();
    }
})

box.forEach(item=>{
    item.ondrop=function (e) {
        let id=e.dataTransfer.getData("id");
        let element = document.getElementById(id);
        item.appendChild(element)
    }
})
