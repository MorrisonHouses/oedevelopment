function totalAmount() {

    var amount = document.getElementById("amountValue");
    var GST = document.getElementById("gstValue");
    var total = amount + GST;
    document.getElementById("totalValue").innerHTML = total;
}
