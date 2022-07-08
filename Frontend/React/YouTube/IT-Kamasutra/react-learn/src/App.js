import { Route,Routes } from 'react-router-dom';
import React from 'react';
import './App.css';
import Dialogs from './components/Dialogs/Dialogs';
import Navbar from './components/Navbar/Navbar';
import ProfileContainer from './components/Profile/ProfileContainer';
import DialogsContainer from './components/Dialogs/DialogsContainer';
import UsersContainer from './components/Users/UsersContainer';
import HeaderContainer from './components/Header/HeaderContainer';
import Login from './components/Login/Login';

function App() {

  return (
      <div className='app-wrapper'>
        <HeaderContainer />
        <Navbar />
        <div className='app-wrapper-content'>
          <Routes>
            <Route path="/profile/:userId" element={<ProfileContainer />} />
            <Route path='/profile' element={<ProfileContainer />} />
            <Route path="/dialogs" element={<DialogsContainer />} />
            <Route path='dialogs/*' element={<Dialogs />} />
            <Route path='users' element={<UsersContainer/>} />
            <Route path='/login' element={<Login/>} />
          </Routes>
        </div>
      </div>
   
  );
}

export default App;
