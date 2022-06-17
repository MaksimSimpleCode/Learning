let store = {
    _state: {
        profilePage: {
            posts: [
                { id: 1, message: "Hi, how arre you?", likesCount: "12" },
                { id: 2, message: "It's my first post", likesCount: "13" },
                { id: 3, message: "Yap Yan", likesCount: "56" },
                { id: 4, message: "Not war", likesCount: "32" },
                { id: 5, message: "Hello React", likesCount: "255" }
            ],
            newPostText: "Maskim-Learn.com"
        },
        dialogPage: {
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
            ]
        }
    },
    getState() {
        return this._state;
    },
    subscribe(observer) {
        this._callSubscriber = observer;
    },

    _callSubscriber() {
        console.log("State is changed")
    },


    dispatch(action) {
        if (action.type === 'ADD-POST') {
            let newPost = {
                id: 5,
                message: this._state.profilePage.newPostText,
                likesCount: 0
            };
            this._state.profilePage.posts.push(newPost);
            this._state.profilePage.newPostText = '';
            this._callSubscriber(this._state);
        } else if (action.type === 'UPDATE-NEW-POST-TEXT') {
            this._state.profilePage.newPostText = action.newText;
            this._callSubscriber(this._state);
        }
    }
}

export default store;
window.store = store;