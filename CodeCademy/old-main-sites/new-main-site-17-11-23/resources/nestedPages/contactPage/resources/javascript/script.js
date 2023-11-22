function toggleDarkMode2() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    var test1 = document.getElementById("changeMe1");
    test1.classList.toggle("dark-mode");
    var test2 = document.getElementById("changeMe2");
    test2.classList.toggle("dark-mode");
    var test3 = document.getElementById("change3");
    test3.classList.toggle("dark-mode-header");
}