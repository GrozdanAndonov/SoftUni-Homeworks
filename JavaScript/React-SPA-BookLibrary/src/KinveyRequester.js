/**
 * Created by Grozdan on 23.4.2017 г..
 */
import $ from "jquery";
let KinveyRequester=(function () {
const appID="kid_rJIjX_LAe";
const appSecret="b7c6167b26ee4697981e216a186f6e63";
const baseUrl="https://baas.kinvey.com/";
const appAuthHeaders={
    Authorization:"Basic "+btoa(appID+":"+appSecret)
};
    function loginUser(username,password) {
        return $.ajax({
            method:"POST",
            url:baseUrl+"user/"+appID+"/login",
            headers:appAuthHeaders,
            data:JSON.stringify({username,password}),
            contentType:"application/json"
        });

    }
    function registerUser(username,password) {
        return $.ajax({
            method:"POST",
            url:baseUrl+"user/"+appID,
            headers:appAuthHeaders,
            data:JSON.stringify({username,password}),
            contentType:"application/json"
        });
    }
    function loadBooks() {
        return $.ajax({
            method:"GET",
            url:baseUrl+"appdata/"+appID+"/Books",
            headers:getUserAuthHeaders()
        });
    }
    function getUserAuthHeaders() {
        return {
            'Authorization': "Kinvey " + sessionStorage.getItem('authToken'),
        };
    }
    function createBook(Name,Author,description) {
        return $.ajax({
            method:"POST",
            url:baseUrl+"appdata/"+appID+"/Books",
            headers:getUserAuthHeaders(),
            data:{Name,Author,description},
        });
    }
    function findBookById(bookId) {
        return $.ajax({
            method: "GET",
            url: baseUrl + "appdata/" + appID + "/Books/" + bookId,
            headers: getUserAuthHeaders()
        });
    }
    function editBook(bookId,Name,Author,description) {
        return $.ajax({
            method:"PUT",
            url:baseUrl+"appdata/"+appID+"/Books/"+bookId,
            headers:getUserAuthHeaders(),
            data:{Name,Author,description},
        });
    }
    function deleteBook(bookId) {
        return $.ajax({
            method:"DELETE",
            url:baseUrl+"appdata/"+appID+"/Books/"+bookId,
            headers:getUserAuthHeaders(),
        });
    }
    return{
        loginUser,
        registerUser,
        loadBooks,
        createBook,
        findBookById,
        editBook,
        deleteBook
        }
})();
export default KinveyRequester;