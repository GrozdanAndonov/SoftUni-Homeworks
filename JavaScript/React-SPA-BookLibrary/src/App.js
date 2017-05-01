import React, { Component } from 'react';
import Footer from "./Components/Footer";
import NavigationBar from "./Components/NavigationBar";
import ReactDOM from "react-dom";
import $ from "jquery";
import KinveyRequester from "./KinveyRequester";

import Home from "./Views/HomeView";
import Login from "./Views/LoginView";
import Register from "./Views/RegisterView";
import ListBooks from "./Views/ListBooksView";
import CreateBook from "./Views/CreateBookView";
import EditBook from "./Views/EditBookView";
import DeleteBook from "./Views/DeleteBookView";

import './App.css';

export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            username: null,
            userId: null
        };
    }
    componentDidMount() {
        // Attach global AJAX "loading" event handlers
        $(document).on({
            ajaxStart: function () {
                $("#loadingBox").show();
            },
            ajaxStop: function () {
                $("#loadingBox").hide();
            }
        });
        this.setState({
            username: sessionStorage.getItem("username"),
            userId: sessionStorage.getItem("userId")
        });
        // Attach a global AJAX error handler
        $(document).ajaxError(
            this.handleAjaxError.bind(this));

        this.showHomeView();

        $("#errorBox, #infoBox").click(function () {
            $(this).hide();
        });

    }
    handleAjaxError(event, response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error.";
        if (response.responseJSON &&
            response.responseJSON.description)
            errorMsg = response.responseJSON.description;
        this.showError(errorMsg);
    }
    showInfo(message) {
        $('#infoBox').text(message).show();
        setTimeout(function() {
            $('#infoBox').fadeOut();
        }, 3000);
    }
    showError(errorMsg) {
        $('#errorBox').text("Error: " + errorMsg).show();
    }
    render() {
        return (
            <div className="app">
                <header>
                    <NavigationBar
                        username={this.state.username}
                        userId={this.state.userId}
                        homeClicked={this.showHomeView.bind(this)}
                        loginClicked={this.showLoginView.bind(this)}
                        registerClicked={this.showRegisterView.bind(this)}
                        booksClicked={this.showBooksView.bind(this)}
                        createBookClicked={this.createBookView.bind(this)}
                        logOutClicked={this.logOut.bind(this)}
                    />
                </header>
                <div id="errorBox">Error!</div>
                <div id="infoBox">Info!</div>
                <div id="loadingBox">Loading...</div>
                <div id="main">
                </div>
                <Footer/>
            </div>
        );
    }

    showView(component){
            ReactDOM.render(component,document.getElementById("main"));
            $('#errorBox').hide();
        }
    showBooksView(){
        KinveyRequester.loadBooks()
            .then(loadBooksSuccess.bind(this));
        function loadBooksSuccess(books) {
            this.showInfo("Books loaded!");
            this.showView(<ListBooks
                books={books}
                onEdit={this.loadBookForEdit.bind(this)}
                onDelete={this.loadBookForDelete.bind(this)}
               />);
        }
    }
    createBookView(){
        this.showView(<CreateBook createBook={this.createBook.bind(this)}/>)
    }
    loadBookForEdit(bookId){
     KinveyRequester.findBookById(bookId)
         .then(FindBookSuccess.bind(this));
     function FindBookSuccess(book) {
         this.showView(<EditBook
             bookId={book._id}
             name={book.Name}
            author={book.Author}
             description={book.description}
             onsubmit={this.editBook.bind(this)}
         />);
     }
    }
    loadBookForDelete(bookId){
        KinveyRequester.findBookById(bookId)
            .then(FindBookSuccess.bind(this));
        function FindBookSuccess(book) {
            this.showView(<DeleteBook
                bookId={book._id}
                name={book.Name}
                author={book.Author}
                description={book.description}
                onsubmit={this.deleteBook.bind(this)}
            />);
        }
    }
    deleteBook(bookId){
        KinveyRequester.deleteBook(bookId)
            .then(deleteBookSuccess.bind(this));
        function deleteBookSuccess() {
            this.showInfo("Book deleted!");
            this.showBooksView();
        }
    }
    editBook(bookId,Name,Author,description){
        KinveyRequester.editBook(bookId,Name,Author,description)
            .then(editBookSuccess.bind(this));
        function editBookSuccess() {
            this.showInfo("Book edited!");
            this.showBooksView();
        }
    }
    createBook(title,author,description){
        KinveyRequester.createBook(title,author,description)
            .then(createBookSuccess.bind(this));
        function createBookSuccess() {
            this.showInfo("Book created!");
            this.showBooksView();
        }
    }
  showLoginView(){
      this.showView(<Login onsubmit={this.login.bind(this)}/>);
  }
    login(username,password){
       KinveyRequester.loginUser(username,password)
           .then(loginSuccess.bind(this));
       function loginSuccess(Info) {
           this.saveAuthInSession(Info);
           this.showInfo("Login successful!");
           this.showBooksView();
       }
    }
    register(username,password)
    {
        KinveyRequester.registerUser(username, password)
            .then(registerSuccess.bind(this));
        function registerSuccess(Info) {
            this.saveAuthInSession(Info);
            this.showInfo("Register successful!");
            this.showBooksView();
        }
    }
    saveAuthInSession(userInfo){
        sessionStorage.setItem("authToken",userInfo._kmd.authtoken);
        sessionStorage.setItem("userId",userInfo._id);
        sessionStorage.setItem("username",userInfo.username);
        this.setState({username:userInfo.username,userId:userInfo._id});
    }

  showHomeView(){
        this.showView(<Home username={this.state.username}/>);
  }
  showRegisterView(){
      this.showView(<Register onsubmit={this.register.bind(this)}/>);
  }
    logOut(){
        sessionStorage.clear();
        this.setState({username:null,userId:null});
        this.showHomeView();
    }
}