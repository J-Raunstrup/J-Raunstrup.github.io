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
//own old attempt.
function toggleDarkMode3() {
    //general dark mode declaration
      var element = document.body;
      element.classList.toggle("dark-mode");
      //dark mode header with underline declaration
      var test1 = document.getElementById("change1");
      test1.classList.toggle("dark-mode-header");
      //dark mode header declarations
      var test2 = document.getElementById("changeMe2");
      test2.classList.toggle("dark-mode");
      var test3 = document.getElementById("changeMe3");
      test3.classList.toggle("dark-mode");
      //dark mode button declaration
      var test4 = document.getElementById("whiteButton1");
      test4.classList.toggle("dark-mode-button");
  }
  */
  
  //luke solution
  
      function toggleDarkMode() {
        var element = document.body;
        element.classList.toggle("dark-mode");
        //dark mode header with underline declaration
        var test1 = document.getElementById("change1");
        test1.classList.toggle("dark-mode-header");
        //dark mode header declarations
        var test2 = document.getElementById("changeMe2");
        test2.classList.toggle("dark-mode");
        var test3 = document.getElementById("changeMe3");
        test3.classList.toggle("dark-mode");
        //dark mode button declaration
        var test4 = document.getElementById("whiteButton1");
        test4.classList.toggle("dark-mode-button");
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
  