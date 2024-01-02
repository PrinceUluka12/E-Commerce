import React, { createContext, useState, useContext, useEffect } from 'react';
const ApiContext = createContext();
export const ApiProvider = ({ children }) => {
    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);

    const fetchData = async (url) => {
        try {
            setLoading(true)
            const response = await fetch(url)
            const result = await response.json()
            console.log(result.result)
            setData(result.result);
        } catch (error) {
            setError(error)
        }finally{
            setLoading(false)
        }
    };

    useEffect(() =>{
        fetchData("https://localhost:44391/api/ProductAPI");
    },[]);


    const value = {
        data,
        loading,
        error,
        fetchData,
      };

      return <ApiContext.Provider value={value}>{children}</ApiContext.Provider>;

};
export const useApi = () => {
    const context = useContext(ApiContext);
    if (!context) {
      throw new Error('useApi must be used within an ApiProvider');
    }
    return context;
  };