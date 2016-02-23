WebMP.StartController = WebMP.BaseController.extend({
    username: 'Lilla My',
    password: 'Moomin',

    actions: {
        login: function () {
            var self = this;

            self.postJSON('/api/user/login', { username: this.get('username'), password: this.get('password') })
                .then(function (result) {
                    self.transitionTo('messages', 0);
                })['catch'](function () {
                    alert('error');
                });

        }
    }
});
