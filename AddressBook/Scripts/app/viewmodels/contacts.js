define(['durandal/system', 'durandal/app'], function (system, app) {
    var vm = function (obj) {
        this.id = obj.id;
        this.firstname = obj.firstname;
        this.lastname = obj.lastname;
    };

    return vm;
});