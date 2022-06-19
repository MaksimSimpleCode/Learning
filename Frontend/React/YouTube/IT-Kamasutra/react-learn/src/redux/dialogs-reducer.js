

const ADD_MESSAGE = 'ADD-MESSAGE';
const UPDATE_NEW_MESSAGE_TEXT = 'UPDATE-NEW-MESSAGE-TEXT';

let initialState ={
    messages: [
        { id: 1, message: "Hi" },
        { id: 2, message: "Yo" },
        { id: 3, message: "True" },
        { id: 4, message: "Map top" },
        { id: 5, message: "Merge" },
        { id: 6, message: "Test" }
    ],

    dialogs: [
        { id: 1, name: "Maksim" },
        { id: 2, name: "Alena" },
        { id: 3, name: "Vladimir" },
        { id: 4, name: "Olga" },
        { id: 5, name: "Andrey" },
        { id: 6, name: "Elena" }
    ],
    newMessageText: ""
}

const dialogsReducer = (state =initialState, action) => {

    switch (action.type) {
        case ADD_MESSAGE:
            let newMessage = {
                id: 5,
                message: state.newMessageText
            };
            state.messages.push(newMessage);
            state.newMessageText = '';
            return state;

        case UPDATE_NEW_MESSAGE_TEXT:
            state.newMessageText = action.newText;
            return state;

        default:
            return state;
    }
}

export const addMessageActionCreator = () => {
    return {
        type: ADD_MESSAGE
    }
}
export const updateNewMessageTextActionCreator = (text) => {
    return {
        type: UPDATE_NEW_MESSAGE_TEXT,
        newText: text
    }
}

export default dialogsReducer;