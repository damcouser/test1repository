WebMP.Messages = Ember.Object.extend({
    messages: []
});

WebMP.Messages.reopenClass(WebMP.Api, {
    make: function (obj) {
        return WebMP.Messages.create({
            messages: obj.map(WebMP.Message.make)
        });
    }
});
