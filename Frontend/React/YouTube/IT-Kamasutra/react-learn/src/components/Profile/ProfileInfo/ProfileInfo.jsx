import styles from './ProfileInfo.module.css'
import React from 'react';
import Preloader from '../../common/Preloader/Preloader';



const ProfileInfo = (props) => {

    if (!props.profile) {
        return <Preloader />
    }
    return (
        <div>
            <div>
                <img src='https://images.ctfassets.net/hrltx12pl8hq/7yQR5uJhwEkRfjwMFJ7bUK/dc52a0913e8ff8b5c276177890eb0129/offset_comp_772626-opt.jpg?fit=fill&w=800&h=300'></img>
            </div>
            <div className={styles.descriptionBlock}>
                <img src={props.profile.photos.large} />
                <div>
                    <div><b>{props.profile.fullName}</b></div>
                </div>
                <div>
                    <div><b>Контакты:</b></div>
                    <div>VK: {props.profile.contacts.vk}</div>
                </div>
                <div>
                    <div><b>Описание:</b></div>
                    <div>О себе: {props.profile.aboutMe}</div>
                    <div>Статус: {props.profile.lookingForAJobDescription}</div>

                </div>



            </div>
        </div>
    );
}

export default ProfileInfo;