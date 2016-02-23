Ember.Application.initializer({
    name: 'injectDependencies',

    initialize: function (container, application) {

    }
});

window.WebMP = Ember.Application.create({
    ready: function() {
        Ember.$.ajaxSetup({
            error: function (xhr) {
                if (xhr.status === 401) {
                    window.location.replace('/');
                }
                if (xhr.status === 403 && xhr.responseJSON && xhr.responseJSON.incompleteProfile) {
                    window.location.replace('/register/quickfacts?new=true');
                }
            }
        });
    }
});
