import { sendMessageActionCreator, updateNewMessageTextActionCreator } from '../../redux/dialogs-reducer';
import { connect } from 'react-redux';
import { withAuthRedirect } from '../../hoc/withAuthRedirect';
import Dialogs from './Dialogs';
import { compose } from 'redux';

//Эта штука мапит пропсы в презентационную компоненту
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


export default compose(
    connect(mapStateToProps,mapDispatchToProps),
    withAuthRedirect
)(Dialogs)
