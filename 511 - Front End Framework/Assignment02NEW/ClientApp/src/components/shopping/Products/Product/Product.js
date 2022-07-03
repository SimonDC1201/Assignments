import React, { Component } from "react";

export class Product extends Component {
    render(){
        console.log(this.props.Product);
        // return this.props.Products.map((product)=> (
        //     <Product key={product.productId} product={product} />
        // ));
        return (
            <p>This is a Product</p>
        )
    }
}

// Proptypes
// Product.propTypes = {
//     products: PropTypes.array.isRequired
// }


export default Product;