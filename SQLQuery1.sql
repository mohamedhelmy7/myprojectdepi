-- Migrations will appear here as you chat with AI

create table users (
  user_id bigint primary key generated always as identity,
  name text not null,
  email text not null unique,
  password text not null,
  phone text
);

create table admins (
  admin_id bigint primary key generated always as identity,
  name text not null,
  email text not null unique,
  password text not null
);

create table categories (
  category_id bigint primary key generated always as identity,
  name text not null
);

create table books (
  book_id bigint primary key generated always as identity,
  title text not null,
  author text not null,
  description text,
  category_id bigint references categories (category_id),
  admin_id bigint references admins (admin_id)
);

create table borrows (
  borrow_id bigint primary key generated always as identity,
  user_id bigint references users (user_id),
  book_id bigint references books (book_id),
  borrow_date timestamp with time zone not null
);

create table returns (
  return_id bigint primary key generated always as identity,
  borrow_id bigint references borrows (borrow_id),
  return_date timestamp with time zone not null
);