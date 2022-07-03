import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

    constructor() {

    }
  render () {
    return (
      <div>
            <h1>Hello, world!</h1>
            {this.Name }
            <p>My Name is Simon Dionne-Couture</p>
        </div>
    );
  }
}
