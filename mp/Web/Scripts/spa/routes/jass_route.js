WebMP.JassRoute = Ember.Route.extend(WebMP.Api, {
	model: function (params) {
		var url = '/api/jass?id=' + params.id;
		alert(url);
        return this.getJSON(url)
            .then(          
	    function (data) {
                 return WebMP.Jass.make(data);
	    });
        alert(data);
	}
});
