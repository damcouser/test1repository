WebMP.Start = Ember.Object.extend({
    text: 'N/A'
});

WebMP.Start.reopenClass(WebMP.Api, {
    make: function (obj) {
        return WebMP.Start.create({
            text: obj.text
        });
    }
});
