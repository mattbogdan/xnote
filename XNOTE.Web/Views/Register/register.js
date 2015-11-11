$(document).ready(function () { //TODO: use RequireJS (or not?)

    var tokenKey = "tokenInfo";

    function RegisterViewModel() {
        var self = this;

        this.email = ko.observable("");
        this.password = ko.observable("");
        this.confirmPassword = ko.observable("");

        this.register = function () {
            $.ajax({
                url: 'http://localhost:38503/api/Account/Register',
                type: 'POST',
                data:
                    {
                        Email: this.email,
                        Password: this.password,
                        ConfirmPassword: this.confirmPassword,
                    },

                success: function (data) {
                    $("#error_message").hide();
                    $(".validation-summary-errors").hide();

                    sessionStorage.setItem(tokenKey, data.access_token);

                    alert("Welcome, " + self.email());

                    //TODO: put here default main page address
                    window.location.href = "/Views/Main/main.html";

                },
                error: function (data) {
                    var errors = [];

                    alert("Unknown error!");

                    $("#error_message").hide();
                    $(".validation-summary-errors").show();

                    var response = JSON.parse(data.responseText);
                    for (key in response.modelState) {
                        for (var i = 0; i < response.modelState[key].length; i++) {
                            errors.push(response.modelState[key][i]);
                        }
                    }

                    $("#error_details").text(" " + errors.join(" "));

                    if (errors.length > 0) {
                        $("#error_message").show();
                        $(".validation-summary-errors").hide();
                    }
                }
            });
        }
    }


    ko.applyBindings(new RegisterViewModel());
});