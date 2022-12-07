$(document).ready(function () {

    let date = $('#dateId').text();
    let serviceUrl = $('#serviceUrl').attr("data-url");;

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: serviceUrl + date,
        success: function (result) {
            console.log(result)
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(function () {
                drawChartWithCurrencyChart(result.allDataWithExchange);
            });
            drawChartWithCurrencyChartByPaymentName(result.allDataWithPaymentMethod);
        }
    });

});

function drawChartWithCurrencyChart(result) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Currency');
    data.addColumn('number', 'Total Price');
    var dataArray = [];

    $.each(result, function (i, obj) {
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
        .getElementById('allDataWithExchange'));

    columnChart.draw(data, columnChartOptions);

}

function drawChartWithCurrencyChartByPaymentName(result) {
  

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

    var chart = new ApexCharts(document.querySelector("#allDataWithPaymentMethod"), options);
    chart.render();


}

