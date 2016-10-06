/// <reference path="angular.min.js" />
//*************** Chaining method to add controller to the Module********/
var myapp = new angular
                     .module("myModule", [])
                     .controller("myController", function ($scope) {
                         $scope.message = "Angular tutorial will be shown in the web page..Assign the message variablewhat u need to diplay"
                     })
                    .controller("employeeController", function ($scope) {
                        var employee = {
                            firstname: 'Manas',
                            lastname: 'Panda',
                            gender: 'Male'
                        };
                        $scope.employee = employee;
                    })
                    .controller("ImageController", function ($scope) {
                        var gadget = {
                            device: 'Camera',
                            company: 'Nikon',
                            imagesrc: '/Image/nikon_alpha.jpg'
                        };
                        $scope.gadget = gadget;
                    });
             

var employeesController = function ($scope) {
    var employees = [
        { firstname: 'Manas', lastname: 'Panda', gender: 'Male', company: 'Tieto', salary: 6000 ,dateOfBirth:new Date("February 20,1987")},
        { firstname: 'Kiran', lastname: 'Sadangi', gender: 'Male', company: 'Tieto', salary: 7000, dateOfBirth: new Date("July 21,1987") },
        { firstname: 'Lala', lastname: 'Bishoyi', gender: 'Male', company: 'Infosys', salary: 8000, dateOfBirth: new Date("July 09,1986") },
        { firstname: 'Manoj', lastname: 'Patro', gender: 'Male', company: 'Tieto', salary: 9000, dateOfBirth: new Date("August 06,1986") },
        { firstname: 'Jyoti', lastname: 'Pathy', gender: 'Female', company: 'Infosys', salary: 6700, dateOfBirth: new Date("August 06,1988") },
        { firstname: 'Alia', lastname: 'Mohanty', gender: 'Female', company: 'SDL', salary: 7800, dateOfBirth: new Date("May 18,1992") },
        { firstname: 'Sonali', lastname: 'Sahu', gender: 'Female', company: 'SDL', salary: 9900, dateOfBirth: new Date("September 20,1992") },
    ];
    $scope.employees = employees;
    $scope.rowLimit = 4;
    $scope.sortColumn = 'firstname';
    $scope.reversesort = false;
    
    $scope.sortData = function (column) {
        $scope.reversesort = ($scope.sortColumn == column) ? !$scope.reversesort : false;
        $scope.sortColumn = column;
    };
    $scope.getSortClass = function (column) {
        if($scope.sortColumn == column) 
            return $scope.reversesort ? 'arrow-down':'arrow-up'
        return '';
    }

    $scope.search = function (item) {
        if ($scope.searchText == undefined) {
            return true;
        }
        else {
            if (item.firstname.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1 ||
                item.company.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1) {
                return true;
            }
        }
        return false;
    };
    



};

var statesController = function ($scope) {
    var states = [
        {
            name: "Odisha",
            cities: [
               { name: "Berhampur" },
               { name: "Bhubaneswar" },
               { name: "Rourkela" }
              
            ]
        },
        {
            name: "Maharashtra",
            cities: [
               { name: "Mumbai" },
               { name: "Pune" },
               { name: "Nagpur" }

            ]
        },
        {
            name: "Andhra",
            cities: [
               { name: "Vizag" },
               { name: "Guntur" },
               { name: "Vijaywada" }

            ]
        }
    ];
    $scope.states = states;

};

//****Events in Angular ***//
var technologiesController = function ($scope) {
    var technologies = [
        { name: "Java", likes:0, dislikes:0 },
        { name: ".Net", likes: 0, dislikes: 0 },
        { name: "Angular", likes: 0, dislikes: 0 },
        { name: "Hadoop", likes: 0, dislikes: 0 },
        { name: "Analytics", likes: 0, dislikes: 0 }
    ];
    $scope.technologies = technologies;

    $scope.increamentLikes = function (technology) {
        technology.likes++;
    }

    $scope.increamentDislikes = function (technology) {
        technology.dislikes++;
    }
};
//****Events in Angular***//


myapp.controller("employeesController", employeesController);
myapp.controller("statesController", statesController);
myapp.controller("technologiesController", technologiesController);

//****Or we can use this also***//
//*******One chain method and one normal control adition is also supproted**********/
//var myapp = new angular.module("myModule", []);
//var myController = function ($scope) {
//    $scope.message = "Angular tutorial will be shown in the web page..Assign the message variablewhat u need to diplay"
//};
//var employeeController = function ($scope) {   
//    var employee = {
//        firstname: 'Manas',
//        lastname: 'Panda',
//        gender: 'Male'
//    };
//    $scope.employee = employee;
//};

//myapp.controller("myController", myController);
//myapp.controller("employeeController", employeeController);
