function toggleDarkMode3() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    var test1 = document.getElementById("change1");
    test1.classList.toggle("dark-mode-header");
    var test2 = document.getElementById("changeMe2");
    test2.classList.toggle("dark-mode");
    var test3 = document.getElementById("changeMe3");
    test3.classList.toggle("dark-mode");
    //tried with getElementsbyClassName but it didnt work. not sure why. so instead different strategy will be used.
    //maybe because it changes the class of something thats selected and that causes the error.
    var test4 = document.getElementById("whiteButton1");
    test4.classList.toggle("dark-mode-button");
}
