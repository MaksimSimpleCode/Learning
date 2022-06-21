import React from 'react';
import styles from './Users.module.css';


let Users = (props) => {

    if(props.users.length===0){
        props.setUsers(
            [
                { id: 1, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: true, fullName: "Maksim", status: "I am a learning write now", location: { city: "Samara", country: "Russia" } },
                { id: 2, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: false, fullName: "Saha", status: "Hey anyway", location: { city: "Minsk", country: "Belarus" } },
                { id: 3, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: true, fullName: "Andrew", status: "lowe piss", location: { city: "LA", country: "USA" } },
                { id: 4, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: false, fullName: "Joe", status: " ahahaa", location: { city: "Moscow", country: "Russia" } },
            ]
        );
    }
  

debugger;
    return (
        <div>
            {props.users.map(u => <div key={u.id}>
                <span>
                    <div>
                        <img className={styles.userPhoto} src={u.photoUrl} />
                    </div>
                    <div>
                        {u.followed
                            ? <button onClick={() => { props.unfollow(u.id) }}>Unfollow</button>
                            : <button onClick={() => { props.follow(u.id) }}>Follow</button>}
                    </div>
                </span>
                <span>
                    <span>
                        <div>
                            {u.fullName}
                        </div>
                        <div>
                            {u.status}
                        </div>
                    </span>
                    <span>
                        <div>
                            {u.location.country}
                        </div>
                        <div>
                            {u.location.city}
                        </div>
                    </span>
                </span>
            </div>)
            }

        </div>
    );
}


export default Users;

