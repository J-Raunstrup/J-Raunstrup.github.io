/* Open */
function openNav() {
    document.getElementById("myNav").style.height = "100%";
    document.getElementById("closeButton").style.display = "block";
    document.getElementById("openButton").style.display = "none";
}

/* Close */
function closeNav() {
    document.getElementById("myNav").style.height = "0%";
    document.getElementById("closeButton").style.display = "none";
    document.getElementById("openButton").style.display = "block";
}