import styles from './MyPosts.module.css'
import Post from './Post/Post';
import React from 'react';
import { addPostActionCreator,updateNewPostTextActionCreator } from '../../../redux/profile-reducer';




const MyPosts = (props) => {

    let mapPostsData = props.posts.map((posts) => {
        return <Post message={posts.message} likesCount={posts.likesCount} />
    });

    // Создаем ссылку которая затем привязывается в textarea
    let newPostElement = React.createRef();

    let addPost = () => {
        props.dispatch(addPostActionCreator());
    }

    let onPostChange=()=>{
        let text = newPostElement.current.value;
        props.dispatch(updateNewPostTextActionCreator(text))
    }

    return (
        <div className={styles.postsBlock}>
            <h3>My posts</h3>
            <div>
                <div>
                    <textarea onChange={onPostChange}
                    ref={newPostElement} value={props.newPostText} />
                </div>
                <div>
                    <button onClick={addPost}>Add post</button>
                </div>
            </div>
            <div className={styles.posts}>
                {mapPostsData}
            </div>
        </div>

    );
}

export default MyPosts;