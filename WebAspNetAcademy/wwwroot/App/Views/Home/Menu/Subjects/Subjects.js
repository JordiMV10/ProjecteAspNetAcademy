class Subjects {


    get IsLogon() {
        return Globals.IsLogon;
    }

    constructor($http) {
        this.Http = $http;
    }

    GetStudents() {
        this.Http.get("/api/students").then(
            (response) => {
                this.Students.length = 0;
                for (let i in response.data) {
                    this.Students.push(response.data[i]);
                }
            },
            function errorCallback(response) {
                console.log("POST-ing of data failed");
            }
        );
    }

}

Subjects.$inject = ['$http'];

WebAspNetAcademyApp.
    component('subjects', {
        templateUrl: './App/Views/Home/Menu/Subjects/Subjects.html',
        controller: ('subjects', Subjects),
        controllerAs: 'vm'
    });
