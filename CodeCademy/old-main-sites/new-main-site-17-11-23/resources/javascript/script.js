//own old code.
function toggleDarkMode1() {
  //general dark mode declaration
    var element = document.body;
    element.classList.toggle("dark-mode");
    //dark mode header1 declaration
    var test1 = document.getElementById("changeMe1");
    test1.classList.toggle("dark-mode");
    //header with dark mode underline declaration
    var test2 = document.getElementById("change2");
    test2.classList.toggle("dark-mode-header");
    //dark mode header3 declaration
    var test3 = document.getElementById("changeMe3");
    test3.classList.toggle("dark-mode");
    //dark mode images declarations
    var test4 = document.getElementById("cSharpImg");
    test4.classList.toggle("dark-mode-cSharpLogo");
    var test5 = document.getElementById("powerBiImg");
    test5.classList.toggle("dark-mode-powerBiLogo");
    var test6 = document.getElementById("blenderImg");
    test6.classList.toggle("dark-mode-blenderlogo");
    var test7 = document.getElementById("vsCodeImg");
    test7.classList.toggle("dark-mode-vsCode");
}  


//luke solution
/*
    function toggleDarkMode() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    var test1 = document.getElementById("changeMe1");
    test1.classList.toggle("dark-mode");
    var test2 = document.getElementById("changeMe2");
    test2.classList.toggle("dark-mode");
    var test3 = document.getElementById("change3");
    test3.classList.toggle("dark-mode-header");
}

let darkMode = localStorage.getItem("darkMode") == "true"; //returns stored value or null if not set

if(darkMode){
  toggleDarkMode(); //I'm assuming your page starts in light mode, so a call to toggle should switch everything over!
}

//new wrapper function
const updateDarkMode = () => {
  darkMode = !darkMode; //invert our variable
  localStorage.setItem("darkMode", darkMode); //save it in local storage
  toggleDarkMode(); //now update our styles!
}
*/


//Amit Ghosh Anto solution
/*
function toggleDarkMode() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    document.getElementById("changeMe1").classList.toggle("dark-mode");
    document.getElementById("change2").classList.toggle("dark-mode-header");
    document.getElementById("changeMe3").classList.toggle("dark-mode");
  
    // Check if dark mode is enabled and save the preference in localStorage
    var darkModeEnabled = element.classList.contains("dark-mode");
    localStorage.setItem("darkMode", darkModeEnabled);
  }
  
  function applyDarkModePreference() {
    var darkModeEnabled = localStorage.getItem("darkMode") === "true";
    var element = document.body;
  
    // Apply dark mode preference
    if (darkModeEnabled) {
      element.classList.add("dark-mode");
      document.getElementById("changeMe1").classList.add("dark-mode");
      document.getElementById("change2").classList.add("dark-mode-header");
      document.getElementById("changeMe3").classList.add("dark-mode");
    }
  }
  
  // Call the applyDarkModePreference function when the page loads
  applyDarkModePreference();
  */
  
  //own old code
/*
  function toggleDarkMode1() {
    var element = document.body;
    element.classList.toggle("dark-mode");
    var test1 = document.getElementById("changeMe1");
    test1.classList.toggle("dark-mode");
    var test2 = document.getElementById("change2");
    test2.classList.toggle("dark-mode-header");
    var test3 = document.getElementById("changeMe3");
    test3.classList.toggle("dark-mode");
}  
*/