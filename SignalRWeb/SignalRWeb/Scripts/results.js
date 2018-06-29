(function () {
    var resultHub = $.connection.resultHub;
    $.connection.hub.logging = true;
    $.connection.hub.start();

    resultHub.client.hello = function () {

    }
    resultHub.client.registerMessage = function (message) {

    };
})