import styles from'./Header.module.css'
import React from 'react';

const Header = () => {
    return (
        <header className={styles.header}>
            <img src='https://www.logodesign.net/logo/line-art-house-roof-and-buildings-4485ld.png'></img>
        </header>
    );
}

export default Header;