WebMP.Api = Ember.Mixin.create({
    postJSON: function (url, data) {
        var settings = { url: url, type: 'POST', data: JSON.stringify(data) };
        return this.ajax(settings);
    },
    putJSON: function (url, data) {
        var settings = { url: url, type: 'put', data: JSON.stringify(data) };
        return this.ajax(settings);
    },
    getJSON: function (url) {
        var settings = { url: url, type: 'GET' };
        return this.ajax(settings);
    },
    ajax: function (settings) {
        settings.dataType = 'json';
        settings.contentType = 'application/json; charset=UTF-8';
        settings.dataFilter = function (data, type) {
            return data === '' ? null : data;
        };
        return Ember.RSVP.Promise.resolve(Ember.$.ajax(settings));
    },
    getScript: function(url) {
        return Ember.RSVP.Promise.resolve($.getScript(url));
    },
    getText: function(url) {
        return Ember.RSVP.Promise.resolve($.ajax({ url: url, dataType: 'text' }));
    }
});