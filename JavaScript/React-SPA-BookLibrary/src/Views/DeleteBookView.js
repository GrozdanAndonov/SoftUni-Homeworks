/**
 * Created by Grozdan on 24.4.2017 г..
 */
import React, {Component} from "react";
export default class DeleteBookView  extends Component{
    render(){
        return(<form className="delete-book-form" onSubmit={this.submitForm.bind(this)}>
            <h1>Create Book</h1>
            <label>
                <div>Title:</div>
                <input type="text" readOnly value={this.props.name}/>
            </label>
            <label>
                <div>Author:</div>
                <input type="text" readOnly value={this.props.author}/>
            </label>
            <label>
                <div>Description:</div>
                <textarea rows="10" readOnly value={this.props.description}></textarea>
            </label>
            <div>
                <h1>Are you sure you want to delete this book?</h1>
                <input type="submit" value="Delete"/>
            </div>
        </form>)
    }
    submitForm(event){
        event.preventDefault();
        this.props.onsubmit(this.props.bookId);
    }
}