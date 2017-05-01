/**
 * Created by Grozdan on 24.4.2017 г..
 */
import React, {Component} from "react";
export default class EditBookView  extends Component{
    render(){
        return(<form className="edit-book-form" onSubmit={this.submitForm.bind(this)}>
            <h1>Create Book</h1>
            <label>
                <div>Title:</div>
                <input type="text" defaultValue={this.props.name} required ref={e=>this.titleField=e}/>
            </label>
            <label>
                <div>Author:</div>
                <input type="text" defaultValue={this.props.author}  required ref={e=>this.authorField=e}/>
            </label>
            <label>
                <div>Description:</div>
                <textarea rows="10" defaultValue={this.props.description} ref={e=>this.descriptionField=e}></textarea>
            </label>
            <div>
                <input type="submit" value="Edit"/>
            </div>
        </form>)
    }
    submitForm(event){
        event.preventDefault();
        this.props.onsubmit(this.props.bookId, this.titleField.value,this.authorField.value,this.descriptionField.value);
    }
}