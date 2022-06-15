import styles from './MyPosts.module.css'
import Post from './Post/Post';


const MyPosts = () => {

    let postsData = [
        { id: 1, message: "Hi, how arre you?", likesCount:"12" },
        { id: 2, message: "It's my first post", likesCount:"13" },
        { id: 3, message: "Yap Yan", likesCount:"56" },
        { id: 4, message: "Not war", likesCount:"32" },
        { id: 5, message: "Hello React", likesCount:"255" } 
    ];

    let mapPostsData = postsData.map((posts)=>{
        return <Post message={posts.message} likesCount={posts.likesCount} />
    });

    return (
        <div className={styles.postsBlock}>
            <h3>My posts</h3>
            <div>
                <div>
                    <textarea></textarea>
                </div>
                <div>
                    <button>Add post</button>
                </div>
            </div>
            <div className={styles.posts}>
                {mapPostsData}
            </div>
        </div>

    );
}

export default MyPosts;