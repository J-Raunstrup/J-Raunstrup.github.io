function change() // no ';' here
{
    var elem = document.getElementById("myButton1");
    if (elem.innerHTML=="Close Curtain") elem.innerHTML = "Open Curtain";
    else elem.innerHTML = "Close Curtain";
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




