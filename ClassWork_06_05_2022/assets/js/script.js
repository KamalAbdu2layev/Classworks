let table = document.querySelectorAll(".btn");
let tableImg = document.querySelectorAll(".table-img img")
let p = document.querySelectorAll("#text")

table.forEach((e) => {
    e.addEventListener("click", openBlur)
})

function openBlur() {
    tableImg.forEach((e) => {
        e.style = "filter: blur(0);"
    })

    p.forEach((e) => {
        e.style = "display: block;"
    })
}

