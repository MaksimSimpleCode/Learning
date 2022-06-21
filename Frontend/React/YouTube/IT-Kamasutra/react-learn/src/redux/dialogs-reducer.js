

const SEND_MESSAGE = 'SEND_MESSAGE';
const UPDATE_NEW_MESSAGE_TEXT = 'UPDATE-NEW-MESSAGE-TEXT';

let initialState = {
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

const dialogsReducer = (state = initialState, action) => {

    switch (action.type) {
        case UPDATE_NEW_MESSAGE_TEXT:
            return {
                ...state,
                newMessageText: action.newText
            };


        case SEND_MESSAGE:
            let body = state.newMessageText;
            return {
                ...state,
                messages: [...state.messages, { id: 6, message: body }],
                newMessageText: ""
            };


        default:
            return state;
    }
}

export const sendMessageActionCreator = () => {
    return {
        type: SEND_MESSAGE
    }
}
export const updateNewMessageTextActionCreator = (body) => {
    return {
        type: UPDATE_NEW_MESSAGE_TEXT,
        newText: body
    }
}

export default dialogsReducer;