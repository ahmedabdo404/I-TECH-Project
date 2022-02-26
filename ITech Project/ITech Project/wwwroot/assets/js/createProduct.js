let createFrom = document.getElementById("Create");
let categ = document.getElementById("Category");
let mob = document.getElementById("mob");
let lab = document.getElementById("lab");

function changeValue() {
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
}

categ.addEventListener("change", changeValue);

// on onload window automaticlly show the right category
window.onload = () => {
    if (categ.value == 1) {
        lab.classList.remove("d-none");
    } else if (categ.value == 2) {
        mob.classList.remove("d-none");
    }
    console.log(categ.value)
}

 //on submit for remove the other categry(temperory sol for category valdation issue)
createFrom.onsubmit = () => {
    if (categ.value == 1) {
        mob.remove();
    } else if (categ.value == 2){
        lab.remove();
    }
}


let picInput = document.querySelector(".pic-input");
let imageAdd = document.querySelector("#image-add");
let imgLink;


imageAdd.onclick = () => {
    imgLink = prompt("enter the link of image here");
    console.log(imgLink)
    if (imgLink !== "") {
        if (picInput.value === '')
            picInput.value += `${imgLink}`;
        else if (picInput.value !== '')
            picInput.value += `,${imgLink}`;
    }
}
