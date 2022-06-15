import { Route, BrowserRouter, Routes } from 'react-router-dom';
import React from 'react';
import './App.css';
import Dialogs from './components/Dialogs/Dialogs';
import Header from './components/Header/Header';
import Navbar from './components/Navbar/Navbar';
import Profile from './components/Profile/Profile';

function App(props) {

  return (
    <BrowserRouter>
      <div className='app-wrapper'>
        <Header />
        <Navbar />

        <div className='app-wrapper-content'>
          <Routes>
            {/* <Route path='/profile' element={<Profile />} />
            <Route path='/dialogs' element={<Dialogs />} />
            <Route path='dialogs/*' element={<Dialogs />} /> */}
              
            <Route path="/profile" element={<Profile state={props.state.profilePage} />} />
            <Route path="/dialogs" element={<Dialogs state={props.state.dialogPage} />} />
            <Route path='dialogs/*' element={<Dialogs />} /> 
          </Routes>
        </div>
      </div>
    </BrowserRouter>
  );
}

export default App;
