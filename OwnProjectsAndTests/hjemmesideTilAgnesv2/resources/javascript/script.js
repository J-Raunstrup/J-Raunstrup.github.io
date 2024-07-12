let navn = "AMRC";

let elementNumber = -1;


const testFunction1 = () => {
    let test2 = document.getElementById("kontaktSpanBox");
    let test3 = document.getElementById("dropDown1");
    let test4 = document.getElementById("dropDownUp1");
    if (test2.style.display === "flex") {
        test2.style.display = "none"
        test3.style.display = "flex";
        test4.style.display = "none"
    } else {
        test2.style.display = "flex";
        test3.style.display = "none";
        test4.style.display = "flex";
        test4.style.paddingLeft = "16px";
        test4.style.paddingRight = "0px";
    }
}

const testFunction2 = () => {
    let test2 = document.getElementById("showreelBoxIndhold");
    if (test2.style.display === "flex") {
        test2.style.display = "none"
    } else {
        test2.style.display = "flex";
    }
}

const testFunction3 = () => {
    let test2 = document.getElementById("nytFraMigBoxIndhold");
    if (test2.style.display === "flex") {
        test2.style.display = "none"
    } else {
        test2.style.display = "flex";
    }
}

const testFunction4 = () => {
    let test2 = document.getElementById("portfolieBoksIndhold");
    if (test2.style.display === "flex") {
        test2.style.display = "none"
    } else {
        test2.style.display = "flex";
    }
}

/* add the following back again after testing. */

const testFunction5 = () => {
    let test2 = document.getElementById("fotosBoksIndhold");
    if (test2.style.display === "flex") {
        test2.style.display = "none"
    } else {
        test2.style.display = "flex";
    }
}