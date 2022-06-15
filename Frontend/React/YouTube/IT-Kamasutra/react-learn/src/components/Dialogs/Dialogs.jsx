import styles from './Dialogs.module.css';
import React from 'react';
import DialogItem from './DialogItem/DialogItem';
import Message from './Message/Message';


const Dialogs = (props) => {

    let mapDialogsData =
        props.state.dialogs.map((dialog) => {
            return <DialogItem name={dialog.name} id={dialog.id} />
        });

    let mapMessagesData =
        props.state.messages.map((message) => {
            return <Message message={message.message} />
        });


    return (
        <div className={styles.dialogs}>
            <div className={styles.dialogsItems}>
                {mapDialogsData}
            </div>
            <div className={styles.messages}>
                {mapMessagesData}
            </div>
        </div>
    );
}

export default Dialogs;