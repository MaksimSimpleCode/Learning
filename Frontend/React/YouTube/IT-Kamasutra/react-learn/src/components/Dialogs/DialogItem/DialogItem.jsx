import styles from './DialogItem.module.css'
import { NavLink } from 'react-router-dom';
import React from 'react';


const DialogItem = (props) => {
    //let path = "/dialogs/"+ props.id;
    let path = "/dialogs/*";
    return (
        <div className={styles.dialog + ' ' + styles.active}>
            <NavLink to={path}>{props.name}</NavLink>
        </div>
    );
}

export default DialogItem;