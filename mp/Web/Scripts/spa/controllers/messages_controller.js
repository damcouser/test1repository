WebMP.MessagesController = WebMP.BaseController.extend({
	actions: {
		byDate: function () {
			this.transitionTo('messages', 0);
		},

		byAuthor: function () {
			this.transitionTo('messages', 1);
		},

		byThread: function () {
		    alert('th');
		    this.transitionTo('jass', 2);
		},

		logout: function () {
			var self = this;
			self.getJSON('/api/user/logout')
				.then(function (result) {
					self.transitionTo('start');
				})['catch'](function () {
					alert('error');
				});
		},

		viewMessage: function (messageid) {
			this.transitionTo('message', messageid);
		}
	}
});
