import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Product } from './components/shopping';
import { Products } from './components/shopping'
import { Cart } from './components/shopping/Cart/Cart';

import './custom.css'

export default class App extends Component {
  //static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/productspage' component={Products}/>
        <Route path='/cart' component={Cart}/>
      </Layout>
    );
  }
}
