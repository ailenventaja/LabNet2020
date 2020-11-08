function clean() {
    document.getElementById("form1").reset();
 }

 function validateEmail() 
 {
    var email = document.getElementById('emailid').value;
    if (/^[-\w.%+]{1,64}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$/i.test(email)){           
        var name = document.getElementById("name").value;
        var lastname = document.getElementById("lastname").value;
        if (name!=null & name!="" & lastname!= null & lastname!= "" ){
            alert("Registro correcto");
            clean();
            return false;
        }
    } 
    else {
        alert("La dirección de email " + email + " es incorrecta.");
        return false;
    }
}

function Color(ele){
    if ($(ele).val() === "") {
      $(ele).css("background-color", "");
    }
    else{
      $(ele).css("color", "white");
      $(ele).css("font-family", "'Varela Round', sans-serif");
      $(ele).css("padding-left", "7px");
    }
}
