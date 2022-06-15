import styles from './Dialogs.module.css'
import { NavLink } from 'react-router-dom';
import DialogItem from './DialogItem/DialogItem';
import Message from './Message/Message';


const Dialogs = (props) => {

    let dialogsData = [
        { id: 1, name: "Maksim" },
        { id: 2, name: "Alena" },
        { id: 3, name: "Vladimir" },
        { id: 4, name: "Olga" },
        { id: 5, name: "Andrey" }
    ];
    let messagesData = [
        { id: 1, message: "Hi" },
        { id: 2, message: "Yo" },
        { id: 3, message: "True" },
        { id: 4, message: "Map top" },
        { id: 5, message: "Merge" }
    ];

    //Учимся мапить массивы
    let mapDialogsData =
        dialogsData.map((dialog) => {
            return <DialogItem name={dialog.name} id={dialog.id} />
        });

    let mapMessagesData =
        messagesData.map((message) => {
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