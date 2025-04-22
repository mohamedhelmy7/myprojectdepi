import React from 'react';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="sticky top-0 z-50 w-full bg-white">
        <div className="bg-black text-white text-xs py-1 px-4 text-center">
          Sign up and get 20% off on your first order. <button className="underline text-blue-500 hover:text-blue-700">Sign Up Now</button>
          <button className="absolute right-2 top-1 text-white">&times;</button>
        </div>
        <div className="flex items-center justify-between p-4 border-b">
          <div className="flex items-center">
            <h1 className="text-xl font-bold mr-8">Library</h1>
            <nav className="hidden md:flex space-x-6 text-sm">
              <div className="relative group">
                <button className="flex items-center">
                  Categories <span className="ml-1">▼</span>
                </button>
              </div>
              <a href="#bestsellers">Bestsellers</a>
              <a href="#new-releases">New Releases</a>
            </nav>
          </div>
          <div className="flex items-center space-x-4">
            <div className="relative">
              <input 
                type="search" 
                placeholder="Search for books..." 
                className="pl-4 pr-10 py-2 border rounded-full text-sm w-64"
              />
              <button className="absolute right-3 top-2">
                🔍
              </button>
            </div>
            <button className="relative">
              <span>🛒</span>
              <span className="absolute -top-2 -right-2 bg-black text-white text-xs w-5 h-5 flex items-center justify-center rounded-full">0</span>
            </button>
            <button>
              <span>👤</span>
            </button>
          </div>
        </div>
      </header>

      <main>
        {/* Hero Section */}
        <section className="bg-white py-12 px-4 md:px-8 lg:px-16">
          <div className="flex flex-col md:flex-row items-center">
            <div className="md:w-1/2 mb-8 md:mb-0">
              <h2 className="text-4xl font-bold mb-4">
                FIND BOOKS<br />
                THAT MATCHES<br />
                YOUR INTERESTS
              </h2>
              <p className="text-gray-600 mb-8">
                Browse through our vast collection of carefully curated books, designed
                to match your curiosity and cater to your passion for reading.
              </p>
              <button className="bg-black text-white px-6 py-3 rounded">
                Shop Now
              </button>
              
              <div className="flex mt-12 space-x-16">
                <div className="text-center">
                  <div className="text-2xl font-bold">200+</div>
                  <div className="text-sm text-gray-500">Premium Publishers</div>
                </div>
                <div className="text-center">
                  <div className="text-2xl font-bold">2,000+</div>
                  <div className="text-sm text-gray-500">Popular Books</div>
                </div>
                <div className="text-center">
                  <div className="text-2xl font-bold">30,000+</div>
                  <div className="text-sm text-gray-500">Happy Readers</div>
                </div>
              </div>
            </div>
            <div className="md:w-1/2">
              <div className="relative">
                <div className="bg-orange-200 rounded-lg h-64 w-full flex items-center justify-center">
                  <div className="text-4xl">📚</div>
                </div>
                <div className="absolute -top-4 -right-4 text-4xl">✨</div>
                <div className="absolute -bottom-2 -left-4 text-4xl">✨</div>
              </div>
            </div>
          </div>
          
          
          {/* Book platforms */}
          <div className="grid grid-cols-4 gap-4 mt-8 py-6 border-t border-b">
            <div className="text-center font-bold">BookVerse</div>
            <div className="text-center font-bold">PaperTrail</div>
            <div className="text-center font-bold italic">Booktopia</div>
            <div className="text-center font-bold">NovelHub</div>
          </div>
        </section>

        {/* Newly Added Books */}
        <section className="py-12 px-4 md:px-8 lg:px-16">
          <h2 className="text-2xl font-bold mb-8">NEWLY ADDED BOOKS</h2>
          <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
            {[1, 2, 3, 4].map(i => (
              <div key={i} className="book-card">
                <div className="bg-gray-100 aspect-square mb-3 rounded overflow-hidden">
                  <div className="w-full h-full flex items-center justify-center text-gray-400">Book Cover</div>
                </div>
                <h3 className="font-medium text-sm mb-1">Book Title {i}</h3>
                <div className="flex items-center space-x-2 mb-1">
                  <div className="flex text-sm text-yellow-400">★★★★★</div>
                  <span className="text-xs text-gray-500">(430)</span>
                </div>
                <div className="flex items-center space-x-2">
                  <span className="font-bold">${120 + i * 20}</span>
                  {i % 2 === 0 && (
                    <>
                      <span className="text-gray-400 line-through text-sm">${150 + i * 25}</span>
                      <span className="text-red-500 text-xs">-15%</span>
                    </>
                  )}
                </div>
              </div>
            ))}
          </div>
          <div className="text-center mt-8">
            <a href="#view-all" className="text-sm font-medium">View All</a>
          </div>
        </section>

        {/* Most Popular Books */}
        <section className="py-12 px-4 md:px-8 lg:px-16">
          <h2 className="text-2xl font-bold mb-8">MOST POPULAR BOOKS</h2>
          <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
            {[1, 2, 3, 4].map(i => (
              <div key={i} className="book-card">
                <div className="bg-gray-100 aspect-square mb-3 rounded overflow-hidden">
                  <div className="w-full h-full flex items-center justify-center text-gray-400">Book Cover</div>
                </div>
                <h3 className="font-medium text-sm mb-1">Popular Book {i}</h3>
                <div className="flex items-center space-x-2 mb-1">
                  <div className="flex text-sm text-yellow-400">★★★★★</div>
                  <span className="text-xs text-gray-500">(630)</span>
                </div>
                <div className="flex items-center space-x-2">
                  <span className="font-bold">${180 + i * 15}</span>
                  {i % 2 === 1 && (
                    <>
                      <span className="text-gray-400 line-through text-sm">${210 + i * 20}</span>
                      <span className="text-red-500 text-xs">-16%</span>
                    </>
                  )}
                </div>
              </div>
            ))}
          </div>
          <div className="text-center mt-8">
            <a href="#view-all" className="text-sm font-medium">View All</a>
          </div>
        </section>

        {/* Genre Section */}
        <section className="py-12 px-4 md:px-8 lg:px-16 bg-gray-50">
          <h2 className="text-2xl font-bold mb-8 text-center">BROWSE BY BOOK GENRE</h2>
          <div className="grid grid-cols-1 md:grid-cols-2 gap-6 max-w-4xl mx-auto">
            {['Fiction', 'Non-Fiction', 'Science', 'History'].map(genre => (
              <div key={genre} className="bg-white p-8 rounded-lg shadow-sm flex items-center justify-center">
                <h3 className="text-xl font-medium">{genre}</h3>
              </div>
            ))}
          </div>
        </section>

        {/* Testimonials */}
        <section className="py-12 px-4 md:px-8 lg:px-16">
          <div className="flex justify-between items-center mb-8">
            <h2 className="text-2xl font-bold">OUR HAPPY READERS</h2>
            <div className="flex space-x-2">
              <button className="w-8 h-8 rounded-full border flex items-center justify-center">←</button>
              <button className="w-8 h-8 rounded-full border flex items-center justify-center">→</button>
            </div>
          </div>
          
          <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
            {[
              {
                name: 'Sarah M.',
                text: "I've found wealth of books that exceeded all of my expectations at Library. From timeless classics to modern bestsellers, every book that was recommended has been exceptional."
              },
              {
                name: 'Alex K.',
                text: 'Finding books that match my interests used to be a challenge until I discovered Library. Their recommendation system is truly remarkable, catering to all my reading preferences.'
              },
              {
                name: 'James L.',
                text: "As someone who's always looking for unique reads, I'm thrilled to have found Library. Their collection is impressive but also perfectly curated with the latest publications."
              }
            ].map((testimonial, i) => (
              <div key={i} className="border rounded-lg p-6">
                <div className="flex text-yellow-400 mb-3">★★★★★</div>
                <p className="mb-4 text-sm">{testimonial.text}</p>
                <div className="flex items-center">
                  <div className="font-medium">{testimonial.name}</div>
                  <div className="ml-2 text-green-500 text-xs">✓</div>
                </div>
              </div>
            ))}
          </div>
        </section>

        {/* Newsletter */}
        <section className="bg-black text-white py-8 px-4 md:px-8 lg:px-16">
          <div className="max-w-3xl mx-auto">
            <h2 className="text-xl font-bold mb-4">STAY UPDATED WITH OUR LATEST BOOK RELEASES</h2>
            <div className="flex">
              <input 
                type="email" 
                placeholder="Enter your email" 
                className="flex-grow p-3 rounded-l text-black"
              />
              <button className="bg-white text-black px-6 py-3 rounded-r font-medium">
                Subscribe
              </button>
            </div>
          </div>
        </section>
      </main>

      {/* Footer */}
      <footer className="bg-white pt-12 pb-6 px-4 md:px-8 lg:px-16">
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-5 gap-8 mb-12">
          <div>
            <h3 className="text-sm font-bold uppercase mb-4">LIBRARY</h3>
            <p className="text-sm text-gray-500 mb-4">
              Discover a world of books that will transport you to new dimensions. The collection we have for you.
            </p>
            <div className="flex space-x-3">
              <a href="https://facebook.com" target="_blank" rel="noopener noreferrer" className="w-8 h-8 rounded-full bg-gray-200 flex items-center justify-center">f</a>
              <a href="https://twitter.com" target="_blank" rel="noopener noreferrer" className="w-8 h-8 rounded-full bg-gray-200 flex items-center justify-center">t</a>
              <a href="https://linkedin.com" target="_blank" rel="noopener noreferrer" className="w-8 h-8 rounded-full bg-gray-200 flex items-center justify-center">in</a>
            </div>
          </div>
          
          <div>
            <h3 className="text-sm font-bold mb-4">COMPANY</h3>
            <ul className="space-y-2 text-sm text-gray-500">
              <li><a href="/about-us">About Us</a></li>
              <li><a href="/partnerships">Partnerships</a></li>
              <li><a href="/authors">Authors</a></li>
              <li><a href="/contact-us">Contact Us</a></li>
            </ul>
          </div>
          
          <div>
            <h3 className="text-sm font-bold mb-4">HELP</h3>
            <ul className="space-y-2 text-sm text-gray-500">
              <li><a href="/customer-support">Customer Support</a></li>
              <li><a href="/delivery-details">Delivery Details</a></li>
              <li><a href="/usage-terms">Usage Terms</a></li>
              <li><a href="/privacy-policy">Privacy Policy</a></li>
            </ul>
          </div>
          
          <div>
            <h3 className="text-sm font-bold mb-4">FAQ</h3>
            <ul className="space-y-2 text-sm text-gray-500">
              <li><a href="/my-account">My Account</a></li>
              <li><a href="/manage-deliveries">Manage Deliveries</a></li>
              <li><a href="/orders">Orders</a></li>
              <li><a href="/payments">Payments</a></li>
            </ul>
          </div>
          
          <div>
            <h3 className="text-sm font-bold mb-4">RESOURCES</h3>
            <ul className="space-y-2 text-sm text-gray-500">
              <li><a href="/free-ebooks">Free eBooks</a></li>
              <li><a href="/reading-guides">Reading Guides</a></li>
              <li><a href="/book-reviews">Book Reviews</a></li>
              <li><a href="/author-interviews">Author Interviews</a></li>
            </ul>
          </div>
        </div>
        
        <div className="border-t pt-6 flex flex-col md:flex-row justify-between items-center">
          <div className="text-xs text-gray-500 mb-4 md:mb-0">
            LIBRARY © 2000-2023. All Rights Reserved
          </div>
          <div className="flex space-x-3">
            <div className="h-6 w-10 bg-gray-200 rounded">Visa</div>
            <div className="h-6 w-10 bg-gray-200 rounded">MC</div>
            <div className="h-6 w-10 bg-gray-200 rounded">PayPal</div>
            <div className="h-6 w-10 bg-gray-200 rounded">Other</div>
          </div>
        </div>
      </footer>
    </div>
  );
}
export default App;
