﻿class Login
{
    get Email() {
        return this._email;
    }

    set Email(value) {
        this._email = value;
    }

    get Password() {
        return this._password;
    }

    set Password(value) {
        this._password = value;
    }

    constructor($http) {
        this.Http = $http;
    }

    Login() {
        //alert("user:" + this.Email + " password:" + this.Password);

        var data =
        {
            email: this.Email,
            password: this.Password
        };


        this.Http.post("/api/login",   
            data

        ).then(
            (response) => {
                if (response.data === true)
                    Globals.IsLogon = true;
            },
            function errorCallback(response) {
                console.log("POST-ing of data failed");
            }
        );

        // Globals.IsLogon = true;   //Meu !!   OJO QUITAR PQ NO CONECTA BIEN, ESTO ES PARA PROBAR RESTO
    }
}

Login.$inject = ['$http'];

WebAspNetAcademyApp.
    component('login', {
        templateUrl: './App/Views/Start/Login/login.html',
        controller: ('Login', Login),
        controllerAs: 'vm'
    });