function toggleDarkMode() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    var test1 = document.getElementById("changeMe1");
    test1.classList.toggle("dark-mode");
    var test2 = document.getElementById("change2");
    test2.classList.toggle("dark-mode-header");
    var test2 = document.getElementById("changeMe3");
    test2.classList.toggle("dark-mode");
}