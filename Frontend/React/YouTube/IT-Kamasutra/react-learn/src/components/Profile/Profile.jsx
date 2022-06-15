import MyPosts from './MyPosts/MyPosts';
import styles from'./Profile.module.css'
import ProfileInfo from './ProfileInfo/ProfileInfo';
import React from 'react';



const Profile = (props) => {
    return (
        <div>
            <ProfileInfo/>
            <MyPosts posts={props.state.posts}/>
        </div>
    );
}

export default Profile;