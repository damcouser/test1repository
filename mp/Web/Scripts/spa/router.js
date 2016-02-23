WebMP.Router.map(function () {
    this.route('start', { path: '/' });
    this.route('messages', { path: '/messages/:style' });
    this.route('message', { path: '/message/:id' });
    this.route('jass', { path: '/jass/:id' });
});
