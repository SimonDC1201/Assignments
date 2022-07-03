import React from "react";
import {Product} from "./Product/Product";

export class Products extends React.Component {
    render(){
        console.log(this.props.Products);
        // return this.props.Products.map((product)=> (
        //     <Product key={product.productId} product={product} />
        // ));
        return (
            <div>
                <p>This is a Product Page</p>
                <p><Product /></p>
            </div>
        )
    }
}

// Proptypes
// Products.propTypes = {
//     products: PropTypes.array.isRequired
// }


export default Products;