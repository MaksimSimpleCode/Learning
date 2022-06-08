import React, { Component } from 'react';

export class MyCounter extends Component {
    static displayName = MyCounter.name;
    
    constructor(props) {
      //Сохраняем всегда!
      super(props);  

     this.state = { currentCount: 0 };
     this.incrementCounter = this.incrementCounter.bind(this);
     this.decrementCounter = this.decrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 1
    });
    }

    decrementCounter() {
        this.setState({
            currentCount: this.state.currentCount - 1
        });
    }

  render() {
    return (
      <div>
        <h1>Счетчик</h1>

        <p>Пример моего счетчика из компонента MyCounter.</p>

        <p aria-live="polite">Current count: <strong>{this.state.currentCount}</strong></p>

            <button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button>
            <button className="btn btn-primary" onClick={this.decrementCounter}>Decrement</button>
      </div>
    );
  }
}
