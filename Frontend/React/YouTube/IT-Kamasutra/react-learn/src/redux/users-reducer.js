const FOLLOW = "FOLLOW";
const UNFOLLOW = "UNFOLLOW";
const SET_USER = "SET_USER";


//Initials
let initialState = {
    users: [
        { id: 1, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: true, fullName: "Maksim", status: "I am a learning write now", location: { city: "Samara", country: "Russia" } },
        { id: 2, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: false, fullName: "Saha", status: "Hey anyway", location: { city: "Minsk", country: "Belarus" } },
        { id: 3, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: true, fullName: "Andrew", status: "lowe piss", location: { city: "LA", country: "USA" } },
        { id: 4, photoUrl: "https://s0.rbk.ru/v6_top_pics/media/img/1/88/756535684097881.jpg", followed: false, fullName: "Joe", status: " ahahaa", location: { city: "Moscow", country: "Russia" } },
    ],
    newPostText: "Maskim-Learn.com"
}


//Redusers
const usersReducer = (state = initialState, action) => {
    switch (action.type) {
        case FOLLOW:
            return {
                ...state,
                users: state.users.map(u => {
                    if (u.id === action.userId) {
                        return { ...u, followed: true }
                    }
                    return u;
                })
            }
        case UNFOLLOW:
            return {
                ...state,
                users: state.users.map(u => {
                    if (u.id === action.userId) {
                        return { ...u, followed: false }
                    }
                    return u;
                })
            }
        case SET_USER:
            return { ...state, users: [...state.users, ...action.users] }

        default:
            return state;
    }
}

//Action creaters
export const followAC = (userId) => ({ type: FOLLOW, userId });
export const unfollowAC = (userId) => ({ type: UNFOLLOW, userId });
export const setUsersAC = (users) => ({ type: SET_USER, users });







export default usersReducer;