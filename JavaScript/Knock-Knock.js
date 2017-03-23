/**
 * Created by Grozdan on 13.3.2017 г..
 */
const appID="kid_BJXTsSi-e";
const appSecret=" 447b8e7046f048039d95610c1b039390";
let user={
	username: "guest",
	password: "guest"
};
let authBase64=btoa("guest:guest");
let key="Knock Knock.";
function run() {

    $.ajax({
        method: "GET",
        url:`https://baas.kinvey.com/appdata/kid_BJXTsSi-e/knock?query=${key}`,
        headers: { "Authorization": "Basic " + authBase64 },
    }).then(function (data) {
        if(key=="Knock Knock.") $("body").append(`<p>${key}</p>`);
        if(data.answer!="undefined" && data.message!="undefined") {
            $("body").append(`<p>${data.answer}</p>`);
                $("body").append(`<p>${data.message}</p>`);
            key = data.message;
        }
    })
        .fail(
            function showError(error) {
                console.dir(error);
            }
        )
}
