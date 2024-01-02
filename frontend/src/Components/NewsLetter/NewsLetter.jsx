import React from 'react'
import './NewsLetter.css'

const NewsLetter = () => {
  return (
    <div className='newsletter'>
        <h1>Get Exclusive Offers on your Email</h1>
        <p>Suscribe to our News Letter and stay updated</p>
        <div>
            <input type='email' placeholder='Your Email Address'/>
            <button>Suscribe</button>
        </div>
    </div>
  )
}

export default NewsLetter