import styles from './Message.module.css'
import React from 'react';



const Message = (props) => {
    return <div className={styles.message}>{props.message}</div>
}

export default Message;