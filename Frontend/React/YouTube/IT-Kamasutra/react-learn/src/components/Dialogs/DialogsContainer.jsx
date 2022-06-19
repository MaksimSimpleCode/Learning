import React from 'react';
import { addMessageActionCreator, updateNewMessageTextActionCreator } from '../../redux/dialogs-reducer';
import Dialogs from './Dialogs';


const DialogsContainer = (props) => {
 
    let state = props.store.getState().dialogPage;

    let onSendMessageClick = () => {
        props.store.dispatch(addMessageActionCreator())
    }

    let updateNewMessageBody = (body) => {
        props.store.dispatch(updateNewMessageTextActionCreator(body))
    }


    return (
        
        <Dialogs updateNewMessageBody={updateNewMessageBody} sendMessage={onSendMessageClick} dialogPage={state} newMessageText={state.newMessageText} />
    );
}

export default DialogsContainer;