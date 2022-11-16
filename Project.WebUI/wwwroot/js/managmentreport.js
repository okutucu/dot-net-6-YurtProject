$(document).ready(function () {

    let date = $('#dateId').text();
    let visualizeRoomRentResultUrl = "/ManagmentReport/VisualizeRoomRentResult?selectedDate=";
    let visualizeIncomesResultUrl = "/ManagmentReport/VisualizeOtherIncomesResult?selectedDate=";
    let visualizePaymentResultUrl = "/ManagmentReport/VisualizePaymentResult?selectedDate=";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeRoomRentResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
             google.charts.setOnLoadCallback(function () {
                 drawChartWithRoomRent(result);
             });
                drawChartRoomRentalincomeByPaymentName(result.allRentIncomesWithPaymentMethod);
           
        }
    });
    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeIncomesResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(function () {
                drawChartWithIncomesDetail(result);
            });
        }
    });
    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizePaymentResultUrl + date,
        success: function (result) {
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(function () {
                drawChartWithPaymentDetail(result);
            });
   
        }
    });


});

function drawChartWithRoomRent(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allRentIncomesWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Currency & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('rentIncomeCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}


function drawChartRoomRentalincomeByPaymentName(result) {

    var dataArray = [];
    var cashArray = [];
    var creditCartArray = [];
    var eftArray = [];
    var sterlingArray = [];

    $.each(result, function (i, obj) {
        dataArray.push(obj.paymentMethod);
    });

    console.log(result)

    $.each(result, function (i, obj) {
        console.log(obj.paymentDetail)
        $.each(obj.paymentDetail, function (i, payment) {


          
 
        });
    });




   

    var options = {
        series: [{
            name: 'Euro',
            data: [44, 55, 57]
        }, {
            name: 'Dollar',
            data: [76, 85, 101]
        }, {
            name: 'Sterling',
            data: [35, 41, 31]
        }, {
            name: 'Tl',
            data: [35, 41, 31]
        }],
        chart: {
            type: 'bar',
            height: 350
        },
        plotOptions: {
            bar: {
                horizontal: false,
                columnWidth: '55%',
                endingShape: 'rounded'
            },
        },
        dataLabels: {
            enabled: false
        },
        stroke: {
            show: true,
            width: 2,
            colors: ['transparent']
        },
        xaxis: {
            categories: dataArray,
        },
        yaxis: {
            title: {
                text: '$ (thousands)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return  val + " rent incomes"
                }
            }
        }
    };

    var chart = new ApexCharts(document.querySelector("#rentIncomePaymentChart"), options);
    chart.render();


}


function drawChartWithIncomesDetail(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allIncomesDetailWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Other Income & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('othertIncomeCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}

function drawChartWithPaymentDetail(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result.allPaymentDetailWithExchange, function (i, obj) {
        dataArray.push([obj.exchange, obj.sum]);
    });
    data.addRows(dataArray);

    var columnChartOptions = {
        title: "Payment Detail & Price Chart",
        width: 1000,
        height: 400,
        bar: { groupWidth: "20%" },
    };

    var columnChart = new google.visualization.PieChart(document
        .getElementById('paymentDetailCurrencyChart'));

    columnChart.draw(data, columnChartOptions);

}



