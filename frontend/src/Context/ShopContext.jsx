import React, { createContext ,useState,useEffect} from 'react'
import all_product from '../Components/Assests/all_product'
export const ShopContext = createContext(null)


const ShopContextProvider = (props) => {

  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  
  const fetchData = async (url) => {
    try {
        setLoading(true)
        const response = await fetch(url)
        await response.json().then(json =>{
          setData(json.result);
        })
       
    } catch (error) {
        setError(error)
    }finally{
        setLoading(false)
    }
};

useEffect(() =>{
  fetchData("https://localhost:7004/api/ProductAPI");
},[]);

const getDefaultCart = () =>{
    let cart = {};
   if(data === null) return null;
    for(let index =0; index < data.length +1; index++)
    {
        cart[index] = 0;
    }
    console.log(cart)
    return cart;
}

const [cartItems, setcartItems] = useState(getDefaultCart());

    const addToCart = (itemId) =>{
        setcartItems((prev) => ({...prev,[itemId] : prev[itemId]+1 }))
    }

    const removeFromCart = (itemId) =>{
        setcartItems((prev) => ({...prev,[itemId] : prev[itemId]-1 }))
    }

    const getTotalCartAmount = () =>{
        let totalAmount = 0;
        for(const item in cartItems)
        {
            console.log(item);
            if(cartItems[item] > 0)
            {
                let itemInfo = all_product.find((product) => product.id === Number(item));
                totalAmount += itemInfo.new_price * cartItems[item];
            }
        }
        return totalAmount;
    }
    const GetCartItemsCount = () =>{
        
        if(cartItems && cartItems.count !== 0)
        {
            console.log(cartItems.count)
            return cartItems.count;
        }else
        {
            return 0;
        }
    }
   

    const [cartItemsCount, setcartItemsCount] = useState(GetCartItemsCount())
    

    const contextValue = {getTotalCartAmount,all_product,cartItems,addToCart,removeFromCart,data,
      loading,
      error,
      fetchData,cartItemsCount};

    return (
        <ShopContext.Provider value={contextValue}>
            {props.children}
        </ShopContext.Provider>
    )
}

export default ShopContextProvider;