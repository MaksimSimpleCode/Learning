import styles from'./Header.module.css'
import React from 'react';
import { NavLink } from 'react-router-dom';

const Header = (props) => {
    return (
        <header className={styles.header}>
            <img src='https://www.logodesign.net/logo/line-art-house-roof-and-buildings-4485ld.png'></img>
            <div className={styles.loginBlock}>
                {props.isAuth ? "Ты в системе":<NavLink to={'/login'}>Login</NavLink>}
                
            </div>
        </header>
    );
}

export default Header;