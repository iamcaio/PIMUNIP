function Login(event) {
    event.preventDefault();
    var usuario = document.getElementsByName('username')[0].value;
    usuario = usuario.toLowerCase();
    var senha = document.getElementsByName('password')[0].value;
    senha = senha.toLowerCase();
  
    if (usuario == "caio" && senha == "1234") {
      window.location = "overview.html";
    } else {
      alert("Dados incorretos, tente novamente");
    }
  }