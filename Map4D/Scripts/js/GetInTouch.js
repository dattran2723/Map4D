$(document).ready(function () {
    $("#btn-submit").click(function () {
        setTimeout(function () {
            var arrayError = [$('#your-name-error').text()
                , $('#your-email-error').text()
                , $('#subject-error').text()
                , $('#message-error').text()];
            if (arrayError != null) {
                var showError = "";
                for (i = 0; i < arrayError.length; i++) {
                    if (arrayError[i] != "")
                        showError = showError + arrayError[i] + "\n";
                }
                if (showError != "") {
                    swal("", showError, "warning");
                }
            }
        }, 100);
    });
})