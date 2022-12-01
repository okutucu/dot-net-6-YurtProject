$(document).ready(function () {

    let date = $('#dateId').text();
    let visualizeRoomRentResultUrl = "/ManagmentReport/VisualizeRoomRentResult?selectedDate=";
    let visualizeIncomesResultUrl = "/ManagmentReport/VisualizeOtherIncomesResult?selectedDate=";
    let visualizePaymentResultUrl = "/ManagmentReport/VisualizePaymentResult?selectedDate=";
    let visualizeAllPaymentResult = "/ManagmentReport/VisualizeAllPaymentResult?selectedDate=";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeAllPaymentResult + date,
        success: function (dataAllPayment) {
            drawChartAllIncomes(dataAllPayment);
        }
    });

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
            drawChartRoomRentallincomeByPaymentName(result.allRentIncomesWithPaymentMethod);
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
            drawChartIncomeDetailByPaymentName(result.allIncomesDetailWithPaymentMethod);
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
            drawChartRoomPaymentDetailByPaymentName(result.allpaymentDetailWithPaymentMethod);
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
function drawChartRoomRentallincomeByPaymentName(result) {

    var raw = result,
        nameIndices = Object.create(null),
        statusHash = Object.create(null),
        data = { labels: [], datasets: [] };

    raw.forEach(function (o) {
        if (!(o.paymentMethod in nameIndices)) {
            nameIndices[o.paymentMethod] = data.labels.push(o.paymentMethod) - 1;
            data.datasets.forEach(function (a) { a.data.push(0); });
        }
        if (!statusHash[o.exchange]) {
            statusHash[o.exchange] = { label: o.exchange, fillcolor: 'f00', data: data.labels.map(function () { return 0; }) };
            data.datasets.push(statusHash[o.exchange]);
        }
        statusHash[o.exchange].data[nameIndices[o.paymentMethod]] = o.sum;
    });



    let euroArray = [];
    let tlArray = [];
    let dollarArray = [];
    let sterlingArray = [];

    $.each(data.datasets, function (i, obj) {
        if (obj.label === 'Dollar') {
            $.each(obj.data, function (k, item) {
                dollarArray.push(item);
            });
        }
        if (obj.label === 'Tl') {
            $.each(obj.data, function (k, item) {
                tlArray.push(item);
            });
        }
        if (obj.label === 'Euro') {
            $.each(obj.data, function (k, item) {
                euroArray.push(item);
            });
        }
        if (obj.label === 'Sterling') {
            $.each(obj.data, function (k, item) {
                sterlingArray.push(item);
            });
        }
    });



    var options = {
        series: [{
            name: 'Euro',
            data: euroArray
        }, {
            name: 'Dollar',
            data: dollarArray
        }, {
            name: 'Sterling',
            data: sterlingArray
        }, {
            name: 'Tl',
            data: tlArray
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
            categories: data.labels,
        },
        yaxis: {
            title: {
                text: 'Rent & Price (sum)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return val + " Payment Detail"
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
function drawChartIncomeDetailByPaymentName(result) {
    var raw = result,
        nameIndices = Object.create(null),
        statusHash = Object.create(null),
        data = { labels: [], datasets: [] };

    raw.forEach(function (o) {
        if (!(o.paymentMethod in nameIndices)) {
            nameIndices[o.paymentMethod] = data.labels.push(o.paymentMethod) - 1;
            data.datasets.forEach(function (a) { a.data.push(0); });
        }
        if (!statusHash[o.exchange]) {
            statusHash[o.exchange] = { label: o.exchange, fillcolor: 'f00', data: data.labels.map(function () { return 0; }) };
            data.datasets.push(statusHash[o.exchange]);
        }
        statusHash[o.exchange].data[nameIndices[o.paymentMethod]] = o.sum;
    });



    let euroArray = [];
    let tlArray = [];
    let dollarArray = [];
    let sterlingArray = [];

    $.each(data.datasets, function (i, obj) {
        if (obj.label === 'Dollar') {
            $.each(obj.data, function (k, item) {
                dollarArray.push(item);
            });
        }
        if (obj.label === 'Tl') {
            $.each(obj.data, function (k, item) {
                tlArray.push(item);
            });
        }
        if (obj.label === 'Euro') {
            $.each(obj.data, function (k, item) {
                euroArray.push(item);
            });
        }
        if (obj.label === 'Sterling') {
            $.each(obj.data, function (k, item) {
                sterlingArray.push(item);
            });
        }
    });



    var options = {
        series: [{
            name: 'Euro',
            data: euroArray
        }, {
            name: 'Dollar',
            data: dollarArray
        }, {
            name: 'Sterling',
            data: sterlingArray
        }, {
            name: 'Tl',
            data: tlArray
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
            categories: data.labels,
        },
        yaxis: {
            title: {
                text: 'Rent & Price (sum)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return val + " Payment Detail"
                }
            }
        }
    };

    var chart = new ApexCharts(document.querySelector("#otherIncomePaymentChart"), options);
    chart.render();
 
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
function drawChartRoomPaymentDetailByPaymentName(result) {


    var raw = result ,
        nameIndices = Object.create(null),
        statusHash = Object.create(null),
        data = { labels: [], datasets: [] };



    raw.forEach(function (o) {
        if (!(o.paymentMethod in nameIndices)) {
            nameIndices[o.paymentMethod] = data.labels.push(o.paymentMethod) - 1;
            data.datasets.forEach(function (a) { a.data.push(0); });
        }
        if (!statusHash[o.exchange]) {
            statusHash[o.exchange] = { label: o.exchange, fillcolor: 'f00', data: data.labels.map(function () { return 0; }) };
            data.datasets.push(statusHash[o.exchange]);
        }
        statusHash[o.exchange].data[nameIndices[o.paymentMethod]] = o.sum;
    });


    let euroArray = [];
    let tlArray = [];
    let dollarArray = [];
    let sterlingArray = [];

    $.each(data.datasets, function (i, obj) {
        if (obj.label === 'Dollar') {
            $.each(obj.data, function (k, item) {
                dollarArray.push(item);
            });
        }
        if (obj.label === 'Tl') {
            $.each(obj.data, function (k, item) {
                tlArray.push(item);
            });
        }
        if (obj.label === 'Euro') {
            $.each(obj.data, function (k, item) {
                euroArray.push(item);
            });
        }
        if (obj.label === 'Sterling') {
            $.each(obj.data, function (k, item) {
                sterlingArray.push(item);
            });
        }
    });

 

    var options = {
        series: [{
            name: 'Euro',
            data: euroArray
        }, {
            name: 'Dollar',
            data: dollarArray
        }, {
            name: 'Sterling',
            data: sterlingArray
        }, {
            name: 'Tl',
            data: tlArray
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
            categories: data.labels,
        },
        yaxis: {
            title: {
                text: 'Rent & Price (sum)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return val + " Payment Detail"
                }
            }
        }
    };

    var chart = new ApexCharts(document.querySelector("#paymentDetailPaymentChart"), options);
    chart.render();
}




function drawChartAllIncomes(dataAllPayment) {


    var sumAllArray = [];
    //todo


    sumAllArray = $.merge(dataAllPayment.incomesExchange, dataAllPayment.rentExchange);

    var totalIncomesArray = [];
    var totalPaymentArray = [];
    totalIncomesArray = sumAllArray;
    totalIncomesArray = dataAllPayment.paymentExchange;

    console.log(totalIncomesArray);
    console.log(totalPaymentArray);


    let response = [];

    const process = () =>
        sumAllArray.forEach((r) => {
            const found = response.find(
                (a) =>
                    
                    a.exchange == r.exchange
            );
            if (found) {
                found.sum += r.sum;
            } else {
                response.push({ ...r });
            }
     });
    process();

    
    var chartSumAllArray = [];
    chartSumAllArray = $.merge(sumAllArray, dataAllPayment.paymentExchange);


    var raw = chartSumAllArray,
        nameIndices = Object.create(null),
        statusHash = Object.create(null),
        data = { labels: [], datasets: [] };

    raw.forEach(function (o) {
        if (!(o.exchange in nameIndices)) {
            nameIndices[o.exchange] = data.labels.push(o.exchange) - 1;
            data.datasets.forEach(function (a) { a.data.push(0); });
        }
        if (!statusHash[o.paymentType]) {
            statusHash[o.paymentType] = { label: o.paymentType, fillcolor: 'f00', data: data.labels.map(function () { return 0; }) };
            data.datasets.push(statusHash[o.paymentType]);
        }
        statusHash[o.paymentType].data[nameIndices[o.exchange]] += o.sum;
    });




    let incomesArray = [];
    let paymentsArray = [];


    $.each(data.datasets, function (i, obj) {
        if (obj.label === 'Total Incomes') {
            $.each(obj.data, function (k, item) {
                incomesArray.push(item);
            });
        }
        if (obj.label === 'Total Payment') {
            $.each(obj.data, function (k, item) {
                paymentsArray.push(item);
            });
        }
    });


    var options = {
        series: [{
            name: 'Incomes',
            data: incomesArray
        }, {
            name: 'Payments',
            data: paymentsArray
        }],
        chart: {
            type: 'bar',
            height: 430
        },
        plotOptions: {
            bar: {
                horizontal: false,
                dataLabels: {
                    position: 'top',
                },
            }
        },
        dataLabels: {
            enabled: true,
            offsetX: 0,
            style: {
                fontSize: '12px',
                colors: ['#fff']
            }
        },
        stroke: {
            show: true,
            width: 1,
            colors: ['#fff']
        },
        tooltip: {
            shared: true,
            intersect: false
        },
        xaxis: {
            categories: data.labels,
        },
    };

    var chart = new ApexCharts(document.querySelector("#allIncomeCurrencyChart"), options);
    chart.render();
}


function getTotalBalance(chartSumArray) {

    let totalBalanceDiv = $("#totalBalance");
    

    var helper = {};
    var result = chartSumArray.reduce(function (r, o) {
        var key = o.paymentType + '-' + o.exchange;

        if (!helper[key]) {
            helper[key] = Object.assign({}, o); 
            r.push(helper[key]);
        } else {
            helper[key].sum += o.sum;
        }
        return r;
    }, []);




    result.sort(function (a, b) {
        if (a.exchange > b.exchange) { return 1 }
        if (a.exchange < b.exchange) { return -1 }
        return 0;
    });


    $.each(result, function (i, obj) {
        if (obj.paymentType === "Total Incomes") 
            $("#totalIncome").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentType === "Total Payment")
            $("#totalPayment").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });

}