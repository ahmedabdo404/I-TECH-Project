console.log()
let inputEmail, mail
if (window.location.href.toLowerCase().includes("sendmail")) {
    inputEmail = document.querySelector("#ToEmail")
} else if (window.location.href.toLowerCase().includes("emailsent")){
    mail = document.querySelector(".mail")
    mail.innerHTML = inputEmail.value;
}