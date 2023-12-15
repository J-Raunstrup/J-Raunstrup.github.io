function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id)
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    //nedestående blev fundet på stack overflow. det viser sig at tag
    //name værdien skal være kapitaliseret og ikke med små bogstaver. det virker til man kan burge return uden at defineres direkte hvad der skal returnes. jeg vil gætte på det er koden efter
    // der bliver retuneret. jeg er dog ikke sikker. //når funktionen når til return tagget. så vil funktionen stoppe.
    //hvis if statementets kode evaluerers til falsk.
    if (ev.target.tagName=="P") { return; }
    ev.target.appendChild(document.getElementById(data));
}