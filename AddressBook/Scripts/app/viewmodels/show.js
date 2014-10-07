define(['durandal/app', 'knockout', 'jquery', 'viewmodels/contacts'], function (app, ko, $, Contacts) {

    var vm = function() {
        var self = this;

        this.addressList = ko.observableArray();
        this.selectedCity = ko.observable();
        this.contactList = ko.observableArray();
        this.currentContact = ko.observable();
        


        this.activate = function() {
            $.getJSON('api/Address')
                .done(function(data) {
                    self.addressList(data);
                });
        };

        this.openDetails = function(id) {
            $.getJSON('api/contact/' + addressList().Id)
                .done(function (data) {
                    self.currentContact(new Contacts(data));
                });
        };


    };

    return vm;


});