import { connect } from 'react-redux';
import { followAC, setUsersAC, unfollowAC } from '../../redux/users-reducer';
import Users from './Users';


//Эта штука мапит свойства в  пропсы  презентационной компоненты
let mapStateToProps = (state) => {
    return {
        users: state.usersPage.users
    }
}

//Эта штука мапит методы в пропсы презентационной компоненты
let mapDispatchToProps = (dispatch) => {
    return {
       follow:(userId)=>{
        dispatch(followAC(userId));
       },
       unfollow:(userId)=>{
        dispatch(unfollowAC(userId));
       },
       setUsers:(users)=>{
        dispatch(setUsersAC(users));
       }
    }
}


export default connect(mapStateToProps, mapDispatchToProps)(Users);

