/**
 * Created by Grozdan on 12.3.2017 г..
 */
$(document).ready(function () {

    $("#submit").click(getWeather);

    function getWeather() {
        const ulrPlaces="https://judgetests.firebaseio.com/locations.json";
        let urlConditions;
        let objCode;
        let location=document.getElementById("location").value;
       let request1=$.get({
            url:ulrPlaces,
            success:getCode,
            error:showError
        });
        function getCode(objects) {
           for(let obj of objects){
               if(obj.name==location)
               {
                   objCode=obj.code;
                   urlConditions="https://judgetests.firebaseio.com/forecast/today/"+`${obj.code}`+".json";
                   break;
               }}
            let request2=$.get({
                url:urlConditions,
                success:getCondition,
                error:showError
            });
            function getCondition(obj) {
                    let request3=$.get({
                        url:`https://judgetests.firebaseio.com/forecast/upcoming/${objCode}.json`,
                        success:getUpcoming,
                        error:showError
                    });
                    function getUpcoming() {
                      Promise.all([request1,request2,request3])
                          .then(printOnTheScreen)
                          .catch(showError);
                    }}}
        function printOnTheScreen(data) {
            $("#current").empty();
            let obj=data[1].forecast;
            let symbol =  symbolFunc(obj);
            document.getElementById("forecast").style.display="inline";
            let html=`<div class="label">Current conditions</div>`+
                `<span class="condition symbol">${symbol}</span>`+
            `<span class="condition">`+
               `<span class="forecast-data">${data[1].name}</span>`+
                    `<span class="forecast-data">${data[1].forecast.low}&#176;/${data[1].forecast.high}&#176;</span>`+
                    `<span class="forecast-data">${data[1].forecast.condition}</span>`+
                `</span>`;
            let forecast=data[2].forecast;
            let html2="";
            for(let atr of forecast) {
                symbol=symbolFunc(atr);
                html2+=`<span class="upcoming">` +
                `<span class="symbol">${symbol}</span>` +
                `<span class="forecast-data">${atr.low}&#176;/${atr.high}&#176;</span>` +
                `<span class="forecast-data">${atr.condition}</span>`+
                    `</span>`;
            }
             $("#current").append(html);
             $("#upcoming").append(html2);
        }
        function showError(error) {
             console.dir(error.status);
        }
        function symbolFunc(obj) {
            let symbol;
            switch (obj.condition){
                case "Sunny":
                    symbol = "&#x2600;"; // ☀
                    break;
                case "Partly sunny":
                    symbol = "&#x26C5;"; // ⛅
                    break;
                case "Overcast":
                    symbol = "&#x2601;"; // ☁
                    break;
                case "Rain":
                    symbol = "&#x2614;"; // ☂
                    break;
                default :
                    symbol="No such symbol!";
                    break;
            }
            return symbol;
        }}});