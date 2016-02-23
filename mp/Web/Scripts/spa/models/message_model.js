WebMP.Message = Ember.Object.extend({
	id: undefined,
	authorId: undefined,
	threadId: undefined,
	createdDate: undefined,
	messageStatus: undefined,
	userName: undefined,	
	text: undefined
});

WebMP.Message.reopenClass(WebMP.Api, {
	make: function (obj) {
		return WebMP.Message.create({
			id: obj.messageId,
			authorId: obj.authorId,
			threadId: obj.threadId,
			createdDate: obj.createdDate,
			messageStatus: obj.messageStatus,
			userName: obj.userName,
			text: obj.text,
		});
	}
});
