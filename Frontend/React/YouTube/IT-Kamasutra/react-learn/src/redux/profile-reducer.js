
const ADD_POST = 'ADD-POST';
const UPDATE_NEW_POST_TEXT = 'UPDATE-NEW-POST-TEXT';

let initialState = {
    posts: [
        { id: 1, message: "Hi, how arre you?", likesCount: "12" },
        { id: 2, message: "It's my first post", likesCount: "13" },
        { id: 3, message: "Yap Yan", likesCount: "56" },
        { id: 4, message: "Not war", likesCount: "32" },
        { id: 5, message: "Hello React", likesCount: "255" }
    ],
    newPostText: "Maskim-Learn.com"
}
const profileReducer = (state = initialState, action) => {
    switch (action.type) {
        case ADD_POST: {
            let newPost = {
                id: 5,
                message: state.newPostText,
                likesCount: 0
            };
            //Создаем новый объект так как когда state менялся до этого , объект по сути был тем же и redux не понимал что он изменился (ему пофиг на содержимое)
            // и не происходила отрисовка
            return {
                ...state,
                posts: [...state.posts, newPost],
                newPostText: ""
            }
        }
        case UPDATE_NEW_POST_TEXT: {
            return {
                ...state,
                newPostText: action.newText
            };
        }
        default:
            return state;
    }
}

export const addPostActionCreator = () => {
    return {
        type: ADD_POST
    }
}
export const updateNewPostTextActionCreator = (text) => {
    return {
        type: UPDATE_NEW_POST_TEXT,
        newText: text
    }
}
export default profileReducer;