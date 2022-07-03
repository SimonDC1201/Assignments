import React from 'react';
import {CartItem} from './CartItem/CartItem'

export class Cart extends React.Component{
    render(){
        return (
            <div>
                <h1>This is the Cart Page</h1>
                <CartItem />
            </div>
        )
    }
}

export default Cart;