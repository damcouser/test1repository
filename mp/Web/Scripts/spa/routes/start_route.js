WebMP.StartRoute = Ember.Route.extend(WebMP.Api, {
    model: function() {
        var url = '/api/test';
        
        return this.getJSON(url)
                   .then(function (data) {
                       return WebMP.Start.make(data);
                 });
    }
});
