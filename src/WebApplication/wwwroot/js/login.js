﻿(function (app) {

  var usersURL = "/api/v1/users";

  app.login = function () {

    var data = {
      email: $("#email").val(),
      password: $("#password").val()
    };

    callAPI(`${usersURL}/login`, "POST", data, function (authToken) {

      localStorage.setItem("auth-token", authToken);
      window.location.href = "/";

    }, function (error) {

      var responseJson = error.responseJSON;

      $("#errors").empty();

      ["Email", "Password", "errors"].forEach(function (s) {
        if (responseJson[s] !== undefined) {
          showErrors(responseJson[s]);
        }
      });
    });
  };

  app.logout = function () {
    localStorage.removeItem("auth-token");
    window.location.href = "/";
  };

  app.generateQrCode = function () {

    callAPI(`${usersURL}/authenticator-uri`, "GET", null, function (authenticatorUri) {

      if (authenticatorUri === undefined) {
        callAPI(`${usersURL}/authenticator-key`, "PUT", null, function () {
          callAPI(`${usersURL}/authenticator-uri`, "GET", null, function (authenticatorUri) {
            generateQrCode(authenticatorUri);
          });
        });
      } else {
        generateQrCode(authenticatorUri);
      }
    });
  };

  function showErrors(errors) {

    var $errors = $("#errors");

    errors.forEach(function (error) {
      $errors.append(
        $("<li>").append(error)
      );
    });
  }

  function generateQrCode(authenticatorUri) {
    new QRCode($("#qrCode")[0],
      {
        text: authenticatorUri,
        width: 150,
        height: 150
      });
  }

  function callAPI(url, method, data, successCallback, errorCallback) {
    $.ajax({
      beforeSend: function (request) {
        request.setRequestHeader("Authorization", `Bearer ${localStorage.getItem("auth-token")}`);
      },
      url: url,
      type: method,
      contentType: 'application/json',
      data: JSON.stringify(data),
      success: successCallback,
      error: errorCallback
    });
  }

})(app = window.app || {});