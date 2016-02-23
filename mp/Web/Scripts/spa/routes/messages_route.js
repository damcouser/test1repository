WebMP.MessagesRoute = Ember.Route.extend(WebMP.Api, {
    model: function(params) {
        var url = '/api/messages?style=' + params.style;

        return this.getJSON(url)
            .then(function (data) {
                return WebMP.Messages.make(data);
            });
    }
});
