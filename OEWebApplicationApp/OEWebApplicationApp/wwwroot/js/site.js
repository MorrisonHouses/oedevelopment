function printscreen() {
    window.print();
}

function generatePDF() {
    var element = document.getElementById('ObjectToPrint');
    var invoiceId = document.getElementById('InvoiceId').outerHTML;
    var opt = {
        margin: 0.25,
        filename: invoiceId+'myfile.pdf',
        image: { type: 'jpeg', quality: 1 },
        html2canvas: { scale: 1 },
        jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait', precision: '12' }

    };
    html2pdf().set(opt).from(element).save();
}