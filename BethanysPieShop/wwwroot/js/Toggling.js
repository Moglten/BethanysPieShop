function togglePaymentPaypal() {

    var checkBox = document.getElementById("myCheck");
    var paypalbutton = document.getElementById("paypal-button-container");
    var cashondelivary = document.getElementById("cash-on-delivary");

    if (checkBox.checked == true) {
        cashondelivary.style.display = "none";
        paypalbutton.style.display = "block";

    } else {
        cashondelivary.style.display = "block";
        paypalbutton.style.display = "none";
    }

}