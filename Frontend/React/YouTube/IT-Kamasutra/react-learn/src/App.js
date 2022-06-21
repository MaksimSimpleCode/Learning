import { Route,Routes } from 'react-router-dom';
import React from 'react';
import './App.css';
import Dialogs from './components/Dialogs/Dialogs';
import Header from './components/Header/Header';
import Navbar from './components/Navbar/Navbar';
import Profile from './components/Profile/Profile';
import DialogsContainer from './components/Dialogs/DialogsContainer';

function App(props) {

  return (
      <div className='app-wrapper'>
        <Header />
        <Navbar />
        <div className='app-wrapper-content'>
          <Routes>
            
            <Route path="/profile" element={<Profile />} />
            <Route path="/dialogs" element={<DialogsContainer />} />
            <Route path='dialogs/*' element={<Dialogs />} />
          </Routes>
        </div>
      </div>
   
  );
}

export default App;
