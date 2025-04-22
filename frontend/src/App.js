import React from "react";
import "./App.css";
import bookImage from "./assets/boo.png";

function App() {
  return (
    <div className="login-page">
      <header className="top-bar">
        <div className="logo">Library</div>
        <nav className="nav">
          <a href="#">Categories</a>
          <a href="#">Bestseller</a>
          <a href="#">New Released</a>
          <input type="text" placeholder="Search for books..." />
        </nav>
      </header>

      <main className="main-content">
        <div className="login-form">
          <h2>Sign In</h2>
          <input type="email" placeholder="Enter your email" />
          <input type="password" placeholder="Enter your password" />
          <button>Sign In</button>
          <a href="#">Forgot password?</a>
        </div>
        <div className="illustration">
          <img src={bookImage} alt="Books illustration" className="book-image" />
        </div>
      </main>

      <section className="newsletter">
        <h3>STAY UPDATE ABOUT OUR LATEST Book released</h3>
        <input type="email" placeholder="Enter your email address" />
        <button>Subscribe to Newsletter</button>
      </section>

      <footer className="footer">
        <div className="footer-columns">
          <div>
            <h4>Library</h4>
            <p>We have clothes that suits your style and which you’re proud to wear. From women to men.</p>
          </div>
          <div>
            <h4>Company</h4>
            <ul>
              <li>About</li>
              <li>Features</li>
              <li>Works</li>
              <li>Career</li>
            </ul>
          </div>
          <div>
            <h4>Help</h4>
            <ul>
              <li>Customer Support</li>
              <li>Delivery Details</li>
              <li>Terms & Conditions</li>
              <li>Privacy Policy</li>
            </ul>
          </div>
          <div>
            <h4>FAQ</h4>
            <ul>
              <li>Account</li>
              <li>Manage Deliveries</li>
              <li>Orders</li>
              <li>Payments</li>
            </ul>
          </div>
          <div>
            <h4>Resources</h4>
            <ul>
              <li>Free eBooks</li>
              <li>Development Tutorial</li>
              <li>How to - Blog</li>
              <li>YouTube Playlist</li>
            </ul>
          </div>
        </div>
        <div className="footer-bottom">
          <p>Shop.co © 2000–2023, All Rights Reserved</p>
        </div>
      </footer>
    </div>
  );
}

export default App;
