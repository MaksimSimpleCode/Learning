import { createStore,combineReducers } from "redux";
import dialogsReducer from "./dialogs-reducer";
import profileReducer from "./profile-reducer";
import sidebarReducer from "./sidebar-reducer";

let reducers = combineReducers({
    profilePage:profileReducer,
    dialogPage:dialogsReducer,
    sidebar:sidebarReducer
});
let store = createStore(reducers);


window.store=store;

export default store;