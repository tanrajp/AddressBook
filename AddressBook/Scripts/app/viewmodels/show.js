define(['durandal/app', 'knockout', 'jquery','bootstrap'], function (app, ko, $, bootstrap) {
    var vm = function () {
        var self = this;

        this.addressList = ko.observableArray();

        this.activate = function () {
            $.getJSON('api/Address')
                .done(function (data) {
                    self.addressList(data);
                });
        };

    };

    return vm;
});