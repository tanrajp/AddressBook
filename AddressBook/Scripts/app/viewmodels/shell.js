define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        activate: function () {
            router.map([
                { route: '', title: 'Address List', moduleId: 'viewmodels/show', nav: true },
                { route: '', title: 'Contact List', moduleId: 'viewmodels/contacts', nav:true}
            ]).buildNavigationModel();

            return router.activate();
        }
    };
});