import React, { Component } from 'react';

export class Account extends Component {
  static displayName = Account.name;
 // const url = 'https://localhost:44352/user' 
  render() {
    return (
      <div className="parent-element">
        <div>
          <p>Please enter your Email</p>
          <input />
        </div>
              <div>
          <p>Please enter your Password</p>
          <input />
        </div>
        <div>
          <p>Repeat your Password</p>
          <input />
        </div>
      </div>
    );
  }
}
