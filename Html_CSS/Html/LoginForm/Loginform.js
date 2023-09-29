function login()

{

      debugger;
    var Username= document.getElementsByName("username")
    var Uname= Username[0].value;

    var Password= document.getElementsByName("password")
    var Pass= Password[0].value;


  if (Uname == null || Uname.length == 0) 
    {

        alert("Please enter Username ");
        
    }
    else  if(Pass == null || Pass.length == 0) 
    {
        alert("Please enter password");
        
    }
        if (Uname.toLowerCase() == "sibi" && Pass.toLowerCase()== "sibi4644" )
{  
              alert("Login Success");
            window.open("https://www.rvscas.ac.in/");
}
        
    else 
    {
        alert("Invalid Username/Password");
    }

}
    
