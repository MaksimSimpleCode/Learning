import axios from 'axios';

//Настраиваем конфигурацию запроса
const instans = axios.create({
    withCredentials: true,
    baseURL: 'https://social-network.samuraijs.com/api/1.0/',
    headers: {
        'API-KEY': '8d773fe3-77bf-479b-b2ca-81d49a73250f'
    }
});

export const usersAPI = {
    getUsers(currentPage = 1, pageSize = 10) {
        return instans.get(`users?page=${currentPage}&count=${pageSize}`)
            .then(response => {
                return response.data
            });
    },
    follow(userId){
        return instans.post(`follow/${userId}`)
    },
    unfollow(userId){
        return instans.delete(`follow/${userId}`)
    },
    getProfile(userId){
        return instans.get(`profile/${userId}`)
    }

}

export const authAPI = {
    me(){
        return instans.get(`auth/me`)
    }
}