let createFrom = document.getElementById("Create");
let categ = document.getElementById("Category");
let mob = document.getElementById("mob");
let lab = document.getElementById("lab");

mob.classList.add("d-none");
lab.classList.add("d-none");

console.log(categ.value)
categ.addEventListener("change", function () {
    if (this.value == 1) {
        mob.classList.add("d-none");
        lab.classList.remove("d-none");
    } else if (this.value == 2) {
        lab.classList.add("d-none");
        mob.classList.remove("d-none");
    } else {
        mob.classList.add("d-none");
        lab.classList.add("d-none");
    }
});
console.log(createFrom)
createFrom.onsubmit = () => {
    if (categ.value == 1) {
        mob.remove();
    } else if (categ.value == 2){
        lab.remove();
    }
}

let photo = document.getElementById("Picture");
let arr = [];
photo.onchange = function () {
    arr = this.files;
    for (let i of arr) {
        console.log(i.name)
    }
}