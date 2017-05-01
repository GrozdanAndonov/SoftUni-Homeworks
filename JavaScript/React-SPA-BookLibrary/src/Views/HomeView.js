/**
 * Created by Grozdan on 21.4.2017 г..
 */
import React,{Component} from "react";
export default class Home extends Component{
    render(){
        return(<div>
          <h1>Home view</h1>
            <p>Welcome to home view!</p>
            {this.props.username ?
            <p>Welcome, {this.props.username}</p>
                :
                <p>No user logged in</p>
            }
        </div>)
    }
}