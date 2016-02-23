WebMP.MessageRoute = Ember.Route.extend(WebMP.Api, {
	model: function (params) {
		var url = '/api/message?id=' + params.id;

        return this.getJSON(url)
            .then(function (data) {
                return WebMP.Message.make(data);
            });
	}
});
