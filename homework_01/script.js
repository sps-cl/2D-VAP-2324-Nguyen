console.log("ja jsem king bao");
var div=document.getElementById("div");
var button=document.getElementById("button");
var text= document.createElement("p");
text.textContent="jsem king"
button.addEventListener("click", (event)=>{
    div.appendChild(text);


})