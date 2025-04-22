import React, { useState } from 'react';
import './BookDetails.css';

const BookDetails = () => {
  const [quantity, setQuantity] = useState(1);

  const incrementQuantity = () => {
    setQuantity(prev => prev + 1);
  };

  const decrementQuantity = () => {
    if (quantity > 1) {
      setQuantity(prev => prev - 1);
    }
  };

  return (
    <div className="library-container">
      {/* Header */}
      <header className="header">
        <div className="top-banner">
          <span>Sign up now and get 20% off your first order. Terms apply.</span>
          <button className="close-button">×</button>
        </div>
        <nav className="main-nav">
          <div className="logo-section">
            <h1>LIBRARY</h1>
          </div>
          <div className="categories-section">
            <span>Categories</span>
            <span>Bestsellers</span>
            <span>New Releases</span>
            <div className="search-bar">
              <input type="text" placeholder="Search for books, authors..." />
              <button className="search-button">🔍</button>
            </div>
          </div>
          <div className="user-actions">
            <button className="icon-button">👤</button>
            <button className="icon-button">🛒 0</button>
          </div>
        </nav>
      </header>

      {/* Breadcrumb */}
      <div className="breadcrumb">
        <span>Home</span> / <span>Books</span> / <span>Fiction</span> / <span>Classics</span>
      </div>

      {/* Book Detail Main Content */}
      <div className="book-detail-content">
        <div className="book-detail-left">
          <div className="book-images">
            <div className="main-image">
              <div className="book-placeholder"></div>
            </div>
            <div className="thumbnail-images">
              <div className="thumbnail-placeholder"></div>
              <div className="thumbnail-placeholder"></div>
              <div className="thumbnail-placeholder"></div>
            </div>
          </div>
        </div>

        <div className="book-detail-right">
          <h1 className="book-title">The Great Gatsby</h1>
          <div className="book-rating">
            <div className="stars">
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-empty">★</span>
            </div>
            <span className="rating-count">(128)</span>
          </div>

          <div className="book-price-container">
            <span className="current-price">$260</span>
            <span className="original-price">$300</span>
            <span className="discount-label">-15%</span>
          </div>

          <p className="book-description">
            "A classic captures F. Scott Fitzgerald's portrayal of 1920s' wealth, and the American Dream."
          </p>

          <div className="format-language">
            <div className="format">
              <p>Format: Hardcover</p>
            </div>
            <div className="language">
              <p>Language: English</p>
            </div>
          </div>

          <div className="quantity-cart-section">
            <div className="quantity-selector">
              <button className="quantity-btn" onClick={decrementQuantity}>-</button>
              <span className="quantity-value">{quantity}</span>
              <button className="quantity-btn" onClick={incrementQuantity}>+</button>
            </div>
            <button className="add-to-cart-btn">Add to Cart</button>
          </div>
        </div>
      </div>

      {/* Tabs */}
      <div className="tabs-container">
        <div className="tabs">
          <div className="tab active">Book Details</div>
          <div className="tab">Ratings & Reviews</div>
          <div className="tab">FAQs</div>
        </div>

        {/* Reviews Section */}
        <div className="reviews-section">
          <h3>Reader Reviews</h3>
          
          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Samantha D.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
              </div>
            </div>
            <p className="review-text">
              "Absolutely breathtaking! This novel still is captivating, poetic, and relevant for our time. The depth of Gatsby's character is unforgettable."
            </p>
            <p className="review-date">Posted on August 14, 2023</p>
          </div>

          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Alex M.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-empty">★</span>
              </div>
            </div>
            <p className="review-text">
              "Beautiful prose! The story is short but filled with symbolic richness. I almost gave it 5 stars because the author's writing is so incredible but the characters can be a bit cynical sometimes because it's satirical."
            </p>
            <p className="review-date">Posted on August 11, 2023</p>
          </div>

          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Elijah P.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-empty">★</span>
                <span className="star-empty">★</span>
              </div>
            </div>
            <p className="review-text">
              "Not my favorite experience. The writing style is brilliant and the Jazz Age is beautifully rendered, but the plot leaves you unsatisfied by the end."
            </p>
            <p className="review-date">Posted on August 18, 2023</p>
          </div>

          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Olivia J.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-empty">★</span>
              </div>
            </div>
            <p className="review-text">
              "This is a book that has stayed with me since I first read it in high school. The description, the symbolism, and the words touched my heart. The green light at the end of the dock represents our yearning for what we can't have."
            </p>
            <p className="review-date">Posted on August 22, 2023</p>
          </div>

          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Liam T.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
              </div>
            </div>
            <p className="review-text">
              "A true classic at the height of modern storytelling. This book is one of the most beautifully written novels ever. From its stunning, rich, and lyrical prose to its flawlessly constructed narrative, it's a masterpiece."
            </p>
            <p className="review-date">Posted on August 18, 2023</p>
          </div>

          <div className="review">
            <div className="review-header">
              <div className="reviewer-info">
                <span className="reviewer-name">Ava K.</span>
                <span className="verified-badge">✓</span>
              </div>
              <div className="review-stars">
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
                <span className="star-filled">★</span>
              </div>
            </div>
            <p className="review-text">
              "Simply a must-read! The writing feels as perfect and elegant as possible. It manages to create a book that's both accessible to everyone and yet has continued literary importance."
            </p>
            <p className="review-date">Posted on August 20, 2023</p>
          </div>

          <button className="load-more-button">Load More Reviews</button>
        </div>
      </div>

      {/* Recommendations */}
      <div className="recommendations-section">
        <h3>You might also like</h3>
        <div className="recommended-books">
          <div className="book-card">
            <div className="book-placeholder"></div>
            <h4>George Orwell's Collected Works</h4>
            <div className="book-rating small">
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-empty">★</span>
              <span className="rating-count">(85)</span>
            </div>
            <div className="book-price">$232</div>
          </div>

          <div className="book-card">
            <div className="book-placeholder"></div>
            <h4>Moaning Myrtle</h4>
            <div className="book-rating small">
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-empty">★</span>
              <span className="star-empty">★</span>
              <span className="rating-count">(42)</span>
            </div>
            <div className="book-price">$190</div>
          </div>

          <div className="book-card">
            <div className="book-placeholder"></div>
            <h4>DOF Bokchick's</h4>
            <div className="book-rating small">
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-empty">★</span>
              <span className="rating-count">(61)</span>
            </div>
            <div className="book-price">$160</div>
          </div>

          <div className="book-card">
            <div className="book-placeholder"></div>
            <h4>Love island</h4>
            <div className="book-rating small">
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="star-filled">★</span>
              <span className="rating-count">(73)</span>
            </div>
            <div className="book-price-container small">
              <span className="current-price">$125</span>
              <span className="original-price">$150</span>
              <span className="discount-label">-15%</span>
            </div>
          </div>
        </div>
      </div>

      {/* Newsletter */}
      <div className="newsletter-section">
        <h3>STAY UPDATED WITH OUR LATEST BOOK RELEASES</h3>
        <div className="newsletter-form">
          <input type="email" placeholder="Your email address" />
          <button>Subscribe</button>
        </div>
      </div>

      {/* Footer */}
      <footer className="footer">
        <div className="footer-content">
          <div className="footer-column">
            <h4>Library</h4>
            <ul>
              <li>About us</li>
              <li>Our team</li>
              <li>Contact</li>
              <li>Blog</li>
              <li>Career</li>
            </ul>
          </div>
          <div className="footer-column">
            <h4>CONTENT</h4>
            <ul>
              <li>Books</li>
              <li>New Releases</li>
              <li>E-Books</li>
              <li>Audio Books</li>
              <li>Reading Lists</li>
            </ul>
          </div>
          <div className="footer-column">
            <h4>HELP</h4>
            <ul>
              <li>Customer Support</li>
              <li>Delivery Details</li>
              <li>Returns</li>
              <li>Terms & Conditions</li>
              <li>FAQs</li>
            </ul>
          </div>
          <div className="footer-column">
            <h4>FIND</h4>
            <ul>
              <li>Account</li>
              <li>Shop</li>
              <li>Gift Cards</li>
              <li>About</li>
            </ul>
          </div>
          <div className="footer-column">
            <h4>RESOURCES</h4>
            <ul>
              <li>The Library</li>
              <li>Development Support</li>
              <li>Get the App</li>
              <li>Help to Find</li>
              <li>Blog</li>
            </ul>
          </div>
        </div>

        <div className="footer-bottom">
          <div className="copyright">
            <p>© Copyright 1995-2023. All Rights Reserved.</p>
          </div>
          <div className="social-icons">
            <span className="social-icon">f</span>
            <span className="social-icon">t</span>
            <span className="social-icon">in</span>
            <span className="social-icon">p</span>
          </div>
          <div className="payment-methods">
            <span className="payment-icon">Visa</span>
            <span className="payment-icon">MC</span>
            <span className="payment-icon">Amex</span>
            <span className="payment-icon">PayPal</span>
            <span className="payment-icon">Apple Pay</span>
          </div>
        </div>
      </footer>
    </div>
  );
};

export default BookDetails;
