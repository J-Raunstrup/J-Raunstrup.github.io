/*
// Get the root element
const root = document.documentElement;
// Get the toggle button
const toggle = document.getElementById("toggle");
// Get the user's preference from localStorage
const darkMode = localStorage.getItem("dark-mode");

// Check if the user has already chosen a theme
if (darkMode) {
  // If yes, apply it to the root element
  root.classList.add("dark-theme");
}
// Add an event listener to the toggle button
toggle.addEventListener("click", () => {
  // Toggle the dark-theme class on the root element
  root.classList.toggle("dark-theme");
  // Store or remove the user's preference in localStorage
  if (root.classList.contains("dark-theme")) {
    localStorage.setItem("dark-mode", true);
  } else {
    localStorage.removeItem("dark-mode");
  }
});

*/
/*
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
    var test8 = document.getElementById("bPUT1");
    test8.classList.toggle("dark-mode-bTUT");
    var test9 = document.getElementById("bPUT2");
    test9.classList.toggle("dark-mode-bTUT");
    var test10 = document.getElementById("bPUT3");
    test10.classList.toggle("dark-mode-bTUT");
    return true;
}  
 if (toggleDarkMode1 === true) {
  window.localStorage.setItem("testMan", "dark");
  console.log(toggleDarkMode1);
 } else if (toggleDarkMode1 === false) {
  window.localStorage.setItem("testMan", "light");
  console.log(toggleDarkMode1);
 } else {
  window.localStorage.setItem("testMan", "grey");
  console.log(toggleDarkMode1);
 }

localStorage.setItem("users",
JSON.stringify({ name: "Karl Hadwen", food: "pizza"})
);
*/
//luke solution

    function toggleDarkMode() {
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
  var test8 = document.getElementById("bPUT1");
  test8.classList.toggle("dark-mode-bTUT");
  var test9 = document.getElementById("bPUT2");
  test9.classList.toggle("dark-mode-bTUT");
  var test10 = document.getElementById("bPUT3");
  test10.classList.toggle("dark-mode-bTUT");
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



//code fra test
function change() // no ';' here
{
    var elem = document.getElementById("myButton1");
    if (elem.innerHTML=="🌙") elem.innerHTML = "☀️";
    else elem.innerHTML = "🌙";
}

let buttonSwitchValue = localStorage.getItem("buttonSwitchValue") == "true";

if (buttonSwitchValue) {
  change();
}

const updateButtonText = () => {
  buttonSwitchValue = !buttonSwitchValue;
  localStorage.setItem("buttonSwitchValue", buttonSwitchValue);
  change();
}





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