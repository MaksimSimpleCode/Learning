import styles from './Post.module.css'
import React from 'react';


const Post = (props) => {
    return (

        <div className={styles.item}>
            <img src='https://i.playground.ru/p/lzF9n_oH7zjMPi6YYanG_A.jpeg'></img>
            {props.message}
            <div>
                <span>like</span> {props.likesCount}
            </div>
        </div>
    );
}

export default Post;