import React, { Component } from 'react';
import './Home.css';


export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello, Learner!</h1>
        <p>Welcome to Perspectify</p>

            <form action="User" method="post">
                <input type="text" name="mail" placeholder="Email"></input>
            <input type="password" name="hashpassword" placeholder="Password"></input>
                <input type="submit" value="Login"></input>
            </form>
        </div>
    );
  }

const Home = () => {
    return (<>
        <div className="home">
            <div className="text-box" >
                <h1>Start Your Journey</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. </p>
                <a href="/counter" className="btn1">GET Started</a>
            </div>
        </div>
       
    </>
        )

}
export default Home;