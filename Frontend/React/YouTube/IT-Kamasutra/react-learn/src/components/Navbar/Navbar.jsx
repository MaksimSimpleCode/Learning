import styles from './Navbar.module.css'
import {NavLink } from 'react-router-dom';
import React from 'react';

const Navbar = () => {
  return (
    <nav className={styles.nav}>
      <div>
        <NavLink to='/profile'  className = { navData => navData.isActive ? styles.active : styles.item }>Profile</NavLink>
      </div>
      <div>
        <NavLink to='/dialogs' className = { navData => navData.isActive ? styles.active : styles.item }>Messages</NavLink>
      </div>
      <div>
        <NavLink to='/users'  className = { navData => navData.isActive ? styles.active : styles.item }>Users</NavLink>
      </div>
      <div>
        <NavLink to='1'  className = { navData => navData.isActive ? styles.active : styles.item }>News</NavLink>
      </div>
      <div>
        <NavLink to='2'  className = { navData => navData.isActive ? styles.active : styles.item }>Music</NavLink>
      </div>
      <div>
        <NavLink to='3'  className = { navData => navData.isActive ? styles.active : styles.item }>Settings</NavLink>
      </div>
    </nav>
  );
}

export default Navbar;