﻿class Index {

    //get Students() {
    //    return this._students;
    //}
    //set Students(value) {
    //    this._students = value;
    //}

    get IsLogon() {
        return Globals.IsLogon;
    }

    constructor($http) {
        this.Http = $http;
    }

    //GetStudents() {
    //    this.Http.get("/api/students").then(
    //        (response) => {
    //            this.Students.length = 0;
    //            for (let i in response.data) {
    //                this.Students.push(response.data[i]);
    //            }
    //        },
    //        function errorCallback(response) {
    //            console.log("POST-ing of data failed");
    //        }
    //    );
    //}



    //Meu

    //GoMenu() {
    //    this.Http.get("/app/views/home/menu/menu").then(
    //        (response) => {

    //            if (response.data === true)
    //                Globals.IsLogon = true;
    //        },
    //        function errorCallback(response) {
    //            console.log("POST-ing of data failed");
    //        }
    //    );
    //}



}
Index.$inject = ['$http'];

WebAspNetAcademyApp.
    component('index', {
        templateUrl: './App/Views/Index.html',
        controller: ('index', Index),
        controllerAs: 'vm'
    });

