function Login()
{


var  courseid = document.getElementById("courseid").value;

var courseid =1;



var seats = document.getElementById("seats").value;

var seats=50;
if(courseid==1 && seats==50)
{
alert("Login Successfully");

}
else{

    alert("Login Failed");
}


}

function getOption() 
{
    selectElement = document.querySelector('#2');
    output = selectElement.value;
    document.querySelector('.output').textContent = output;
}

function displayRadioValue() 
{
    var ele = document.getElementsByName('gender');

    for (i = 0; i < ele.length; i++) {
        if (ele[i].checked)
            document.getElementById("result").innerHTML
                = "Gender: " + ele[i].value;
    }
}


function getOption() 
{

     debugger;
     selectElement = document.querySelector('#select1');
     output = selectElement.options[selectElement.selectedIndex].value;
     document.querySelector('.output').textContent = output;
}

   