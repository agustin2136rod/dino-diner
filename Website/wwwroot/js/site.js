// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function Clear() {
    var items = document.getElementsByClassName("MenuItems");
    items[0].style.display = "none";
    items[1].style.display = "none";
    items[2].style.display = "none";
    items[3].style.display = "none";
}

function CombosClick() {
    Clear();
    var Combos = document.getElementById("Combos")
    Combos.style.display = "block";
}