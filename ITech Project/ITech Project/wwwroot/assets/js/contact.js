let inputEmail = document.querySelector("#Email")
let inputMessage = document.querySelector("#Message")
let form = document.querySelector(".form-sub")

form.onsubmit = () => {
    if (inputEmail.value != "" && inputMessage.value != "")
        alert(`We will send an email to: ${inputEmail.value}`);
}
