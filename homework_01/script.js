console.log("ja jsem king bao");
var div=document.getElementById("div");
var button=document.getElementById("button");
var text= document.createElement("p");
text.textContent="smrdis"
button.addEventListener("click", (event)=>{
    div.appendChild(text);


})