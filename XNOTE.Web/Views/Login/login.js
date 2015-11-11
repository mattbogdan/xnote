$(document).ready(function () {

    var tokenKey = "tokenInfo";

    function LoginViewModel() {

        var self = this;

        this.username = ko.observable("");
        this.password = ko.observable("");
        this.login = function () {
            $.ajax({
                url: 'http://localhost:38503/Token',
                type: 'POST',
                contentType: 'application/x-www-form-urlencoded',
                data:
                    {
                        grant_type: 'password',
                        username: this.username,
                        password: this.password
                    },
                success: function (data) {
                    $("#error_message").hide();

                    alert("Welcome, " + self.username());

                    //TODO: put here default main page address
                    window.location.href = "/Views/Main/main.html";
                },
                error: function (data) {
                    var response = JSON.parse(data.responseText);

                    alert(response);

                    $("#error_details").text(response.error_description);
                    $("#error_message").show();
                }
            });
        }
    }

    ko.applyBindings(new LoginViewModel());
});