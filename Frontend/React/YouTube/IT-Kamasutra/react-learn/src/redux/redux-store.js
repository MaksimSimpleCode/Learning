import { createStore,combineReducers, applyMiddleware } from "redux";
import authReducer from "./auth-reducer";
import dialogsReducer from "./dialogs-reducer";
import profileReducer from "./profile-reducer";
import sidebarReducer from "./sidebar-reducer";
import usersReducer, { getUsersThunkCreator } from "./users-reducer";
import thunk from "redux-thunk";

let reducers = combineReducers({
    profilePage:profileReducer,
    dialogPage:dialogsReducer,
    sidebar:sidebarReducer,
    usersPage:usersReducer,
    auth:authReducer
});
let store = createStore(reducers,applyMiddleware(thunk));


window.store=store;

export default store;