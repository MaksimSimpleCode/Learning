import { sendMessageActionCreator, updateNewMessageTextActionCreator } from '../../redux/dialogs-reducer';
import Dialogs from './Dialogs';
import { connect } from 'react-redux';


let mapStateToProps=(state)=>{
    return{
        dialogPage:state.dialogPage
    }
 }
 let mapDispatchToProps=(dispatch)=>{
    return{
        updateNewMessageBody:(body)=>{
            dispatch(updateNewMessageTextActionCreator(body));
        },
        sendMessage:()=>{
            dispatch(sendMessageActionCreator())
        }
    }
 }
 
const DialogsContainer= connect(mapStateToProps,mapDispatchToProps)(Dialogs);

export default DialogsContainer;