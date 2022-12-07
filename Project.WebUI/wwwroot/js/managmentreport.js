$(document).ready(function () {

    let date = $('#dateId').text();

    let visualizeAllPaymentResult = "/ManagmentReport/VisualizeAllPaymentResult?selectedDate=";
    let visualizeAllPaymentWithPaymentNameResult = "/ManagmentReport/VisualizeAllPaymentWithPaymentMethodResult?selectedDate=";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeAllPaymentWithPaymentNameResult + date,
        success: function (dataResult) {
            drawChartRoomAllPaymentWithPaymentName(dataResult);
            drawChartRoomAllPaymentDetailWithPaymentName(dataResult.paymentExchangeWithPaymentName);
            getTotalBalanceWithPaymentName(dataResult);
        }
    });
    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: visualizeAllPaymentResult + date,
        success: function (dataAllPayment) {
            drawChartAllIncomes(dataAllPayment);
            getTotalBalance(dataAllPayment);
            
        }
    });

 

    
});



function drawChartAllIncomes(dataAllPayment) {


    var sumAllArray = $.merge($.merge([], dataAllPayment.incomesExchange), dataAllPayment.rentExchange);
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

    var chartSumAllArray = $.merge($.merge([], sumAllArray), dataAllPayment.paymentExchange);



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
function drawChartRoomAllPaymentWithPaymentName(dataResult) {
    var sumAllIncomeArray = $.merge($.merge([], dataResult.incomeExchangeWithPaymentName), dataResult.rentExchangeWithPaymentName);

    var helper = {};
    var result = sumAllIncomeArray.reduce(function (r, o) {
        var key = o.paymentMethod + '-' + o.exchange;

        if (!helper[key]) {
            helper[key] = Object.assign({}, o);
            r.push(helper[key]);
        } else {
            helper[key].sum += o.sum;
        }
        return r;
    }, []);


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
                text: 'All Income & Price (sum)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return val
                }
            }
        }
    };
    var chart = new ApexCharts(document.querySelector("#allIncomeCurrencyWithPaymentNameChart"), options);
    chart.render();
}


function drawChartRoomAllPaymentDetailWithPaymentName(dataResult) {

 

    let response = [];

    const process = () =>
        dataResult.forEach((r) => {
            const found = response.find(
                (a) =>
                    a.paymentMethod == r.paymentMethod,

            );
            if (found) {
                found.sum += r.sum;
            } else {
                response.push({ ...r });
            }
        });
    process();

    var raw = dataResult,
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
                text: 'All Income & Price (sum)'
            }
        },
        fill: {
            opacity: 1
        },
        tooltip: {
            y: {
                formatter: function (val) {
                    return val
                }
            }
        }
    };
    var chart = new ApexCharts(document.querySelector("#allPaymentCurrencyWithPaymentNameChart"), options);
    chart.render();


        
}


function getTotalBalance(dataAllPayment) {



    var allIncomesArray = $.merge($.merge([], dataAllPayment.incomesExchange), dataAllPayment.rentExchange);
    var allPaymentArray = $.merge([], dataAllPayment.paymentExchange);
    var allTotalBalanceArray = $.merge($.merge([], allIncomesArray), allPaymentArray);


    var helper = {};
    var result = allTotalBalanceArray.reduce(function (r, o) {
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



    compare(allIncomesArray, allPaymentArray)

    if (allIncomesArray.length == 0) {
        $("#totalIncome").append(` <p> Veri Yok</p> `)
    }


    $.each(result, function (i, obj) {
        if (obj.paymentType === "Total Incomes")
        {
            $("#totalIncome").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        }
        else if (obj.paymentType === "Total Payment")
            $("#totalPayment").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });


}

function getTotalBalanceWithPaymentName(dataResult)
{

    var allIncomesArray = $.merge($.merge([], dataResult.incomeExchangeWithPaymentName), dataResult.rentExchangeWithPaymentName);
    var allPaymentArray = $.merge([], dataResult.paymentExchangeWithPaymentName);

    var helper = {};
    var result = allIncomesArray.reduce(function (r, o) {
        var key = o.paymentMethod + '-' + o.exchange;

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
        if (obj.paymentMethod === "Cash") 
          $("#totalCash").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "Eft")
          $("#totalEft").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "CreditCart")
            $("#totalCreditKart").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });

    var paymentHelper = {};
    var paymentResult = allPaymentArray.reduce(function (r, o) {
        var key = o.paymentMethod + '-' + o.exchange;

        if (!paymentHelper[key]) {
            paymentHelper[key] = Object.assign({}, o);
            r.push(paymentHelper[key]);
        } else {
            paymentHelper[key].sum += o.sum;
        }
        return r;
    }, []);



    paymentResult.sort(function (a, b) {
        if (a.exchange > b.exchange) { return 1 }
        if (a.exchange < b.exchange) { return -1 }
        return 0;
    });

    $.each(paymentResult, function (i, obj) {
        if (obj.paymentMethod === "Cash")
            $("#totalCashPayment").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "Eft")
            $("#totalEftPayment").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "CreditCart")
            $("#totalCreditKartPayment").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });

    compareWithPaymentMethod(result, paymentResult);

}


function compare(allIncomesArray, allPaymentArray) {

    var helper = {};
    var totalIncomeResult = allIncomesArray.reduce(function (r, o) {
        var key = o.paymentType + '-' + o.exchange;

        if (!helper[key]) {
            helper[key] = Object.assign({}, o);
            r.push(helper[key]);
        } else {
            helper[key].sum += o.sum;
        }
        return r;
    }, []);



    $.each(totalIncomeResult, function (i, obj) {
        delete obj['paymentType'];

    });
    $.each(allPaymentArray, function (i, obj) {
        obj['sum'] = (obj.sum * -1);
        delete obj['paymentType'];

    });

    var totalBalanceArray = $.merge($.merge([], totalIncomeResult), allPaymentArray);


    var helper1 = {};

    var newResult = totalBalanceArray.reduce(function (r, o) {
        var key = o.exchange;

        if (!helper1[key]) {
            helper1[key] = Object.assign({}, o); // create a copy of o
            r.push(helper1[key]);
        } else {
            helper1[key].sum += o.sum;
        }

        return r;
    }, []);


    newResult.sort(function (a, b) {
        if (a.exchange > b.exchange) { return 1 }
        if (a.exchange < b.exchange) { return -1 }
        return 0;
    });



    $.each(newResult, function (i, obj) {
        $("#totalBalance").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });



}

function compareWithPaymentMethod(allIncomesWithPaymentMethod, allPaymentWithPaymentMethod) {

    $.each(allIncomesWithPaymentMethod, function (i, obj) {
        delete obj['paymentType'];

    });
    $.each(allPaymentWithPaymentMethod, function (i, obj) {
        obj['sum'] = (obj.sum * -1);
        delete obj['paymentType'];
    });

    var totalBalanceWithPaymentMethodArray = $.merge($.merge([], allIncomesWithPaymentMethod), allPaymentWithPaymentMethod);

    var totalBalanceHelper = {};

    var totalBalanceResult = totalBalanceWithPaymentMethodArray.reduce(function (r, o) {
        var key = o.paymentMethod + '-' + o.exchange;

        if (!totalBalanceHelper[key]) {
            totalBalanceHelper[key] = Object.assign({}, o);
            r.push(totalBalanceHelper[key]);
        } else {
            totalBalanceHelper[key].sum += o.sum;
        }
        return r;
    }, []);


    totalBalanceResult.sort(function (a, b) {
        if (a.exchange > b.exchange) { return 1 }
        if (a.exchange < b.exchange) { return -1 }
        return 0;
    });


    $.each(totalBalanceResult, function (i, obj) {
        if (obj.paymentMethod === "Cash")
            $("#totalCashBalance").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "Eft")
            $("#totalEftBalance").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
        else if (obj.paymentMethod === "CreditCart")
            $("#totalKreditKartBalance").append(` <p>${obj.exchange}  :   ${obj.sum}</p> `)
    });


}