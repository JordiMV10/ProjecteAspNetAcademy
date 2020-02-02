class LoginDto
{
    Email = "";
    Password = "";

    constructor(email, password)
    {
        this.Email = email;
        this.Password = password;
    }
}


//LoginDto.$inject = ['$http'];

//WebAspNetAcademyApp.
//    component('loginDto', {
//        templateUrl: './App/Views/Start/index.html',
//        controller: ('Login', Login),
//        controllerAs: 'vm'
//    });