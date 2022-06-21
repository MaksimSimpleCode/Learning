import styles from './Dialogs.module.css';
import React from 'react';
import DialogItem from './DialogItem/DialogItem';
import Message from './Message/Message';
import { addMessageActionCreator, updateNewMessageTextActionCreator } from '../../redux/dialogs-reducer';


const Dialogs = (props) => {
    

    let mapDialogsData =
    
        props.dialogPage.dialogs.map((dialog) => {
            return <DialogItem key = {dialog.id} name={dialog.name} id={dialog.id} />
        });

    let mapMessagesData =
        props.dialogPage.messages.map((message) => {
            return <Message key = {message.id} message={message.message} />
        });

       
    let onNewMessageChange = (e) => {
        let text = e.target.value;
        props.updateNewMessageBody(text);
    }
    let onSendMessageClick = () => {
        props.sendMessage();
    }


    return (
        <div className={styles.dialogs}>
            <div className={styles.dialogsItems}>
                {mapDialogsData}
            </div>
            <div className={styles.messages}>
                <div>{mapMessagesData}</div>
                <div>
                    <div>
                        <textarea onChange={onNewMessageChange} placeholder='Enter new message' value={props.dialogPage.newMessageText} />
                    </div>
                    <div>
                        <button onClick={onSendMessageClick}>Отправить сообщение</button>
                    </div>
                </div>
            </div>

        </div>
    );
}

export default Dialogs;